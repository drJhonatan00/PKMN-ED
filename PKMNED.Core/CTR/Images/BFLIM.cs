using System.IO;
using PKMNED.Core.CTR.Images;

namespace PKMNED.Core.CTR;

public class BFLIM : BXLIM
{
    public BFLIM(Stream data) => ReadBFLIM(data);

    public BFLIM(byte[] data)
    {
        using var ms = new MemoryStream(data);
        ReadBFLIM(ms);
    }

    public BFLIM(string path)
    {
        var data = File.ReadAllBytes(path);
        using var ms = new MemoryStream(data);
        ReadBFLIM(ms);
    }

    private void ReadBFLIM(Stream ms)
    {
        PixelData = new byte[ms.Length - FLIMHeader.SIZE];
        ms.ReadExactly(PixelData);
        var footer = new byte[FLIMHeader.SIZE];
        ms.ReadExactly(footer);
        Footer = footer.ToStructure<FLIMHeader>();
    }
}