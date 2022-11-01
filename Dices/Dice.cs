namespace Dices;

public static class Dice
{
    public static uint Roll(int dice, int modifier = 0, uint multiplier = 1)
    {
        Random random = new Random();
        uint roll = (uint)random.Next(1, dice + 1);

        if (roll <= modifier)
        {
            roll = 0;
        }

        return roll * multiplier;
    }
}