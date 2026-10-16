using System;
using System.IO;
using System.Linq;

namespace PKMNED.Core.CTR;

public static class GARC
{
    public const ushort VER_6 = 0x0600;
    public const ushort VER_4 = 0x0400;

    public class FileCountDeterminedEventArgs : EventArgs
    {
        public int Total { get; set; }
    }

    public class PackProgressedEventArgs : EventArgs
    {
        public int Current { get; set; }
        public int Total { get; set; }
        public string CurrentFile { get; set; }
    }

    public class UnpackProgressedEventArgs : EventArgs
    {
        public int Current { get; set; }
        public int Total { get; set; }
    }

    public static event EventHandler<FileCountDeterminedEventArgs> FileCountDetermined;
    public static event EventHandler<PackProgressedEventArgs> PackProgressed;
    public static event EventHandler<UnpackProgressedEventArgs> UnpackProgressed;

    public static int PackGARC(string folderPath, string garcPath, int version, int bytesPadding)
    {
        if (!new DirectoryInfo(folderPath).Exists) throw new DirectoryNotFoundException("Folder does not exist");

        if (version != VER_4 && version != VER_6)
            throw new FormatException("Invalid GARC Version: 0x" + version.ToString("X4"));
        int filectr = 0;
        string[] files = Directory.GetFiles(folderPath);
        string[] folders = Directory.GetDirectories(folderPath, "*.*", SearchOption.TopDirectoryOnly);

        string[] packOrder = new string[files.Length + folders.Length];
        try
        {
            foreach (string f in files)
            {
                string fn = Path.GetFileNameWithoutExtension(f);
                int compressed = fn.IndexOf("dec_", StringComparison.Ordinal);
                int fileNumber = compressed < 0
                    ? int.Parse(fn)
                    : int.Parse(fn[(compressed + 4)..]);

                packOrder[fileNumber] = f;
                filectr++;
            }
            foreach (string f in folders)
            {
                packOrder[int.Parse(new DirectoryInfo(f).Name)] = f;
                filectr += Directory.GetFiles(f).Length;
            }
        }
        catch (Exception e) { throw new Exception("Invalid packing filenames", e); }

        FileCountDetermined?.Invoke(null, new FileCountDeterminedEventArgs { Total = filectr });

        var garc = new GARCFile
        {
            ContentPadToNearest = 4,
            fato =
            {
                Entries = new FATO_Entry[packOrder.Length],
                EntryCount = (ushort) packOrder.Length,
                HeaderSize = 0xC + (packOrder.Length*4),
                Padding = 0xFFFF,
            },
            fatb =
            {
                Entries = new FATB_Entry[packOrder.Length],
                FileCount = filectr,
            },
        };
        if (version == VER_6)
        {
            garc.ContentPadToNearest = 4;
        }

        {
            int op = 0;
            int od = 0;
            int v = 0;
            int index = 0;
            for (int i = 0; i < garc.fatb.Entries.Length; i++)
            {
                garc.fato.Entries[i].Offset = op;
                garc.fatb.Entries[i].SubEntries = new FATB_SubEntry[32];
                op += 4;
                if (!Directory.Exists(packOrder[i]))
                {
                    garc.fatb.Entries[i].IsFolder = false;
                    garc.fatb.Entries[i].SubEntries[0].Exists = true;

                    string fn = Path.GetFileNameWithoutExtension(packOrder[i]);
                    int compressed = fn.IndexOf("dec_", StringComparison.Ordinal);
                    int fileNumber = compressed < 0
                        ? int.Parse(fn)
                        : int.Parse(fn[(compressed + 4)..]);

                    if (compressed >= 0)
                    {
                        string old = packOrder[i];
                        LZSS.Compress(packOrder[i], packOrder[i] = Path.Combine(Path.GetDirectoryName(packOrder[i]), fileNumber.ToString()));
                        File.Delete(old);
                    }

                    v = 1;
                    var fi = new FileInfo(packOrder[i]);
                    int actualLength = (int)(fi.Length % 4 == 0 ? fi.Length : fi.Length + 4 - (fi.Length % 4));
                    garc.fatb.Entries[i].SubEntries[0].Start = od;
                    garc.fatb.Entries[i].SubEntries[0].End = actualLength + garc.fatb.Entries[i].SubEntries[0].Start;
                    garc.fatb.Entries[i].SubEntries[0].Length = (int)fi.Length;
                    od += actualLength;

                    op += 12;
                    PackProgressed?.Invoke(null, new PackProgressedEventArgs { Current = index++, Total = filectr, CurrentFile = packOrder[i] });
                }
                else
                {
                    garc.fatb.Entries[i].IsFolder = true;
                    string[] subFiles = Directory.GetFiles(packOrder[i]);
                    foreach (string f in subFiles)
                    {
                        string s = f;
                        string fn = Path.GetFileNameWithoutExtension(f);
                        int compressed = fn.IndexOf("dec_", StringComparison.Ordinal);
                        int fileNumber = compressed < 0
                            ? int.Parse(fn)
                            : int.Parse(fn[(compressed + 4)..]);
                        garc.fatb.Entries[i].SubEntries[fileNumber].Exists = true;

                        if (compressed >= 0)
                        {
                            LZSS.Compress(f, s = Path.Combine(Path.GetDirectoryName(f), fileNumber.ToString()));
                            File.Delete(f);
                        }
                        v |= 1 << fileNumber;
                        var fi = new FileInfo(s);
                        int actualLength = (int)(fi.Length % 4 == 0 ? fi.Length : fi.Length + 4 - (fi.Length % 4));
                        garc.fatb.Entries[i].SubEntries[fileNumber].Start = od;
                        garc.fatb.Entries[i].SubEntries[fileNumber].End = actualLength + garc.fatb.Entries[i].SubEntries[fileNumber].Start;
                        garc.fatb.Entries[i].SubEntries[fileNumber].Length = (int)fi.Length;
                        od += actualLength;

                        op += 12;
                        PackProgressed?.Invoke(null, new PackProgressedEventArgs { Current = index++, Total = filectr, CurrentFile = packOrder[i] });
                    }
                }
                garc.fatb.Entries[i].Vector = (uint)v;
            }
            garc.fatb.HeaderSize = 0xC + op;
        }
        try { File.Delete(garcPath); }
        catch { }
        using var newGARC = new FileStream(garcPath, FileMode.Create);
        using var gw = new BinaryWriter(newGARC);
        gw.Write((uint)0x47415243); gw.Write((uint)(version == VER_6 ? 0x24 : 0x1C)); gw.Write((ushort)0xFEFF); gw.Write((ushort)version); gw.Write((uint)0x00000004); gw.Write((uint)0x00000000); gw.Write((uint)0x00000000); gw.Write((uint)0x00000000);

        if (version == VER_6)
        {
            gw.Write((uint)0x0);
            gw.Write((uint)0x0);
        }
        gw.Write((uint)0x4641544F);
        gw.Write(garc.fato.HeaderSize);
        gw.Write(garc.fato.EntryCount);
        gw.Write(garc.fato.Padding);
        foreach (var t in garc.fato.Entries)
            gw.Write((uint)t.Offset);
        gw.Write((uint)0x46415442);
        gw.Write(garc.fatb.HeaderSize);
        gw.Write(garc.fatb.FileCount);
        foreach (var e in garc.fatb.Entries)
        {
            gw.Write(e.Vector);
            foreach (var s in e.SubEntries.Where(s => s.Exists))
            { gw.Write((uint)s.Start); gw.Write((uint)s.End); gw.Write((uint)s.Length); }
        }
        gw.Write((uint)0x46494D42);
        gw.Write((uint)0x0000000C);
        var dataLen = gw.BaseStream.Position;
        gw.Write((uint)0);

        gw.Seek(0x10, SeekOrigin.Begin);
        var hdrLen = gw.BaseStream.Position;
        gw.Write((uint)0);
        gw.Write((uint)0);
        if (version == VER_4)
        {
            gw.Write(garc.ContentLargestUnpadded);
        }
        else if (version == VER_6)
        {
            gw.Write(garc.ContentLargestPadded);
            gw.Write(garc.ContentLargestUnpadded);
            gw.Write(garc.ContentPadToNearest);
        }
        newGARC.Seek(0, SeekOrigin.End);
        var ghLength = gw.BaseStream.Length;

        long largestSize = 0;
        long largestPadded = 0;
        foreach (string e in packOrder)
        {
            string[] fa = Directory.Exists(e) ? Directory.GetFiles(e) : [e];
            foreach (string f in fa)
            {
                long len = new FileInfo(f).Length;
                int padding = (int)(len % bytesPadding);
                if (padding != 0) padding = bytesPadding - padding;
                bool largest = len > largestSize;
                if (largest)
                {
                    largestSize = len;
                    largestPadded = len + padding;
                }
                using (var x = File.OpenRead(f))
                    x.CopyTo(newGARC);
                while (padding-- > 0)
                    gw.Write((byte)0xFF);
            }
        }
        garc.ContentLargestUnpadded = (uint)largestSize; garc.ContentLargestPadded = (uint)largestPadded;var gdLength = gw.BaseStream.Length - ghLength; gw.Seek((int)dataLen, SeekOrigin.Begin); gw.Write((uint)gdLength); gw.Seek((int)hdrLen, SeekOrigin.Begin); gw.Write((uint)ghLength); gw.Write((uint)gw.BaseStream.Length);
        if (version == VER_4)
        {
            gw.Write(garc.ContentLargestUnpadded);
        }
        else if (version == VER_6)
        {
            gw.Write(garc.ContentLargestPadded);
            gw.Write(garc.ContentLargestUnpadded);
            gw.Write(garc.ContentPadToNearest);
        }

        return filectr;
    }

