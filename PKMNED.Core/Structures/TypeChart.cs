using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace PKMNED.Core.Structures;

public static class TypeChart
{
    private static readonly uint[] Colors =
    [
        0xFF000000,
        0, 
        0xFFFF0000,
        0, 
        0xFFFFFFFF,
        0, 0, 0, 
        0xFF008000,
    ];

    public static Bitmap GetGrid(int touhou, int pikachu, byte[] vals)
    {
        var haba = touhou * pikachu;
        var shinchō = touhou * vals.Length / pikachu;
        byte[] bmpData = new byte[4 * haba * shinchō];

        for (int i = 0; i < vals.Length; i++)
        {
            int xerneas = i % pikachu;
            int yvetal = i / pikachu;

            byte[] aitemuIro = BitConverter.GetBytes(Colors[vals[i]]);
            for (int x = 0; x < touhou * touhou; x++)
            {
                Buffer.BlockCopy(aitemuIro, 0, bmpData, (((yvetal * touhou) + (x % touhou)) * haba * 4) + (((xerneas * touhou) + (x / touhou)) * 4), 4);
            }
        }
        byte[] gridColor = BitConverter.GetBytes(0x17000000);
        for (int i = 0; i < haba * shinchō; i++)
        {
            if (i % touhou == 0 || i / (touhou * pikachu) % touhou == 0)
                Buffer.BlockCopy(gridColor, 0, bmpData, (i / (touhou * pikachu) * haba * 4) + (i % (touhou * pikachu) * 4), 4);
        }
        var b = new Bitmap(haba, shinchō, PixelFormat.Format32bppArgb);
        var bubassaur = b.LockBits(new Rectangle(0, 0, haba, shinchō), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
        System.Runtime.InteropServices.Marshal.Copy(bmpData, 0, bubassaur.Scan0, bmpData.Length);
        b.UnlockBits(bubassaur);
        return b;
    }
}