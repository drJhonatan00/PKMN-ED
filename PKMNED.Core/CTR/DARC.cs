using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PKMNED.Core.CTR;

public class DARC
{
    public byte[] Data;
    public DARCHeader Header;
    public FileTableEntry[] Entries;
    public NameTableEntry[] FileNameTable;

    public DARC(byte[] Data = null)
    {
        if (Data == null) return;
        using var br = new BinaryReader(new MemoryStream(Data));
        try
        {
            Header = new DARCHeader(br);
            br.BaseStream.Position = Header.FileTableOffset;
            var root = new FileTableEntry(br);
            Entries = new FileTableEntry[root.DataLength];
            Entries[0] = root;
            for (int i = 1; i < root.DataLength; i++) Entries[i] = new FileTableEntry(br);
            FileNameTable = new NameTableEntry[root.DataLength];
            uint offs = 0;
            for (int i = 0; i < root.DataLength; i++)
            {
                char c; string s = string.Empty;
                while ((c = (char)br.ReadUInt16()) > 0) s += c;

                FileNameTable[i] = new NameTableEntry(offs, s);
                offs += ((uint)s.Length * 2) + 2;
            }
            br.BaseStream.Position = Header.FileDataOffset;
            this.Data = br.ReadBytes((int)(Header.FileSize - Header.FileDataOffset));
        }
        catch (Exception)
        { br.Close(); }
    }

    public class DARCHeader
    {
        public DARCHeader(BinaryReader br = null)
        {
            if (br == null) return;
            Signature = new string(br.ReadChars(4));
            if (Signature != "darc") throw new Exception(Signature);
            Endianness = br.ReadUInt16();
            HeaderSize = br.ReadUInt16();
            Version = br.ReadUInt32();
            FileSize = br.ReadUInt32();
            FileTableOffset = br.ReadUInt32();
            FileTableLength = br.ReadUInt32();
            FileDataOffset = br.ReadUInt32();
        }

        public string Signature;
        public ushort Endianness;
        public ushort HeaderSize;
        public uint Version;
        public uint FileSize;
        public uint FileTableOffset;
        public uint FileTableLength;
        public uint FileDataOffset;
    }

    public class FileTableEntry
    {
        public FileTableEntry(BinaryReader br = null)
        {
            if (br == null) return;
            NameOffset = br.ReadUInt32();
            IsFolder = NameOffset >> 24 == 1;
            NameOffset &= 0xFFFFFF;
            DataOffset = br.ReadUInt32();
            DataLength = br.ReadUInt32();
        }

        public uint NameOffset;
        public bool IsFolder;
        public uint DataOffset;
        public uint DataLength;
    }

    public class NameTableEntry(uint offset, string fileName)
    {
        public uint NameOffset = offset;
        public string FileName = fileName;
    }
    public static byte[] SetDARC(DARC darc)
    {
        using var ms = new MemoryStream();
        using var bw = new BinaryWriter(ms);
        bw.Write(Encoding.ASCII.GetBytes(darc.Header.Signature));
        bw.Write(darc.Header.Endianness);
        bw.Write(darc.Header.HeaderSize);
        bw.Write(darc.Header.Version);
        bw.Write(darc.Header.FileSize);
        bw.Write(darc.Header.FileTableOffset);
        bw.Write(darc.Header.FileTableLength);
        bw.Write(darc.Header.FileDataOffset);
        foreach (FileTableEntry entry in darc.Entries)
        {
            bw.Write(entry.NameOffset | (entry.IsFolder ? (uint)1 << 24 : 0));
            bw.Write(entry.DataOffset);
            bw.Write(entry.DataLength);
        }
        foreach (NameTableEntry entry in darc.FileNameTable)
        {
            bw.Write(Encoding.Unicode.GetBytes(entry.FileName + "\0"));
        }
        while (bw.BaseStream.Position < darc.Header.FileDataOffset)
            bw.Write((byte)0);
        bw.Write(darc.Data);

        return ms.ToArray();
    }

