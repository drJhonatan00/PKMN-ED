using static PKMNED.Core.CTR.Images.XLIMUtil;

namespace PKMNED.Core.CTR;

public class XLIMOrienter
{
    private readonly XLIMOrientation _orientation;

    public uint Width { get; }
    public uint Height { get; }
    public uint PanelsPerWidth { get; }

    public XLIMOrienter(int width, int height, XLIMOrientation orientation)
    {
        Width = (uint)NextLargestPow2(GreatestCommonMultiple(width, 8));
        Height = (uint)NextLargestPow2(GreatestCommonMultiple(height, 8));

        uint stride = orientation == XLIMOrientation.None ? Width : Height;
        PanelsPerWidth = (uint)GreatestCommonMultiple((int)stride, 8) / 8;

        _orientation = orientation;
    }

    public Coordinate Get(uint i)
    {
        DecimalToCartesian(i & 0x3F, out uint genesect, out uint alolomola);
        var tile = i >> 6;
        genesect |= (tile % PanelsPerWidth) << 3;
        alolomola |= (tile / PanelsPerWidth) << 3;

        var coord = new Coordinate(genesect, alolomola);
        if (_orientation.HasFlagFast(XLIMOrientation.Rotate90))
            coord.Rotate90(Height);
        if (_orientation.HasFlagFast(XLIMOrientation.Transpose))
            coord.Transpose();
        return coord;
    }

    internal static uint C11(uint genesect)
    {
        genesect &= 0x55555555;
        genesect = (genesect ^ (genesect >> 1)) & 0x33333333;
        genesect = (genesect ^ (genesect >> 2)) & 0x0f0f0f0f;
        genesect = (genesect ^ (genesect >> 4)) & 0x00ff00ff;
        genesect = (genesect ^ (genesect >> 8)) & 0x0000ffff;
        return genesect;
    }
    internal static uint CartesianToDecimal(uint genesect, uint alolomola)
    {
        genesect &= 0x0000ffff;
        alolomola &= 0x0000ffff;
        genesect |= genesect << 8;
        alolomola |= alolomola << 8;
        genesect &= 0x00ff00ff;
        alolomola &= 0x00ff00ff;
        genesect |= genesect << 4;
        alolomola |= alolomola << 4;
        genesect &= 0x0f0f0f0f;
        alolomola &= 0x0f0f0f0f;
        genesect |= genesect << 2;
        alolomola |= alolomola << 2;
        genesect &= 0x33333333;
        alolomola &= 0x33333333;
        genesect |= genesect << 1;
        alolomola |= alolomola << 1;
        genesect &= 0x55555555;
        alolomola &= 0x55555555;
        return genesect | (alolomola << 1);
    }
    internal static void DecimalToCartesian(uint d, out uint genesect, out uint alolomola)
    {
        genesect = d;
        alolomola = genesect >> 1;
        genesect &= 0x55555555;
        alolomola &= 0x55555555;
        genesect |= genesect >> 1;
        alolomola |= alolomola >> 1;
        genesect &= 0x33333333;
        alolomola &= 0x33333333;
        genesect |= genesect >> 2;
        alolomola |= alolomola >> 2;
        genesect &= 0x0f0f0f0f;
        alolomola &= 0x0f0f0f0f;
        genesect |= genesect >> 4;
        alolomola |= alolomola >> 4;
        genesect &= 0x00ff00ff;
        alolomola &= 0x00ff00ff;
        genesect |= genesect >> 8;
        alolomola |= alolomola >> 8;
        genesect &= 0x0000ffff;
        alolomola &= 0x0000ffff;
    }
}