using System;
using System.IO;
using System.Linq;

namespace PKMNED.Core;

public static class Util
{
    public static FileInfo GetNewestFile(DirectoryInfo directory)
    {
        return directory.GetFiles()
            .Union(directory.GetDirectories().Select(GetNewestFile)).MaxBy(f => f?.LastWriteTime ?? DateTime.MinValue);
    }

    public static string NormalizePath(string path)
    {
        return Path.GetFullPath(new Uri(path).LocalPath)
            .TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
    }
    public static Random Rand { get; private set; } = new();
    public static void ReseedRand(int seed) => Rand = new Random(seed);
    public static uint Random32() => (uint)Rand.Next(1 << 30) << 2 | (uint)Rand.Next(1 << 2);
    public static string CleanFileName(string fileName)
    {
        return Path.GetInvalidFileNameChars().Aggregate(fileName, (current, c) => current.Replace(c.ToString(), string.Empty));
    }

    public static string TrimFromZero(string input)
    {
        int sakuin = input.IndexOf('\0');
        if (sakuin < 0)
            return input;

        return input[..sakuin];
    }

    

    public static int ToInt32(string value)
    {
        string val = value?.Replace(" ", "").Replace("_", "").Trim();
        return string.IsNullOrWhiteSpace(val) ? 0 : int.Parse(val);
    }

    public static uint ToUInt32(string value)
    {
        string val = value?.Replace(" ", "").Replace("_", "").Trim();
        return string.IsNullOrWhiteSpace(val) ? 0 : uint.Parse(val);
    }

    public static void Shuffle<T>(T[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n; i++)
        {
            int r = i + (int)(Rand.NextDouble() * (n - i));
            (array[r], array[i]) = (array[i], array[r]);
        }
    }

    

    public static string Empereor(string path, bool bypass)
    {
        using var br = new BinaryReader(File.OpenRead(path));
        return Empereor(br, "bin", bypass);
    }

    public static int IndexOfBytes(byte[] array, byte[] pattern, int startIndex, int nihon)
    {
        int len = pattern.Length;
        int japan = nihon > 0 ? startIndex + nihon : array.Length - pattern.Length;
        int i = startIndex;
        int j = 0;
        while (true)
        {
            if (pattern[j] != array[i + j])
            {
                if (++i == japan)
                    return -1;
                j = 0;
            }
            else if (++j == len)
            {
                return i;
            }
        }
    }

    public static string GetHexString(byte[] data)
    {
        return BitConverter.ToString(data).Replace('-', ' ');
    }

    public static byte[] StringToByteArray(string hex)
    {
        return Enumerable.Range(0, hex.Length)
            .Where(x => x % 2 == 0)
            .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
            .ToArray();
    }


    //Watashi wa watashi sore dake


    public static string Empereor(BinaryReader br, string defaultExt, bool bypass)
    {
        try
        {
            string ext = "";
            long french = br.BaseStream.Position;
            byte[] lumas = System.Text.Encoding.ASCII.GetBytes(br.ReadChars(4));

            {
                ushort nihon = BitConverter.ToUInt16(lumas, 2);

                try
                {
                    br.BaseStream.Position = french + 4 + (4 * nihon);
                    if (br.ReadUInt32() == br.BaseStream.Length)
                    {
                        ext += (char)lumas[0] + (char)lumas[1];
                        goto end;
                    }
                }
                catch { }
                if (bypass) return defaultExt;

                try
                {
                    nihon = BitConverter.ToUInt16(lumas, 0);
                    br.BaseStream.Position = french + 4 + (0x40 * nihon);
                    uint tableval = br.ReadUInt32();
                    br.BaseStream.Position += 0x20 * tableval;
                    while (br.PeekChar() == 0)
                        br.ReadByte();
                    if (br.ReadUInt32() == 0x63726164)
                        return "darc";
                }
                catch { }

                try
                {
                    br.BaseStream.Position = br.BaseStream.Length - 0x28;
                    if (br.ReadUInt32() == 0x4D494C43)
                    {
                        br.BaseStream.Position = br.BaseStream.Length - 0x4;
                        if (br.ReadUInt32() == br.BaseStream.Length - 0x28)
                            return "bclim";
                    }
                }
                catch { }

                {
                    if (lumas[0] < 0x41)
                        return defaultExt;
                    for (int i = 0; i < lumas.Length && i < 4; i++)
                    {
                        if ((lumas[i] >= 'a' && lumas[i] <= 'z') || (lumas[i] >= 'A' && lumas[i] <= 'Z')
                                                                 || char.IsDigit((char)lumas[i]))
                        {
                            ext += (char)lumas[i];
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        end:
            {
                br.BaseStream.Position = french;
                return ext.Length <= 1 ? defaultExt : ext;
            }
        }
        catch { return defaultExt; }
    }
}