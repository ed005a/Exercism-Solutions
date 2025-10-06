using System;
public class Player
{
    private readonly System.Random rand = new();
    public int RollDie()
    {
        return rand.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        return rand.NextDouble() * 100.0;
    }
}
