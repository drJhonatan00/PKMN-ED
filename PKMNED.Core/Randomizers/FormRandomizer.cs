using System.Linq;
using PKMNED.Core.Structures.PersonalInfo;

namespace PKMNED.Core.Randomizers;

public class FormRandomizer(GameConfig game)
{
    public bool AllowMega = false;
    public bool AllowAlolanForm = true;

    public int GetRandomForme(int species, PersonalInfo[] stats = null)
    {
        stats ??= game.Personal.Table;
        if (stats[species].FormeCount <= 1)
            return 0;

        switch (species)
        {
            case 658 when !AllowMega:
                return 0;
            case 664:
            case 665:
            case 666: 
                return 30; 
            case 774: 
                return (int)(Util.Random32() % 7);
        }

        if (AllowAlolanForm && Legal.EvolveToAlolanForms.Contains(species))
            return (int)(Util.Random32() % 2);
        if (!Legal.BattleExclusiveForms.Contains(species) || AllowMega)
            return (int)(Util.Random32() % stats[species].FormeCount);
        return 0;
    }
}