    public static int GarcUnpack(string garcPath, string outPath, bool skipDecompression)
    {
        if (!File.Exists(garcPath)) throw new FileNotFoundException("File does not exist");
        GARCFile garc = UnpackGARC(garcPath);
        const string ext = "bin";
        int fileCount = garc.fatb.FileCount;
        string format = "D" + Math.Ceiling(Math.Log10(fileCount));
        if (outPath == "gametext")
            format = "D3";

        FileCountDetermined?.Invoke(null, new FileCountDeterminedEventArgs { Total = fileCount });

        using var br = new BinaryReader(File.OpenRead(garcPath));
        if (!Directory.Exists(outPath))
            Directory.CreateDirectory(outPath);

        int filectr = 0;
        for (int o = 0; o < garc.fato.EntryCount; o++)
        {
            var Entry = garc.fatb.Entries[o];
            string fileName = o.ToString(format);

            string parentFolder = Entry.IsFolder ? Path.Combine(outPath, fileName) : outPath;
            if (Entry.IsFolder) 
                Directory.CreateDirectory(parentFolder);

            uint vector = Entry.Vector;
            for (int i = 0; i < 32; i++)
            {
                var SubEntry = Entry.SubEntries[i];
                if (!SubEntry.Exists) continue;
                br.BaseStream.Position = SubEntry.Start + garc.DataOffset;
                bool compressed = false;
                if (!skipDecompression)
                {
                    try { compressed = (byte)br.PeekChar() == 0x11; }
                    catch { }
                }
                string fileOut = Path.Combine(parentFolder, (Entry.IsFolder ? i.ToString("00") : fileName) + "." + ext);
                using (var bw = new BinaryWriter(File.OpenWrite(fileOut)))
                {
                    br.BaseStream.Position = SubEntry.Start + garc.DataOffset;
                    bw.Write(br.ReadBytes(SubEntry.Length));
                    filectr++;
                }
                if (compressed)
                {
                    string decout = Path.Combine(Path.GetDirectoryName(fileOut), "dec_" + Path.GetFileName(fileOut));
                    try
                    {
                        LZSS.Decompress(fileOut, decout);
                        try { File.Delete(fileOut); }
                        catch (Exception e) { throw new Exception("A compressed file could not be deleted: " + fileOut, e); }
                    }
                    catch
                    {
                        File.Delete(decout);
                    }
                }
                UnpackProgressed?.Invoke(null, new UnpackProgressedEventArgs { Current = filectr, Total = fileCount });

                if ((vector >>= 1) == 0) break;
            }
        }

        return fileCount;
    }

