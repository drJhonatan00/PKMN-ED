using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PKMNED.Core.Structures.PersonalInfo;

namespace PKMNED.Core;

public static class Gen7SlotDumper
{
    public static byte[][] GetRegularBinary(Area7[] areas, bool sm)
    {
        var dict = DumpAreas(areas, sm ? InaccessibleUnused_SM : InaccessibleUnused_USUM);
        return GetLocationDump(dict).ToArray();
    }
    public static byte[][] GetSOSBinary(Area7[] areas, PersonalTable personal, bool sm)
    {
        var dict = DumpAreas(areas, personal, sm ? InaccessibleUnused_SM : InaccessibleUnused_USUM);
        return GetLocationDump(dict).ToArray();
    }

    private static Dictionary<int, List<uint>> DumpAreas(Area7[] areas, PersonalTable personal, IReadOnlyDictionary<int, int[]> ignored)
    {
        var dict = new Dictionary<int, List<uint>>();
        for (var areaIndex = 0; areaIndex < areas.Length; areaIndex++)
        {
            var area = areas[areaIndex];
            for (var zoneIndex = 0; zoneIndex < area.Zones.Length; zoneIndex++)
            {
                var z = area.Zones[zoneIndex];
                int loc = z.ParentMap;

                var ignore = ignored.TryGetValue(z.Index, out var skip) ? skip : [];
                if (!dict.ContainsKey(loc))
                    dict.Add(loc, []);

                for (var index = 0; index < area.Tables.Count; index++)
                {
                    var t = area.Tables[index];
                    if (ignore.Contains((index >> 1) + 1))
                    {
                        Log(areaIndex, z.Index, index, z.Name);
                        continue;
                    }

                    if (!dict.ContainsKey(loc))
                        dict.Add(loc, []);
                    var table = dict[loc];
                    var first = t.Encounter7s[0];
                    if (first.All(sz => sz.Species == 731))
                    {
                        Log(areaIndex, z.Index, index, z.Name, "Pikipek Table");
                        continue;
                    }

                    for (int i = 0; i < first.Length; i++)
                    {
                        var wild = first[i];
                        if (personal[(int)wild.Species].EscapeRate == 0)
                            continue;

                        for (int j = 1; j < t.Encounter7s.Length - 1; j++)
                            table.Add(t.Encounter7s[j][i].Dump(t));
                    }

                    foreach (var s in t.AdditionalSOS)
                        table.Add(s.Dump(t));
                }
            }
        }

        return dict;
    }

    private static Dictionary<int, List<uint>> DumpAreas(Area7[] areas, IReadOnlyDictionary<int, int[]> ignored)
    {
        var dict = new Dictionary<int, List<uint>>();
        for (var areaIndex = 0; areaIndex < areas.Length; areaIndex++)
        {
            var area = areas[areaIndex];
            for (var zoneIndex = 0; zoneIndex < area.Zones.Length; zoneIndex++)
            {
                var z = area.Zones[zoneIndex];
                int loc = z.ParentMap;

                var ignore = ignored.TryGetValue(z.Index, out var skip) ? skip : [];
                for (var index = 0; index < area.Tables.Count; index++)
                {
                    if (ignore.Contains((index >> 1) + 1))
                    {
                        Log(areaIndex, z.Index, index, z.Name);
                        continue;
                    }
                    if (!dict.ContainsKey(loc))
                        dict.Add(loc, []);

                    var t = area.Tables[index];
                    var first = t.Encounter7s[0];
                    if (first.All(sz => sz.Species == 731))
                    {
                        Log(areaIndex, z.Index, index, z.Name, "Pikipek Table");
                        continue;
                    }
                    var table = dict[loc];
                    foreach (var wild in first)
                        table.Add(wild.Dump(t));
                }
            }
        }

        return dict;
    }

    private static void Log(int area, int zi, int ti, string zn, string msg = "Dictionary")
    {
        Console.WriteLine($"Skipped [{area}] {zi:00},{ti:00} ({(ti >> 1) + 1:00} {(ti % 2 == 0 ? "D" : "N")}) @ {zn}: {msg}");
    }

    public static bool IsZoneAccessible(int areaIndex, int zoneIndex, bool sm)
    {
        var dict = sm ? InaccessibleUnused_SM : InaccessibleUnused_USUM;
        if (!dict.TryGetValue(areaIndex, out var zones))
            return false;

        return !zones.Contains((zoneIndex >> 1) + 1);
    }

    private static IEnumerable<byte[]> GetLocationDump(Dictionary<int, List<uint>> dict)
    {
        foreach (var z in dict.OrderBy(z => z.Key))
        {
            using var ms = new MemoryStream();
            using var bw = new BinaryWriter(ms);
            bw.Write((ushort)z.Key);
            foreach (var s in z.Value.Distinct())
                bw.Write(s);
            yield return ms.ToArray();
        }
    }

    public static readonly Dictionary<int, int[]> InaccessibleUnused_USUM = new()
    {
        {000, [1, 2, 4, 5, 6, 7, 8, 9, 12, 13, 14, 15, 16, 17, 18] },
        {003, [3, 4, 5, 6, 7, 8, 10, 11, 18] },
        {010, [1, 2, 3, 9, 10, 12, 13, 14, 15, 16, 17, 18] },
        {001, [1, 2, 3] },
        {006, [2, 5, 6, 7, 8, 9, 15] },
        {008, [1, 3, 4, 10, 11, 12, 13, 14] },
        {012, [2, 3, 4, 5, 6] },
        {013, [1, 2, 7, 8] },
        {014, [1, 2, 3, 4, 5, 6, 7, 8] },
        {086, [1, 2, 3, 4] },
        {097, [3, 4, 5, 6, 7, 8, 9] },
        {098, [1, 2] },
        {168, [2, 3, 4, 5, 6, 7, 8] },
        {169, [1] },
        {170, [5, 7, 8, 10] },
        {171, [1, 2, 3, 4, 6, 9, 10] },
        {174, [1, 2, 3] },
        {265, [1, 2, 3, 4, 5, 6, 7, 8] },
        {266, [9, 10, 11] },
    };

    public static readonly Dictionary<int, int[]> InaccessibleUnused_SM = new()
    {
        {000, [1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 16] },
        {001, [4, 5, 6, 7, 8, 9, 14, 17] },
        {006, [1, 2, 3, 4, 10, 11, 12, 13, 14, 15, 16, 17] },
        {002, [2, 5, 6, 7, 8, 9, 15] },
        {004, [1, 3, 4, 10, 11, 12, 13, 14] },
        {007, [2, 3, 4, 5, 6] },
        {008, [1, 2] },
        {009, [1, 2, 3, 4, 5, 6, 7, 8] },
        {074, [1, 2, 3, 4] },
        {083, [3, 4, 5, 6, 7, 8, 9] },
        {084, [1, 2] },
        {142, [1, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15] },
        {149, [2, 3, 4, 5] },
        {144, [2, 3, 4, 5, 6, 7, 8] },
        {145, [1] },
        {146, [5, 6, 7, 8, 10] },
        {147, [2, 3, 4, 9, 10] },
        {150, [1, 2, 3] },
        {232, [1, 2, 3, 4, 5] },
        {233, [6, 7, 8] },
    };
}