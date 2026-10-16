using System;
using System.IO;

namespace PKMNED.Core.CTR;
public static class LZSS
{
    public static long Decompress(string infile, string outfile)
    {
        string outDirectory = Path.GetDirectoryName(outfile);
        if (!Directory.Exists(outDirectory))
            Directory.CreateDirectory(outDirectory);
        using FileStream inStream = new(infile, FileMode.Open),
            outStream = new(outfile, FileMode.Create);
        return Decompress(inStream, inStream.Length, outStream);
    }


    public static long Decompress(Stream instream, long inLength, Stream outstream)
    {

        long readBytes = 0;

        byte type = (byte)instream.ReadByte();
        if (type != 0x11)
            throw new InvalidDataException($"The provided stream is not a valid LZ-0x11 compressed stream (invalid type 0x{type:X})");
        byte[] sizeBytes = new byte[3];
        instream.ReadExactly(sizeBytes, 0, 3);
        int decompressedSize = IOUtils.ToNDSu24(sizeBytes, 0);
        readBytes += 4;
        if (decompressedSize == 0)
        {
            sizeBytes = new byte[4];
            instream.ReadExactly(sizeBytes, 0, 4);
            decompressedSize = IOUtils.ToNDSs32(sizeBytes, 0);
            readBytes += 4;
        }
        const int bufferLength = 0x1000;
        byte[] buffer = new byte[bufferLength];
        int bufferOffset = 0;

        int currentOutSize = 0;
        int flags = 0, mask = 1;
        while (currentOutSize < decompressedSize)
        {
            if (mask == 1)
            {
                if (readBytes >= inLength)
                    throw new NotEnoughDataException(currentOutSize, decompressedSize);
                flags = instream.ReadByte(); readBytes++;
                if (flags < 0)
                    throw new StreamTooShortException();
                mask = 0x80;
            }
            else
            {
                mask >>= 1;
            }
            if ((flags & mask) > 0)
            {
                if (readBytes >= inLength)
                    throw new NotEnoughDataException(currentOutSize, decompressedSize);
                int byte1 = instream.ReadByte(); readBytes++;
                if (byte1 < 0)
                    throw new StreamTooShortException();

                int length = byte1 >> 4;
                int disp;
                if (length == 0)
                {
                    if (readBytes + 1 >= inLength)
                        throw new NotEnoughDataException(currentOutSize, decompressedSize);
                    int byte2 = instream.ReadByte(); readBytes++;
                    int byte3 = instream.ReadByte(); readBytes++;
                    if (byte3 < 0)
                        throw new StreamTooShortException();

                    length = (((byte1 & 0x0F) << 4) | (byte2 >> 4)) + 0x11;
                    disp = (((byte2 & 0x0F) << 8) | byte3) + 0x1;
                }
                else if (length == 1)
                {
                    if (readBytes + 2 >= inLength)
                        throw new NotEnoughDataException(currentOutSize, decompressedSize);
                    int byte2 = instream.ReadByte(); readBytes++;
                    int byte3 = instream.ReadByte(); readBytes++;
                    int byte4 = instream.ReadByte(); readBytes++;
                    if (byte4 < 0)
                        throw new StreamTooShortException();

                    length = (((byte1 & 0x0F) << 12) | (byte2 << 4) | (byte3 >> 4)) + 0x111;
                    disp = (((byte3 & 0x0F) << 8) | byte4) + 0x1;
                }
                else
                {
                    if (readBytes >= inLength)
                        throw new NotEnoughDataException(currentOutSize, decompressedSize);
                    int byte2 = instream.ReadByte(); readBytes++;
                    if (byte2 < 0)
                        throw new StreamTooShortException();

                    length = ((byte1 & 0xF0) >> 4) + 0x1;
                    disp = (((byte1 & 0x0F) << 8) | byte2) + 0x1;

                }

                if (disp > currentOutSize)
                {
                    throw new InvalidDataException($"Cannot go back more than already written. DISP = {disp}, #written bytes = 0x{currentOutSize:X} before 0x{instream.Position:X} with indicator 0x{byte1 >> 4:X}");
                }

                int bufIdx = bufferOffset + bufferLength - disp;
                for (int i = 0; i < length; i++)
                {
                    byte next = buffer[bufIdx % bufferLength];
                    bufIdx++;
                    outstream.WriteByte(next);
                    buffer[bufferOffset] = next;
                    bufferOffset = (bufferOffset + 1) % bufferLength;
                }
                currentOutSize += length;
            }
            else
            {
                if (readBytes >= inLength)
                    throw new NotEnoughDataException(currentOutSize, decompressedSize);
                int next = instream.ReadByte(); readBytes++;
                if (next < 0)
                    throw new StreamTooShortException();

                outstream.WriteByte((byte)next); currentOutSize++;
                buffer[bufferOffset] = (byte)next;
                bufferOffset = (bufferOffset + 1) % bufferLength;
            }
        }

        if (readBytes < inLength)
        {
            if ((readBytes ^ (readBytes & 3)) + 4 < inLength)
                throw new TooMuchInputException(readBytes, inLength);
        }

        return decompressedSize;
    }