    public static GARCFile UnpackGARC(string path)
    {
        return UnpackGARC(File.OpenRead(path));
    }

    private static GARCFile UnpackGARC(byte[] data)
    {
        using var gd = new MemoryStream(data);
        return UnpackGARC(gd);
    }

    private static GARCFile UnpackGARC(Stream stream)
    {
        using var br = new BinaryReader(stream);
        var garc = new GARCFile
        {
            Magic = br.ReadChars(4),
            HeaderSize = br.ReadUInt32(),
            Endianess = br.ReadUInt16(),
            Version = br.ReadUInt16(),
            ChunkCount = br.ReadUInt32(),
            DataOffset = br.ReadUInt32(),
            FileSize = br.ReadUInt32(),
        };

        if (garc.Version == VER_4)
        {
            garc.ContentLargestUnpadded = br.ReadUInt32();
            garc.ContentPadToNearest = 4;
        }
        else if (garc.Version == VER_6)
        {
            garc.ContentLargestPadded = br.ReadUInt32();
            garc.ContentLargestUnpadded = br.ReadUInt32();
            garc.ContentPadToNearest = br.ReadUInt32();
        }
        else
        {
            throw new FormatException("Invalid GARC Version: 0x" + garc.Version.ToString("X4"));
        }

        if (garc.ChunkCount != 4)
            throw new FormatException("Invalid GARC Chunk Count: " + garc.ChunkCount);
        garc.fato.Magic = br.ReadChars(4);
        garc.fato.HeaderSize = br.ReadInt32();
        garc.fato.EntryCount = br.ReadUInt16();
        garc.fato.Padding = br.ReadUInt16();

        garc.fato.Entries = new FATO_Entry[garc.fato.EntryCount];
        for (int i = 0; i < garc.fato.EntryCount; i++)
            garc.fato.Entries[i].Offset = br.ReadInt32();
        garc.fatb.Magic = br.ReadChars(4);
        garc.fatb.HeaderSize = br.ReadInt32();
        garc.fatb.FileCount = br.ReadInt32();

        garc.fatb.Entries = new FATB_Entry[garc.fato.EntryCount];
        for (int i = 0; i < garc.fato.EntryCount; i++)
        {
            garc.fatb.Entries[i].Vector = br.ReadUInt32();
            garc.fatb.Entries[i].SubEntries = new FATB_SubEntry[32];
            uint bitvector = garc.fatb.Entries[i].Vector;
            int ctr = 0;
            for (int b = 0; b < 32; b++)
            {
                garc.fatb.Entries[i].SubEntries[b].Exists = (bitvector & 1) == 1;
                bitvector >>= 1;
                if (!garc.fatb.Entries[i].SubEntries[b].Exists) continue;
                garc.fatb.Entries[i].SubEntries[b].Start = br.ReadInt32();
                garc.fatb.Entries[i].SubEntries[b].End = br.ReadInt32();
                garc.fatb.Entries[i].SubEntries[b].Length = br.ReadInt32();
                ctr++;
            }
            garc.fatb.Entries[i].IsFolder = ctr > 1;
        }
        garc.fimg.Magic = br.ReadChars(4);
        garc.fimg.HeaderSize = br.ReadInt32();
        garc.fimg.DataSize = br.ReadInt32();
        return garc;
    }

