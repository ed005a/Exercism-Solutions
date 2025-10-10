using System.Collections;

public class HighScores
{
    List<int> scores;
    public HighScores(List<int> list) => scores = list;

    public List<int> Scores() => scores;

    public int Latest() => scores[scores.Count - 1];

    public int PersonalBest() => scores.Max();

    bool comp(int a, int b) => a < b;
    public List<int> PersonalTopThree()
    {
        List<int> answer = new(), copied =  new(scores);
        copied.Sort();
        copied.Reverse();
        for (int i = 0; i < 3 && i < copied.Count; i++) answer.Add(copied[i]);
        return answer;
    }

}