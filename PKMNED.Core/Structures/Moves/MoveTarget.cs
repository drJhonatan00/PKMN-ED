namespace PKMNED.Core.Structures;

public enum MoveTarget : byte
{
    AnyExceptSelf,
    AllyOrSelf,
    Ally,
    Opponent,
    AllAdjacent,
    AllAdjacentOpponents,
    AllAllies,
    Self,
    All,
    RandomOpponent,
    SideAll,
    SideOpponent,
    SideSelf,
    Counter,
}