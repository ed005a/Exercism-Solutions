public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> dict = new()
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0,
        };
        for (int i = 0; i < sequence.Length; i++)
        {
            try
            {
                dict[sequence[i]]++;
            }
            catch (KeyNotFoundException)
            {
                throw new ArgumentException();
            }
        }
        return dict;
    }
}