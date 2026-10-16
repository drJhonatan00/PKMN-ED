namespace PKMNED.Core.CTR;
public interface IXLIMHeader
{
    uint Magic { get; set; }
    ushort Width { get; set; }
    ushort Height { get; set; }
    XLIMEncoding Format { get; set; }
    XLIMOrientation Orientation { get; set; }

    bool Valid { get; }
}