    public static int Compress(string infile, string outfile)
    {
        string outDirectory = Path.GetDirectoryName(outfile);
        if (!Directory.Exists(outDirectory))
            Directory.CreateDirectory(outDirectory);
        using FileStream inStream = File.Open(infile, FileMode.Open),
            outStream = File.Create(outfile);
        if (inStream.Length == 0)
        {
            byte[] blank = [0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00];
            outStream.Write(blank, 0, blank.Length);
            return blank.Length;
        }

        return Compress(inStream, inStream.Length, outStream, true);
    }
    internal static unsafe int Compress(Stream instream, long inLength, Stream outstream, bool original)
    {
        if (inLength > 0xFFFFFF)
            throw new InputTooLargeException();

        if (!original)
        {
            return CompressWithLA(instream, inLength, outstream);
        }

        byte[] indata = new byte[inLength];
        int numReadBytes = instream.Read(indata, 0, (int)inLength);
        if (numReadBytes != inLength)
            throw new StreamTooShortException();
        outstream.WriteByte(0x11); outstream.WriteByte((byte)(inLength & 0xFF)); outstream.WriteByte((byte)((inLength >> 8) & 0xFF)); outstream.WriteByte((byte)((inLength >> 16) & 0xFF));

        int compressedLength = 4;

        fixed (byte* instart = &indata[0])
        {
            byte[] outbuffer = new byte[(8 * 4) + 1];
            outbuffer[0] = 0;
            int bufferlength = 1, bufferedBlocks = 0;
            int readBytes = 0;
            while (readBytes < inLength)
            {
                if (bufferedBlocks == 8)
                {
                    outstream.Write(outbuffer, 0, bufferlength);
                    compressedLength += bufferlength;
                    outbuffer[0] = 0;
                    bufferlength = 1;
                    bufferedBlocks = 0;
                }

                int oldLength = Math.Min(readBytes, 0x1000);
                int length = LZUtil.GetOccurrenceLength(instart + readBytes, (int)Math.Min(inLength - readBytes, 0x10110),
                    instart + readBytes - oldLength, oldLength, out var disp);
                if (length < 3)
                {
                    outbuffer[bufferlength++] = *(instart + readBytes++);
                }
                else
                {
                    readBytes += length;
                    outbuffer[0] |= (byte)(1 << (7 - bufferedBlocks));

                    if (length > 0x110)
                    {
                        outbuffer[bufferlength] = 0x10;
                        outbuffer[bufferlength] |= (byte)(((length - 0x111) >> 12) & 0x0F);
                        bufferlength++;
                        outbuffer[bufferlength] = (byte)(((length - 0x111) >> 4) & 0xFF);
                        bufferlength++;
                        outbuffer[bufferlength] = (byte)(((length - 0x111) << 4) & 0xF0);
                    }
                    else if (length > 0x10)
                    {
                        outbuffer[bufferlength] = 0x00;
                        outbuffer[bufferlength] |= (byte)(((length - 0x111) >> 4) & 0x0F);
                        bufferlength++;
                        outbuffer[bufferlength] = (byte)(((length - 0x111) << 4) & 0xF0);
                    }
                    else
                    {
                        outbuffer[bufferlength] = (byte)(((length - 1) << 4) & 0xF0);
                    }
                    outbuffer[bufferlength] |= (byte)(((disp - 1) >> 8) & 0x0F);
                    bufferlength++;
                    outbuffer[bufferlength] = (byte)((disp - 1) & 0xFF);
                    bufferlength++;
                }
                bufferedBlocks++;
            }

            if (bufferedBlocks > 0)
            {
                outstream.Write(outbuffer, 0, bufferlength);
                compressedLength += bufferlength;
            }
        }

        return compressedLength;
    }

