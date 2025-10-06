using System;
public class Player
{
    private readonly System.Random rand = new();
    public int RollDie() => rand.Next(1, 19);

    public double GenerateSpellStrength() => rand.NextDouble() * 100.0;
}