    public static DARC GetDARC(string folderName)
    {
        List<FileTableEntry> EntryList = [];
        List<NameTableEntry> NameList = [];
        byte[] Data = [];
        uint nameOffset = 6;
        {
            {
                EntryList.Add(new FileTableEntry { DataOffset = 0, DataLength = 0, IsFolder = true, NameOffset = 0 });
                NameList.Add(new NameTableEntry(0, ""));
            }
            {
                EntryList.Add(new FileTableEntry { DataOffset = 0, DataLength = 0, IsFolder = true, NameOffset = 2 });
                NameList.Add(new NameTableEntry(6, "."));
            }
            foreach (string folder in Directory.GetDirectories(folderName))
            {
                string parentName = new DirectoryInfo(folder).Name;
                string[] files = Directory.GetFiles(folder);
                NameList.Add(new NameTableEntry(nameOffset, parentName));
                EntryList.Add(new FileTableEntry
                {
                    DataOffset = 1,
                    DataLength = (uint)(files.Length + EntryList.Count),
                    IsFolder = true,
                    NameOffset = nameOffset,
                });
                nameOffset += (uint)parentName.Length + 2;

                foreach (string file in files)
                {
                    var fi = new FileInfo(file);
                    string fileName = fi.Name;
                    NameList.Add(new NameTableEntry(nameOffset, parentName));

                    EntryList.Add(new FileTableEntry
                    {
                        DataOffset = (uint)Data.Length,
                        DataLength = (uint)fi.Length,
                        IsFolder = false,
                        NameOffset = nameOffset,
                    });
                    Data = [.. Data, .. File.ReadAllBytes(file)];
                    nameOffset += (uint)fileName.Length + 2;
                }
            }
        }

        int darcFileCount = NameList.Count;
        int NameListOffset = darcFileCount * 0xC;
        int NameListLength = (int)(nameOffset + NameListOffset);
        int DataOffset = NameListLength % 4 == 0 ? NameListLength : NameListLength + (4 - (NameListLength % 4));
        Array.Resize(ref Data, Data.Length % 4 == 0 ? Data.Length : Data.Length + 4 - (Data.Length % 4));
        int FinalSize = DataOffset + Data.Length;
        var darc = new DARC
        {
            Header =
            {
                Signature = "darc",
                Endianness = 0xFEFF,
                HeaderSize = 0x1C,
                Version = 1,
                FileSize = (uint)FinalSize,
                FileTableOffset = 0x1C,
                FileTableLength = (uint)NameListLength,
                FileDataOffset = (uint)DataOffset,
            },
            Entries = [.. EntryList],
            FileNameTable = [.. NameList],
            Data = Data,
        };
        darc.Entries[0].DataLength = (uint)darcFileCount;
        darc.Entries[1].DataLength = (uint)darcFileCount;
        foreach (FileTableEntry f in darc.Entries.Where(x => !x.IsFolder))
            f.DataOffset += darc.Header.FileDataOffset;
        return darc;
    }

    public static bool Darc2files(string path, string folderName)
    {
        try { return Darc2files(File.ReadAllBytes(path), folderName); }
        catch (Exception) { return false; }
    }

    public static bool Darc2files(byte[] darc, string folderName)
    {
        try
        {
            string root = folderName;
            if (Directory.Exists(root))
                Directory.Delete(root, true);
            var DARC = new DARC(darc);
            for (int i = 2; i < DARC.FileNameTable.Length;)
            {
                bool isFolder = DARC.Entries[i].IsFolder;
                if (!isFolder)
                    return false;
                string parentName = DARC.FileNameTable[i].FileName;
                Directory.CreateDirectory(Path.Combine(root, parentName));

                int nextFolder = (int)DARC.Entries[i++].DataLength;
                while (i < nextFolder)
                {
                    string fileName = DARC.FileNameTable[i].FileName;
                    int offset = (int)DARC.Entries[i].DataOffset;
                    int length = (int)DARC.Entries[i].DataLength;
                    byte[] data = DARC.Data.Skip((int)(offset - DARC.Header.FileDataOffset)).Take(length).ToArray();

                    string outPath = Path.Combine(root, parentName, fileName);
                    File.WriteAllBytes(outPath, data);
                    i++;
                }
            }
            return true;
        }
        catch (Exception) { return false; }
    }