    internal static unsafe int CompressWithLA(Stream instream, long inLength, Stream outstream)
    {
        byte[] indata = new byte[inLength];
        int numReadBytes = instream.Read(indata, 0, (int)inLength);
        if (numReadBytes != inLength)
            throw new StreamTooShortException();
        outstream.WriteByte(0x11);
        outstream.WriteByte((byte)(inLength & 0xFF));
        outstream.WriteByte((byte)((inLength >> 8) & 0xFF));
        outstream.WriteByte((byte)((inLength >> 16) & 0xFF));

        int compressedLength = 4;

        fixed (byte* instart = &indata[0])
        {
            byte[] outbuffer = new byte[(8 * 4) + 1];
            outbuffer[0] = 0;
            int bufferlength = 1, bufferedBlocks = 0;
            int readBytes = 0;
            GetOptimalCompressionLengths(instart, indata.Length, out var lengths, out var disps);
            while (readBytes < inLength)
            {
                if (bufferedBlocks == 8)
                {
                    outstream.Write(outbuffer, 0, bufferlength);
                    compressedLength += bufferlength;
                    outbuffer[0] = 0;
                    bufferlength = 1;
                    bufferedBlocks = 0;
                }

                if (lengths[readBytes] == 1)
                {
                    outbuffer[bufferlength++] = *(instart + readBytes++);
                }
                else
                {
                    outbuffer[0] |= (byte)(1 << (7 - bufferedBlocks));

                    if (lengths[readBytes] > 0x110)
                    {
                        outbuffer[bufferlength] = 0x10;
                        outbuffer[bufferlength] |= (byte)(((lengths[readBytes] - 0x111) >> 12) & 0x0F);
                        bufferlength++;
                        outbuffer[bufferlength] = (byte)(((lengths[readBytes] - 0x111) >> 4) & 0xFF);
                        bufferlength++;
                        outbuffer[bufferlength] = (byte)(((lengths[readBytes] - 0x111) << 4) & 0xF0);
                    }
                    else if (lengths[readBytes] > 0x10)
                    {
                        outbuffer[bufferlength] = 0x00;
                        outbuffer[bufferlength] |= (byte)(((lengths[readBytes] - 0x111) >> 4) & 0x0F);
                        bufferlength++;
                        outbuffer[bufferlength] = (byte)(((lengths[readBytes] - 0x111) << 4) & 0xF0);
                    }
                    else
                    {
                        outbuffer[bufferlength] = (byte)(((lengths[readBytes] - 1) << 4) & 0xF0);
                    }
                    outbuffer[bufferlength] |= (byte)(((disps[readBytes] - 1) >> 8) & 0x0F);
                    bufferlength++;
                    outbuffer[bufferlength] = (byte)((disps[readBytes] - 1) & 0xFF);
                    bufferlength++;

                    readBytes += lengths[readBytes];
                }

                bufferedBlocks++;
            }
            if (bufferedBlocks > 0)
            {
                outstream.Write(outbuffer, 0, bufferlength);
                compressedLength += bufferlength;
            }
        }

        return compressedLength;
    }

    internal static unsafe void GetOptimalCompressionLengths(byte* indata, int inLength, out int[] lengths, out int[] disps)
    {
        lengths = new int[inLength];
        disps = new int[inLength];
        int[] minLengths = new int[inLength];

        for (int i = inLength - 1; i >= 0; i--)
        {
            minLengths[i] = int.MaxValue;
            lengths[i] = 1;
            if (i + 1 >= inLength)
                minLengths[i] = 1;
            else
                minLengths[i] = 1 + minLengths[i + 1];
            int oldLength = Math.Min(0x1000, i);
            int maxLen = LZUtil.GetOccurrenceLength(indata + i, Math.Min(inLength - i, 0x10110),
                indata + i - oldLength, oldLength, out disps[i]);
            if (disps[i] > i)
                throw new Exception("disp is too large");
            for (int j = 3; j <= maxLen; j++)
            {
                int blocklen;
                if (j > 0x110)
                    blocklen = 4;
                else if (j > 0x10)
                    blocklen = 3;
                else
                    blocklen = 2;
                int newCompLen;
                if (i + j >= inLength)
                    newCompLen = blocklen;
                else
                    newCompLen = blocklen + minLengths[i + j];
                if (newCompLen < minLengths[i])
                {
                    lengths[i] = j;
                    minLengths[i] = newCompLen;
                }
            }
        }
    }
}

