using System;

namespace PKMNED.Core.Structures;

[Flags]
public enum BattleStatusFlags : byte
{
    None = 0,
    SLP = 1 << 0,
    PSN = 1 << 1,
    BRN = 1 << 2,
    FRZ = 1 << 3,
    PAR = 1 << 4,
    CFZ = 1 << 5,
    INF = 1 << 6,
    GSP = 1 << 7,
}