    public static bool Files2darc(string folderName, bool delete = false, string originalDARC = null, string outFile = null)
    {
        try
        {
            byte[] darcData;
            DARC orig;
            string root = folderName;
            if (originalDARC != null)
            {
                byte[] darc = File.ReadAllBytes(originalDARC);
                int darcPos = GetDARCposition(darc);
                if (darcPos < 0) return false;
                byte[] origData = darc.Skip(darcPos).ToArray();

                orig = new DARC(origData);
                orig = InsertFiles(orig, folderName);
                byte[] newDARC = SetDARC(orig);
                darcData = darc.Take(darcPos).Concat(newDARC).ToArray();
            }
            else
            {
                orig = GetDARC(folderName);
                darcData = SetDARC(orig);
            }
            outFile ??= originalDARC ?? new DirectoryInfo(folderName).Name.Replace("_d", "") + ".darc";

            if (darcData == null) return false;
            File.WriteAllBytes(outFile, darcData);

            if (Directory.Exists(root) && delete)
                Directory.Delete(root, true);
            return true;
        }
        catch (Exception) { return false; }
    }
    public static int GetDARCposition(byte[] data)
    {
        int pos = 0;
        while (BitConverter.ToUInt32(data, pos) != 0x63726164)
        { pos += 4; if (pos >= data.Length) return -1; }
        return pos;
    }

    public static bool InsertFile(ref DARC orig, int index, string path)
    {
        try { return InsertFile(ref orig, index, File.ReadAllBytes(path)); }
        catch (Exception) { return false; }
    }

    public static bool InsertFile(ref DARC orig, int index, byte[] data)
    {
        if (index < 0) return false;

        try
        {
            uint oldLength = orig.Entries[index].DataLength;
            uint offset = orig.Entries[index].DataOffset - orig.Header.FileDataOffset;
            int diff = (int)(data.Length - oldLength);
            byte[] pre = orig.Data.Take((int)offset).ToArray();
            byte[] post = orig.Data.Skip((int)(offset + oldLength)).ToArray();
            orig.Data = [.. pre, .. data, .. post];
            foreach (var x in orig.Entries.Where(x => x.DataOffset >= offset + oldLength))
                x.DataOffset += (uint)diff;
            orig.Entries[index].DataLength = (uint)data.Length;
            orig.Header.FileSize += (uint)diff;
            return true;
        }
        catch (Exception) { return false; }
    }

    public static DARC InsertFiles(DARC orig, string folderName)
    {
        string[] fileNames = new string[orig.Entries.Length];
        for (int i = 0; i < fileNames.Length; i++)
            fileNames[i] = orig.FileNameTable[i].FileName;

        string[] files = Directory.GetFiles(folderName, "*", SearchOption.AllDirectories);
        foreach (string file in files)
        {
            var fi = new FileInfo(file);
            string FileName = fi.Name;
            int index = Array.IndexOf(fileNames, FileName);
            if (orig.Entries[index].IsFolder)
                throw new Exception(file + " is not a valid file to reinsert!");

            InsertFile(ref orig, index, file);
        }
        Array.Resize(ref orig.Data, orig.Data.Length % 4 == 0 ? orig.Data.Length : orig.Data.Length + 4 - (orig.Data.Length % 4));
        orig.Header.FileSize = (uint)(orig.Data.Length + orig.Header.FileDataOffset);
        return orig;
    }
}