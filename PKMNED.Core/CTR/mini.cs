using System;
using System.IO;
using System.Linq;

namespace PKMNED.Core.CTR;
public static class Mini
{
    public static byte[] AdjustMiniHeader(byte[] data, int headerLength)
    {
        int count = BitConverter.ToUInt16(data, 2);
        int[] start = new int[count];
        for (int i = 0; i < count; i++)
            start[i] = BitConverter.ToInt32(data, 4 + (i * 4));

        int dataStart = start.Min();
        if (headerLength < dataStart)
            throw new Exception("Specified Header length is too small!?");
        byte[] pack = data.Skip(dataStart).ToArray();
        byte[] newData = new byte[headerLength].Concat(pack).ToArray();
        Array.Copy(data, 0, newData, 0, dataStart);

        int diff = headerLength - dataStart;
        for (int i = 0; i < count + 1; i++)
            Array.Copy(BitConverter.GetBytes(BitConverter.ToInt32(data, 4 + (i * 4)) + diff), 0, newData, 4 + (4 * i), 4);

        return newData;
    }

    public static void PackMini(string path, string ident, string fileName, string outExt = null, string outFolder = null, bool delete = true)
    {
        if (outFolder == null)
        {
            delete = false;
            outFolder = path;
        }
        outExt ??= ".bin";
        byte[] data = new byte[4];
        data[0] = (byte)ident[0];
        data[1] = (byte)ident[1];
        string[] files = Directory.GetFiles(path);
        Array.Copy(BitConverter.GetBytes((ushort)files.Length), 0, data, 2, 2);
        int count = files.Length;
        int dataOffset = 4 + 4 + (count * 4);
        using (var dataout = new MemoryStream())
        using (var offsetMap = new MemoryStream())
        using (var bd = new BinaryWriter(dataout))
        using (var bo = new BinaryWriter(offsetMap))
        {
            for (int i = 0; i < count; i++)
            { 
                uint fileOffset = (uint)(dataout.Position + dataOffset);
                bo.Write(fileOffset);
                bd.Write(File.ReadAllBytes(files[i]));
                while (dataout.Length % 4 != 0)
                    bd.Write((byte)0);
                File.Delete(files[i]);
            }
            bo.Write((uint)(dataout.Position + dataOffset));

            using var newPack = File.Create(Path.Combine(outFolder, fileName + outExt));
            using var header = new MemoryStream(data);
            header.WriteTo(newPack);
            offsetMap.WriteTo(newPack);
            dataout.WriteTo(newPack);
        }
        if (delete)
            Directory.Delete(path, true);
    }

    public static byte[] PackMini(byte[][] fileData, string ident)
    {
        byte[] data = new byte[4];
        data[0] = (byte)ident[0];
        data[1] = (byte)ident[1];
        Array.Copy(BitConverter.GetBytes((ushort)fileData.Length), 0, data, 2, 2);
        int count = fileData.Length;
        int dataOffset = 4 + 4 + (count * 4);
        using var dataout = new MemoryStream();
        using var offsetMap = new MemoryStream();
        using var bd = new BinaryWriter(dataout);
        using var bo = new BinaryWriter(offsetMap);
        for (int i = 0; i < count; i++)
        {
            uint fileOffset = (uint)(dataout.Position + dataOffset);
            bo.Write(fileOffset);
            bd.Write(fileData[i]);
            while (dataout.Length % 4 != 0)
                bd.Write((byte)0);
        }
        bo.Write((uint)(dataout.Position + dataOffset));

        using var newPack = new MemoryStream();
        using var header = new MemoryStream(data);
        header.WriteTo(newPack);
        offsetMap.WriteTo(newPack);
        dataout.WriteTo(newPack);
        return newPack.ToArray();
    }

    public static bool PackMini2(string path, string ident, string fileName)
    {
        if (!Directory.Exists(path)) return false;
        try
        {
            string[] filesToPack = Directory.GetFiles(path);
            byte[][] fileData = new byte[filesToPack.Length][];
            for (int i = 0; i < filesToPack.Length; i++) fileData[i] = File.ReadAllBytes(filesToPack[i]);
            byte[] miniBytes = PackMini(fileData, ident);
            File.WriteAllBytes(fileName, miniBytes);
            return true;
        }
        catch { return false; }
    }

    public static void UnpackMini(string path, string ident, string outFolder = null, bool delete = true)
    {
        outFolder ??= Path.GetDirectoryName(path);
        if (!Directory.Exists(outFolder)) Directory.CreateDirectory(outFolder);
        using (var s = new MemoryStream(File.ReadAllBytes(path)))
        using (var br = new BinaryReader(s))
        {
            var fx = new string(br.ReadChars(2));

            if (fx != ident) return;

            ushort count = br.ReadUInt16();
            string namePad = "D" + Math.Ceiling(Math.Log10(count));
            uint[] offsets = new uint[count + 1];
            for (int i = 0; i < count; i++)
                offsets[i] = br.ReadUInt32();

            uint length = br.ReadUInt32();
            offsets[^1] = length;

            for (int i = 0; i < count; i++)
            {
                br.BaseStream.Seek(offsets[i], SeekOrigin.Begin);
                using var dataout = new MemoryStream();
                byte[] data = [];
                s.CopyTo(dataout, (int)offsets[i]);
                int len = (int)offsets[i + 1] - (int)offsets[i];

                if (len != 0)
                {
                    data = dataout.ToArray();
                    Array.Resize(ref data, len);
                }
                string newFile = Path.Combine(outFolder, i.ToString(namePad) + ".bin");
                File.WriteAllBytes(newFile, data);
            }
        }
        if (delete)
            File.Delete(path);
    }

    public static byte[][] UnpackMini(byte[] fileData, string identifier)
    {
        if (fileData == null || fileData.Length < 4)
            return null;

        if (identifier[0] != fileData[0] || identifier[1] != fileData[1])
            return null;

        int count = BitConverter.ToUInt16(fileData, 2); int ctr = 4;
        int start = BitConverter.ToInt32(fileData, ctr); ctr += 4;
        byte[][] returnData = new byte[count][];
        for (int i = 0; i < count; i++)
        {
            int end = BitConverter.ToInt32(fileData, ctr); ctr += 4;
            int len = end - start;
            byte[] data = new byte[len];
            Buffer.BlockCopy(fileData, start, data, 0, len);
            returnData[i] = data;
            start = end;
        }
        return returnData;
    }

    public static string GetIsMini(string path)
    {
        byte[] data = File.ReadAllBytes(path);
        var fi = new FileInfo(path);
        try
        {
            string fx = new(new[] { (char)data[0], (char)data[1] });
            ushort count = BitConverter.ToUInt16(data, 2);

            uint[] offsets = new uint[count + 1];
            uint length = 1338;
            for (int i = 0; i < count; i++)
            {
                offsets[i] = BitConverter.ToUInt32(data, 4 + (i * 4));
                length = BitConverter.ToUInt32(data, 8 + (i * 4));
            }

            offsets[^1] = length;
            return fi.Length == length ? fx : null;
        }
        catch { return null; }
    }
}