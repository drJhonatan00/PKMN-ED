using System.Runtime.InteropServices;

namespace PKMNED.Core.CTR;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
public struct CLIMHeader : IXLIMHeader
{
    public const int SIZE = 40;
    public const string Identifier = "CLIM";
    public readonly bool Valid => LittleEndian && Magic == 0x4D_49_4C_43;
    public readonly bool LittleEndian => BOM == 0xFEFF;
    public readonly bool BigEndian => BOM == 0xFFFE;

    public uint Magic { get; set; }
    public ushort BOM;
    public uint HeaderLength;
    public byte TileWidth;
    public byte TileHeight;
    public uint totalLength;
    public uint Count;

    public uint imag;
    public uint imagLength;
    public ushort Width { get; set; }
    public ushort Height { get; set; }
    public XLIMEncoding Format { get; set; }
    public XLIMOrientation Orientation { get; set; }
    public short Alignment;
    public uint DataSize;
}