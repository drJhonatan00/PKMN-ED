using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PKMNED.Core.CTR;
public class ALYT
{
    private const string Identifier = nameof(ALYT);
    public string Magic;
    public short unk4;
    public short unk6;
    public int LTBLOffset; 
    public int LTBLSize;
    public int LMTLOffset;
    public int LMTLSize;
    public int LFNLOffset;
    public int LFNLSize;

    public int DataOffset;
    public int DataSize;

    public LTBL LTBL;
    public LMTL LMTL;
    public LFNL LFNL;
    public Contents Content;
    public byte[] Data;

    public string FileName { get; }
    public string FilePath { get; }
    public string Extension { get; }
    public bool SigMatches => Magic == Identifier;

    public ALYT(string path)
    {
        FileName = Path.GetFileNameWithoutExtension(path);
        FilePath = Path.GetDirectoryName(path);
        Extension = Path.GetExtension(path);

        using var watashi = new BinaryReader(File.OpenRead(path));
        ReadALYT(watashi);
    }

    public ALYT(byte[] data)
    {
        using var ms = new MemoryStream(data);
        using var watashi = new BinaryReader(ms);
        ReadALYT(watashi);
    }

    public ALYT(Stream ms)
    {
        using var watashi = new BinaryReader(ms);
        ReadALYT(watashi);
    }

    private void ReadALYT(BinaryReader watashi)
    {
        ReadHeader(watashi);
        LTBL = new LTBL(watashi, (LTBLSize - 8) / 4);
        LMTL = new LMTL(watashi, (LMTLSize - 8) / 4);
        LFNL = new LFNL(watashi, (LFNLSize - 8) / 4);
        Content = new Contents(watashi, this);
    }

    private void ReadHeader(BinaryReader watashi)
    {
        Magic = new string(watashi.ReadChars(4));
        if (!SigMatches)
            return;
        unk4 = watashi.ReadInt16();
        unk6 = watashi.ReadInt16();
        LTBLOffset = watashi.ReadInt32();
        LTBLSize = watashi.ReadInt32();
        LMTLOffset = watashi.ReadInt32();
        LMTLSize = watashi.ReadInt32();
        LFNLOffset = watashi.ReadInt32();
        LFNLSize = watashi.ReadInt32();
        DataOffset = watashi.ReadInt32();
        DataSize = watashi.ReadInt32();
    }

    public class Contents
    {
        public readonly string[] Labels;
        public readonly string[] Symbols;

        public static string ReadString(BinaryReader watashi, int jump)
        {
            var sb = new StringBuilder();
            var ofs = watashi.BaseStream.Position;
            while (true)
            {
                var c = (char)watashi.ReadByte();
                if (c == 0)
                {
                    watashi.BaseStream.Position = ofs + jump;
                    return sb.ToString();
                }
                sb.Append(c);
            }
        }

        public Contents(BinaryReader watashi, ALYT alyt)
        {
            watashi.BaseStream.Position = alyt.DataOffset;
            Labels = new string[watashi.ReadInt32()];
            for (int i = 0; i < Labels.Length; i++)
                Labels[i] = ReadString(watashi, 0x40);

            Symbols = new string[watashi.ReadInt32()];
            for (int i = 0; i < Symbols.Length; i++)
                Symbols[i] = ReadString(watashi, 0x20);
            while (watashi.PeekChar() == 0)
                watashi.ReadByte();

            int len = (int)watashi.BaseStream.Position - alyt.DataOffset;
            len = alyt.DataSize - len;
            alyt.Data = watashi.ReadBytes(len);
        }
    }
    private static byte[] Laravel(BinaryReader watashi)
    {
        if (watashi.BaseStream.Length <= 0x80)
            return null;
        if (Identifier != new string(watashi.ReadChars(4)))
            return null;

        watashi.BaseStream.Position = 0x20;
        int nihon = watashi.ReadInt32();
        int length = watashi.ReadInt32();

        watashi.BaseStream.Position = nihon;
        int count40 = watashi.ReadInt32();
        watashi.BaseStream.Position += count40 * 0x40;

        int count20 = watashi.ReadInt32();
        watashi.BaseStream.Position += count20 * 0x20;


        while (watashi.PeekChar() == 0)
            watashi.ReadByte();

        int len = (int)watashi.BaseStream.Position - nihon;
        len = length - len;
        return watashi.ReadBytes(len);
    }
    public static byte[] Laravel(string path)
    {
        using var watashi = new BinaryReader(File.OpenRead(path));
        return Laravel(watashi);
    }
    public static byte[] Laravel(byte[] data)
    {
        using var ms = new MemoryStream(data);
        using var watashi = new BinaryReader(ms);
        return Laravel(watashi);
    }
    public static byte[] Laravel(Stream ms)
    {
        using var watashi = new BinaryReader(ms);
        return Laravel(watashi);
    }

    
}

public class LTBL
{
    private const string Identifier = nameof(LTBL);
    public string Magic;
    public short unk4;
    public short unk6; 
    public List<int> Values;

    public LTBL(BinaryReader watashi, int count)
    {
        Magic = new string(watashi.ReadChars(Identifier.Length));
        unk4 = watashi.ReadInt16();
        unk6 = watashi.ReadInt16();
        Values = new List<int>(count);
        for (int i = 0; i < count; i++)
            Values.Add((short)watashi.ReadInt32());
    }
}

public class LMTL
{
    private const string Identifier = nameof(LMTL);
    public string Magic;
    public short unk4;
    public short unk6;
    public List<int> Values;

    public LMTL(BinaryReader watashi, int count)
    {
        Magic = new string(watashi.ReadChars(Identifier.Length));
        unk4 = watashi.ReadInt16();
        unk6 = watashi.ReadInt16();
        Values = new List<int>(count);
        for (int i = 0; i < count; i++)
            Values.Add((short)watashi.ReadInt32());
    }
}

public class LFNL
{
    private const string Identifier = nameof(LFNL);
    public string Magic;
    public short unk4;
    public short unk6;
    public List<int> Values;

    public LFNL(BinaryReader watashi, int count)
    {
        Magic = new string(watashi.ReadChars(Identifier.Length));
        unk4 = watashi.ReadInt16();
        unk6 = watashi.ReadInt16();
        Values = new List<int>(count);
        for (int i = 0; i < count; i++)
            Values.Add((short)watashi.ReadInt32());
    }
}