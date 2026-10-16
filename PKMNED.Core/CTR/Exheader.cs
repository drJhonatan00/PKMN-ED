using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using PKMNED.Core.Properties;

namespace PKMNED.Core.CTR;

public class Exheader
{
    public readonly byte[] Data;
    public readonly byte[] AccessDescriptor;
    public readonly ulong TitleID;

    public Exheader(string EXHEADER_PATH)
    {
        Data = File.ReadAllBytes(EXHEADER_PATH);
        AccessDescriptor = Data.Skip(0x400).Take(0x400).ToArray();
        Data = Data.Take(0x400).ToArray();
        TitleID = BitConverter.ToUInt64(Data, 0x200);
    }

    public byte[] GetSuperBlockHash()
    {
        return SHA256.HashData(Data.AsSpan(0, 0x400));
    }

    public string GetSerial()
    {
        const string output = "CTR-P-";

        var RecognizedGames = new Dictionary<ulong, string[]>();
        var lines = Resources.ResourceManager.GetString("_3dsgames").Split('\n').ToArray();
        foreach (string l in lines)
        {
            string[] vars = l.Split('\t');
            ulong titleid = Convert.ToUInt64(vars[0], 16);
            if (RecognizedGames.TryGetValue(titleid, out var value))
            {
                char lc = value.ToArray()[0][3];
                char lc2 = vars[1][3];
                if (lc2 == 'A' || lc2 == 'E' || (lc2 == 'P' && lc == 'J'))
                {
                    RecognizedGames[titleid] = vars.Skip(1).Take(2).ToArray();
                }
            }
            else
            {
                RecognizedGames.Add(titleid, vars.Skip(1).Take(2).ToArray());
            }
        }
        return output + RecognizedGames[TitleID][0];
    }

    public bool IsSupported()
    {
        return IsORAS() || IsXY() || IsUSUM() || IsSM();
    }

    public bool IsUSUM()
    {
        return (TitleID & 0xFFFFFFFF) >> 8 == 0x1B50 || (TitleID & 0xFFFFFFFF) >> 8 == 0x1B51;
    }

    public bool IsSM()
    {
        return (TitleID & 0xFFFFFFFF) >> 8 == 0x1648 || (TitleID & 0xFFFFFFFF) >> 8 == 0x175E;
    }

    public bool IsORAS()
    {
        return (TitleID & 0xFFFFFFFF) >> 8 == 0x11C5 || (TitleID & 0xFFFFFFFF) >> 8 == 0x11C4;
    }

    public bool IsXY()
    {
        return (TitleID & 0xFFFFFFFF) >> 8 == 0x55D || (TitleID & 0xFFFFFFFF) >> 8 == 0x55E;
    }

    public string GetPokemonSerial()
    {
        if (!IsSupported())
            return "CTR-P-XXXX";
        string name = ((TitleID & 0xFFFFFFFF) >> 8) switch
        {
            0x055D => "EKJA",
            0x055E => "EK2A",
            0x11C5 => "ECLA",
            0x11C4 => "ECRA",
            0x1648 => "BNDA", 
            0x175E => "BNEA",
            0x1B50 => "A2AA",
            0x1B51 => "A2BA",        
            _ => "XXXX",
        };
        return "CTR-P-" + name;
    }
}