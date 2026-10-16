namespace PKMNED.Core.Randomizers;
public class GenericRandomizer(int[] randomValues)
{
    private int ctr;

    public void Reset()
    {
            ctr = 0;
            Util.Shuffle(randomValues);
        }

    public int Next()
    {
            if (ctr == 0)
                Util.Shuffle(randomValues);

            int value = randomValues[ctr++];
            ctr %= randomValues.Length;
            return value;
        }
}