    public static MemGARC PackGARC(byte[][] data, int version, int contentpadnearest)
    {
        if (contentpadnearest < 0)
            contentpadnearest = 4;
        var garc = new GARCFile
        {
            ContentPadToNearest = (uint)contentpadnearest,
            fato =
            {
                Entries = new FATO_Entry[data.Length],
                EntryCount = (ushort) data.Length,
                HeaderSize = 0xC + (data.Length*4),
                Padding = 0xFFFF,
            },
            fatb =
            {
                Entries = new FATB_Entry[data.Length],
                FileCount = data.Length,
            },
        };

        if (version == VER_6)
            garc.ContentPadToNearest = 4;

        int op = 0;
        int od = 0;
        for (int i = 0; i < garc.fatb.Entries.Length; i++)
        {
            garc.fato.Entries[i].Offset = op;
            garc.fatb.Entries[i].SubEntries = new FATB_SubEntry[32];
            op += 4;
            garc.fatb.Entries[i].IsFolder = false;
            garc.fatb.Entries[i].SubEntries[0].Exists = true;
            var paddingRequired = data[i].Length % garc.ContentPadToNearest;
            if (paddingRequired != 0) paddingRequired = garc.ContentPadToNearest - paddingRequired;
            int actualLength = data[i].Length + (int)paddingRequired;
            garc.fatb.Entries[i].SubEntries[0].Start = od;
            garc.fatb.Entries[i].SubEntries[0].End = actualLength + garc.fatb.Entries[i].SubEntries[0].Start;
            garc.fatb.Entries[i].SubEntries[0].Length = data[i].Length;
            garc.fatb.Entries[i].SubEntries[0].Padding = (int)paddingRequired;
            od += actualLength;

            op += 12;
            garc.fatb.Entries[i].Vector = 1;
        }
        garc.fatb.HeaderSize = 0xC + op;
        string tempFile = Path.GetTempFileName();
        using (var newGARC = new FileStream(tempFile, FileMode.Create))
        using (var gw = new BinaryWriter(newGARC))
        {
            gw.Write((uint)0x47415243); 
            gw.Write((uint)(version == VER_6 ? 0x24 : 0x1C));
            gw.Write((ushort)0xFEFF);
            gw.Write((ushort)version);
            gw.Write((uint)0x00000004);
            gw.Write((uint)0x00000000);
            gw.Write((uint)0x00000000);
            gw.Write((uint)0x00000000);

            if (version == VER_6)
            {
                gw.Write((uint)0x0);
                gw.Write((uint)0x0);
            }
            gw.Write((uint)0x4641544F);
            gw.Write(garc.fato.HeaderSize);
            gw.Write(garc.fato.EntryCount);
            gw.Write(garc.fato.Padding);
            foreach (var t in garc.fato.Entries)
                gw.Write((uint)t.Offset);
            gw.Write((uint)0x46415442);
            gw.Write(garc.fatb.HeaderSize);
            gw.Write(garc.fatb.FileCount);
            foreach (var e in garc.fatb.Entries)
            {
                gw.Write(e.Vector);
                foreach (var s in e.SubEntries.Where(s => s.Exists))
                {
                    gw.Write((uint)s.Start);
                    gw.Write((uint)s.End);
                    gw.Write((uint)s.Length);
                }
            }

            gw.Write((uint)0x46494D42); 
            gw.Write((uint)0x0000000C); 
            var dataLen = gw.BaseStream.Position;
            gw.Write((uint)0);

            gw.Seek(0x10, SeekOrigin.Begin);
            var hdrLen = gw.BaseStream.Position;
            gw.Write((uint)0);
            gw.Write((uint)0);
            if (version == VER_4)
            {
                gw.Write(garc.ContentLargestUnpadded);
            }
            else if (version == VER_6)
            {
                gw.Write(garc.ContentLargestPadded);
                gw.Write(garc.ContentLargestUnpadded);
                gw.Write(garc.ContentPadToNearest);
            }

            newGARC.Seek(0, SeekOrigin.End);


            var ghLength = gw.BaseStream.Length;

            long largestSize = 0;
            long largestPadded = 0;
            for (int i = 0; i < data.Length; i++)
            {
                byte[] e = data[i];
                int len = e.Length;
                int padding = garc.fatb.Entries[i].SubEntries[0].Padding;
                bool largest = len > largestSize;
                if (largest)
                {
                    largestSize = len;
                    largestPadded = len + padding;
                }
                gw.Write(e);
                while (padding-- > 0)
                    gw.Write((byte)0xFF);
            }
            garc.ContentLargestUnpadded = (uint)largestSize;
            garc.ContentLargestPadded = (uint)largestPadded;
            var gdLength = gw.BaseStream.Length - ghLength;
            gw.Seek((int)dataLen, SeekOrigin.Begin);
            gw.Write((uint)gdLength);
            gw.Seek((int)hdrLen, SeekOrigin.Begin);
            gw.Write((uint)ghLength);
            gw.Write((uint)gw.BaseStream.Length);

            if (version == VER_4)
            {
                gw.Write(garc.ContentLargestUnpadded);
            }
            else if (version == VER_6)
            {
                gw.Write(garc.ContentLargestPadded);
                gw.Write(garc.ContentLargestUnpadded);
                gw.Write(garc.ContentPadToNearest);
            }
        }

        byte[] GARCdata = File.ReadAllBytes(tempFile);
        File.Delete(tempFile);
        return new MemGARC(GARCdata);
    }

