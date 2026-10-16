using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace PKMNED.Core.CTR;

public class ExeFS
{
    public byte[] Data;
    public readonly byte[] SuperBlockHash;

    public static bool PackExeFS(string[] files, string outFile)
    {
        if (files.Length > 10) { Console.WriteLine("Cannot package more than 10 files to exefs."); return false; }

        try
        {
            byte[] headerData = new byte[0x200];
            uint offset = 0;
            for (int i = 0; i < files.Length; i++)
            {
                string fileName = Path.GetFileNameWithoutExtension(files[i]); byte[] nameData = Encoding.ASCII.GetBytes(fileName); Array.Resize(ref nameData, 0x8); Array.Copy(nameData, 0, headerData, i * 0x10, 0x8); var fi = new FileInfo(files[i]); uint size = (uint)fi.Length; Array.Copy(BitConverter.GetBytes(offset), 0, headerData, 0x8 + (i * 0x10), 0x4); Array.Copy(BitConverter.GetBytes(size), 0, headerData, 0xC + (i * 0x10), 0x4); offset += 0x200 - (size % 0x200) + size; byte[] hash = SHA256.HashData(File.ReadAllBytes(files[i])); Array.Copy(hash, 0, headerData, 0x200 - (0x20 * (i + 1)), 0x20);
            }
            using var newFile = new MemoryStream();
            newFile.Write(headerData);
            foreach (string s in files)
            {
                using (var loadFile = new MemoryStream(File.ReadAllBytes(s)))
                    loadFile.CopyTo(newFile);
                var tail = new byte[0x200 - (newFile.Length % 0x200)];
                newFile.Write(tail);
            }

            File.WriteAllBytes(outFile, newFile.ToArray());
            return true;
        }
        catch { return false; }
    }
    public void SetData(string[] files)
    {
        byte[] headerData = new byte[0x200];
        uint offset = 0;
        for (int i = 0; i < files.Length; i++)
        {
            string fileName = Path.GetFileNameWithoutExtension(files[i]); byte[] nameData = Encoding.ASCII.GetBytes(fileName); Array.Resize(ref nameData, 0x8); Array.Copy(nameData, 0, headerData, i * 0x10, 0x8); var fi = new FileInfo(files[i]); uint size = (uint)fi.Length; Array.Copy(BitConverter.GetBytes(offset), 0, headerData, 0x8 + (i * 0x10), 0x4); Array.Copy(BitConverter.GetBytes(size), 0, headerData, 0xC + (i * 0x10), 0x4); offset += 0x200 - (size % 0x200) + size; byte[] hash = SHA256.HashData(File.ReadAllBytes(files[i])); Array.Copy(hash, 0, headerData, 0x200 - (0x20 * (i + 1)), 0x20);
        }
        using var newFile = new MemoryStream(); newFile.Write(headerData);
        foreach (string s in files)
        {
            using var loadFile = File.OpenRead(s); loadFile.CopyTo(newFile); var tail = new byte[0x200 - (newFile.Length % 0x200)]; newFile.Write(tail);
        }

        Data = newFile.ToArray();
    }
    

    

    public static bool UnpackExeFS(string inFile, string outPath)
    {
        try
        {
            byte[] data = File.ReadAllBytes(inFile);
            if (!Directory.Exists(outPath)) Directory.CreateDirectory(outPath);
            for (int i = 0; i < 10; i++)
            {
                string fileName = Encoding.ASCII.GetString(data.Skip(0x10 * i).Take(0x8).ToArray()).TrimEnd((char)0);
                if (fileName.Length > 0)
                {
                    File.WriteAllBytes(outPath + Path.DirectorySeparatorChar + fileName + ".bin", data.Skip(0x200 + BitConverter.ToInt32(data, 0x8 + (0x10 * i))).Take(BitConverter.ToInt32(data, 0xC + (0x10 * i))).ToArray());
                }
            }
            return true;
        }
        catch { return false; }
    }


    public ExeFS(string path)
    {
        if (Directory.Exists(path))
        {
            var files = new DirectoryInfo(path).GetFiles().Select(f => f.FullName).ToArray();
            SetData(files);
        }
        else if (File.Exists(path))
        {
            Data = File.ReadAllBytes(path);
        }
        else
        {
            throw new FileNotFoundException("File not found.", path);
        }
        SuperBlockHash = SHA256.HashData(Data.AsSpan(0, 200));
    }
}