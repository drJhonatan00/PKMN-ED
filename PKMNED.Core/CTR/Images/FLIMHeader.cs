using System.Runtime.InteropServices;

namespace PKMNED.Core.CTR;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
public struct FLIMHeader : IXLIMHeader
{
    public const int SIZE = 40;
    public const string Identifier = "FLIM";
    public readonly bool Valid => LittleEndian && Magic == 0x4D_49_4C_46;
    public readonly bool LittleEndian => BOM == 0xFEFF;
    public readonly bool BigEndian => BOM == 0xFFFE;

    public uint Magic { get; set; }
    public ushort BOM;
    public ushort HeaderLength;
    public int Version;
    public uint TotalLength;
    public uint Count;

    public uint imag;
    public uint imagLength;
    public ushort Width { get; set; }
    public ushort Height { get; set; }
    public short Alignment;
    public XLIMEncoding Format { get; set; }
    public XLIMOrientation Orientation { get; set; }
    public uint DataSize;
}