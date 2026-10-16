using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PKMNED.Core.CTR;
public sealed class SARC : IDisposable
{
    private const string Identifier = nameof(SARC);

    public string Magic;
    public ushort HeaderSize;
    public ushort Endianness;
    public uint FileSize;
    public uint DataOffset;
    public uint Unknown;

    public SFAT SFAT;
    public SFNT SFNT;
    public string FileName;
    public string FilePath;
    public string Extension;
    public readonly bool Valid;
    public bool SigMatches => Magic == Identifier;
    private readonly Stream stream;
    private readonly BinaryReader br;
    public SARC()
    {
        SFAT = new SFAT();
        SFNT = new SFNT();
    }
    public SARC(string path)
    {
        SetFileInfo(path);

        stream = File.OpenRead(path);
        br = new BinaryReader(stream);
        ReadSARC();
        Valid = true;
    }
    public SARC(Stream fs)
    {
        stream = fs;
        br = new BinaryReader(stream);
        ReadSARC();
        Valid = true;
    }
    public SARC(byte[] data)
    {
        stream = new MemoryStream(data);
        br = new BinaryReader(stream);
        ReadSARC();
        Valid = true;
    }
    private void ReadSARC()
    {
        Magic = new string(br.ReadChars(4));
        if (!SigMatches)
            return;

        HeaderSize = br.ReadUInt16();
        Endianness = br.ReadUInt16();
        FileSize = br.ReadUInt32();
        DataOffset = br.ReadUInt32();
        Unknown = br.ReadUInt32();

        SFAT = new SFAT(br);
        SFNT = new SFNT(br);
    }
    public void SetFileInfo(string path)
    {
        FileName = Path.GetFileNameWithoutExtension(path);
        FilePath = Path.GetDirectoryName(path);
        Extension = Path.GetExtension(path);
    }
    public string GetFileName(SFATEntry entry) => GetFileName(entry.FileNameOffset);
    public byte[] GetData(SFATEntry entry) => GetData(entry.FileDataStart, entry.FileDataLength);
    public void SetData(SFATEntry entry, byte[] data)
    {
        if (data.Length != entry.FileDataLength)
            throw new ArgumentException(nameof(data.Length));
        SetData(entry.FileDataStart, data);
    }
    public string ExportFile(SFATEntry t, string outpath = null)
    {
        outpath ??= FilePath;
        byte[] data = GetData(t);
        string name = GetFileName(t);

        string dir = Path.GetDirectoryName(name) ?? throw new ArgumentException(name);
        string location = Path.Combine(outpath, dir);
        Directory.CreateDirectory(location);

        var filepath = Path.Combine(outpath, name);
        File.WriteAllBytes(filepath, data);
        return filepath;
    }
    public IEnumerable<string> Dump(string path = null, string folder = null)
    {
        path ??= FilePath;
        ArgumentNullException.ThrowIfNull(path);
        if (File.Exists(path))
            path = Path.GetDirectoryName(path);
        ArgumentNullException.ThrowIfNull(path);

        folder ??= FileName ?? "sarc";
        string dir = Path.Combine(path, folder);

        Directory.CreateDirectory(dir);

        foreach (SFATEntry t in SFAT.Entries)
            yield return ExportFile(t, dir);
    }

    private string GetFileName(int offset)
    {
        stream.Seek(SFNT.StringOffset, SeekOrigin.Begin);
        stream.Seek((offset & 0x00FFFFFF) * 4, SeekOrigin.Current);
        var sb = new StringBuilder();
        for (char c = (char)stream.ReadByte(); c != 0; c = (char)stream.ReadByte())
            sb.Append(c);

        return sb.ToString().Replace('/', Path.DirectorySeparatorChar);
    }

    public void SetFileName(int offset, string value)
    {
        var str = value.Replace(Path.DirectorySeparatorChar, '/');
        stream.Seek(SFNT.StringOffset, SeekOrigin.Begin);
        stream.Seek((offset & 0x00FFFFFF) * 4, SeekOrigin.Current);
        foreach (var b in str)
            stream.WriteByte((byte)b);
        stream.WriteByte((byte)'\0');
    }

    private byte[] GetData(int offset, int length)
    {
        byte[] fileBuffer = new byte[length];
        stream.Seek(offset + DataOffset, SeekOrigin.Begin);
        stream.ReadExactly(fileBuffer, 0, length);
        return fileBuffer;
    }

    private void SetData(int offset, byte[] data)
    {
        stream.Seek(offset + DataOffset, SeekOrigin.Begin);
        stream.Write(data, 0, data.Length);
    }
    public void Dispose()
    {
        stream?.Dispose();
        br?.Dispose();
    }
}
public class SFAT
{
    public const string Identifier = nameof(SFAT);
    public bool SigMatches => Magic == Identifier;

    public string Magic;
    public ushort HeaderSize;
    public ushort EntryCount;
    public uint HashMult;
    public List<SFATEntry> Entries;

    public SFAT() { }

    public SFAT(BinaryReader br)
    {
        Magic = new string(br.ReadChars(4));
        if (!SigMatches)
            throw new FormatException(nameof(SFAT));

        HeaderSize = br.ReadUInt16();
        EntryCount = br.ReadUInt16();
        HashMult = br.ReadUInt32();
        Entries = [];

        for (int i = 0; i < EntryCount; i++)
            Entries.Add(new SFATEntry(br));
    }
}
public class SFNT
{
    public const string Identifier = nameof(SFNT);
    public bool SigMatches => Magic == Identifier;

    public string Magic;
    public ushort HeaderSize;
    public ushort Unknown;
    public uint StringOffset;

    public SFNT() { }

    public SFNT(BinaryReader br)
    {
        Magic = new string(br.ReadChars(4));
        if (!SigMatches)
            throw new FormatException(nameof(SFNT));

        HeaderSize = br.ReadUInt16();
        Unknown = br.ReadUInt16();
        StringOffset = (uint)br.BaseStream.Position;
    }
}
public class SFATEntry(BinaryReader br)
{
    public uint FileNameHash = br.ReadUInt32();
    public int FileNameOffset = br.ReadInt32();
    public int FileDataStart = br.ReadInt32();
    public int FileDataEnd = br.ReadInt32();

    public int FileDataLength => FileDataEnd - FileDataStart;
}