[Serializable]
public class InputTooLargeException : Exception
{

    public InputTooLargeException()
        : base("The compression ratio is not high enough to fit the input "
               + "in a single compressed file.")
    { }

    public InputTooLargeException(string message) : base(message)
    {
    }

    public InputTooLargeException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected InputTooLargeException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
    {
    }
}
[Serializable]
public class NotEnoughDataException : IOException
{
    public long WrittenLength { get; }
    public long DesiredLength { get; }
    public NotEnoughDataException(long currentOutSize, long totalOutSize)
        : base("Not enough data available; 0x" + currentOutSize.ToString("X")
                                               + " of " + (totalOutSize < 0 ? "???" : "0x" + totalOutSize.ToString("X"))
                                               + " bytes written.")
    {
        WrittenLength = currentOutSize;
        DesiredLength = totalOutSize;
    }

    public NotEnoughDataException()
    {
    }

    public NotEnoughDataException(string message) : base(message)
    {
    }

    public NotEnoughDataException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public NotEnoughDataException(string message, int hresult) : base(message, hresult)
    {
    }

    protected NotEnoughDataException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
    {
    }
}
[Serializable]
public class StreamTooShortException : EndOfStreamException
{
    public StreamTooShortException()
        : base("The end of the stream was reached "
               + "before the given amount of data was read.")
    { }

    public StreamTooShortException(string message) : base(message)
    {
    }

    public StreamTooShortException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected StreamTooShortException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
    {
    }
}
[Serializable]
public class TooMuchInputException : Exception
{
    public long ReadBytes { get; }
    public TooMuchInputException(long readBytes, long totLength)
        : base("The input contains more data than necessary. Only used 0x"
               + readBytes.ToString("X") + " of 0x" + totLength.ToString("X") + " bytes")
    {
        ReadBytes = readBytes;
    }

    public TooMuchInputException()
    {
    }

    public TooMuchInputException(string message) : base(message)
    {
    }

    public TooMuchInputException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected TooMuchInputException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
    {
    }
}
public static class LZUtil
{
    public static unsafe int GetOccurrenceLength(byte* newPtr, int newLength, byte* oldPtr, int oldLength, out int disp, int minDisp = 1)
    {
        disp = 0;
        if (newLength == 0)
            return 0;
        int maxLength = 0;
        for (int i = 0; i < oldLength - minDisp; i++)
        {
            byte* currentOldStart = oldPtr + i;
            int currentLength = 0;
            for (int j = 0; j < newLength; j++)
            {
                if (*(currentOldStart + j) != *(newPtr + j))
                    break;
                currentLength++;
            }
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                disp = oldLength - i;
                if (maxLength == newLength)
                    break;
            }
        }
        return maxLength;
    }
}

public static class IOUtils
{
    public static uint ToNDSu32(byte[] buffer, int offset)
    {
        return (uint)(buffer[offset]
                      | (buffer[offset + 1] << 8)
                      | (buffer[offset + 2] << 16)
                      | (buffer[offset + 3] << 24));
    }
    public static int ToNDSs32(byte[] buffer, int offset)
    {
        return buffer[offset]
               | (buffer[offset + 1] << 8)
               | (buffer[offset + 2] << 16)
               | (buffer[offset + 3] << 24);
    }
    public static byte[] FromNDSu32(uint value)
    {
        return
        [
            (byte)(value & 0xFF),
            (byte)((value >> 8) & 0xFF),
            (byte)((value >> 16) & 0xFF),
            (byte)((value >> 24) & 0xFF),
        ];
    }
    public static int ToNDSu24(byte[] buffer, int offset)
    {
        return buffer[offset]
               | (buffer[offset + 1] << 8)
               | (buffer[offset + 2] << 16);
    }
}