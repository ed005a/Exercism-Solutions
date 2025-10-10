public enum Allergen : byte
{
    Eggs = 1,
    Peanuts = 1 << 1,
    Shellfish = 1 << 2,
    Strawberries =  1 << 3,
    Tomatoes  = 1 << 4,
    Chocolate  = 1 << 5,
    Pollen = 1 << 6,
    Cats = 1 << 7,
}

public class Allergies
{
    List<Allergen> allergies = new List<Allergen>();
    public Allergies(int mask)
    {
        for (int i = 0; i < 8; i++)
        {
            if ((mask & (1 << i)) == (1 << i)) allergies.Add((Allergen)(1 << i));
        }
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return allergies.Contains(allergen);
    }

    public Allergen[] List()
    {
        return allergies.ToArray();
    }
}