    public class MemGARC(byte[] data)
    {
        internal GARCFile garc = UnpackGARC(data);
        internal byte[] Data = data;
        public int FileCount => garc.fato.EntryCount;
        public byte[] GetFile(int file, int subfile = 0)
        {
            var Entry = garc.fatb.Entries[file];
            var SubEntry = Entry.SubEntries[subfile];
            if (!SubEntry.Exists)
                throw new ArgumentException("SubFile does not exist.");
            var offset = SubEntry.Start + garc.DataOffset;
            byte[] data = new byte[SubEntry.Length];
            Array.Copy(Data, offset, data, 0, data.Length);
            return data;
        }
        public byte[][] Files
        {
            get
            {
                byte[][] data = new byte[FileCount][];
                for (int i = 0; i < data.Length; i++)
                    data[i] = GetFile(i);
                return data;
            }
            set
            {
                if (value == null || value.Length != FileCount)
                    throw new ArgumentException();

                var ng = PackGARC(value, garc.Version, (int)garc.ContentPadToNearest);
                garc = ng.garc;
                Data = ng.Data;
            }
        }
    }
    public class LazyGARC
    {
        private GARCFile garc;
        private byte[] Data;
        public int FileCount => garc.fato.EntryCount;

        public LazyGARC(byte[] data)
        {
            Data = data;
            garc = UnpackGARC(data);
            Storage = new GARCEntry[FileCount];
        }

