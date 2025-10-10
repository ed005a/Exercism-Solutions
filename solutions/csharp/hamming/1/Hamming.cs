public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int answer = 0;
        if (firstStrand.Length != secondStrand.Length) throw new ArgumentException();
        for (int i = 0; i < firstStrand.Length; i++)
        {
            answer +=  firstStrand[i] != secondStrand[i] ? 1 : 0;
        }

        return answer;
    }
}