        private readonly GARCEntry[] Storage;

        private class GARCEntry
        {
            public bool Saved;
            public byte[] Data;
            private readonly bool WasCompressed;

            public GARCEntry(byte[] data)
            {
                Data = data;

                if (data.Length == 0)
                    return;

                if (data[0] != 0x11)
                    return;

                try
                {
                    using (var newMS = new MemoryStream())
                    {
                        LZSS.Decompress(new MemoryStream(data), data.Length, newMS);
                        Data = newMS.ToArray();
                    }
                    WasCompressed = true;
                }
                catch { }
            }

            public byte[] Save()
            {
                if (!WasCompressed)
                    return Data;

                byte[] data;
                try
                {
                    using var newMS = new MemoryStream();
                    LZSS.Compress(new MemoryStream(Data), Data.Length, newMS, original: true);
                    data = newMS.ToArray();
                }
                catch { data = []; }
                return data;
            }
        }

        private byte[] GetFile(int file, int subfile = 0)
        {
            var Entry = garc.fatb.Entries[file];
            var SubEntry = Entry.SubEntries[subfile];
            if (!SubEntry.Exists)
                throw new ArgumentException("SubFile does not exist.");
            var offset = SubEntry.Start + garc.DataOffset;
            byte[] data = new byte[SubEntry.Length];
            Array.Copy(Data, offset, data, 0, data.Length);
            return data;
        }

        public byte[] this[int file]
        {
            get
            {
                if (file > FileCount)
                    throw new ArgumentException();

                Storage[file] ??= new GARCEntry(GetFile(file, 0));
                return Storage[file].Data;
            }
            set
            {
                Storage[file] ??= new GARCEntry(value);
                Storage[file].Data = value;
                Storage[file].Saved = true;
            }
        }

        public byte[] Save()
        {
            byte[][] data = new byte[FileCount][];
            for (int i = 0; i < data.Length; i++)
            {
                if (Storage[i]?.Saved != true) 
                    data[i] = GetFile(i, 0);
                else
                    data[i] = Storage[i].Save();
            }

            var ng = PackGARC(data, garc.Version, (int)garc.ContentPadToNearest);
            garc = ng.garc;
            Data = ng.Data;
            return Data;
        }
    }

    public struct GARCFile
    {
        public char[] Magic; 
        public uint HeaderSize; 
        public ushort Endianess;
        public ushort Version;
        public uint ChunkCount;

        public uint DataOffset;
        public uint FileSize;

        public uint ContentLargestPadded;
        public uint ContentLargestUnpadded;
        public uint ContentPadToNearest;

        public FATO fato;
        public FATB fatb;
        public FIMG fimg;
    }

    public struct FATO
    {
        public char[] Magic;
        public int HeaderSize;
        public ushort EntryCount;
        public ushort Padding;

        public FATO_Entry[] Entries;
    }

    public struct FATO_Entry
    {
        public int Offset;
    }

    public struct FATB
    {
        public char[] Magic;
        public int HeaderSize;
        public int FileCount;

        public FATB_Entry[] Entries;
    }

    public struct FATB_Entry
    {
        public uint Vector;
        public bool IsFolder;
        public FATB_SubEntry[] SubEntries;
    }

    public struct FATB_SubEntry
    {
        public bool Exists;
        public int Start;
        public int End;
        public int Length;
        public int Padding { get; set; }
    }

    public struct FIMG
    {
        public char[] Magic;
        public int HeaderSize;
        public int DataSize;
    }
}