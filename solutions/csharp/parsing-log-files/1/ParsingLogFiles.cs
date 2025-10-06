using System.Text.RegularExpressions;
using System.Xml.Schema;

public class LogParser
{
    public bool IsValidLine(string text) => Regex.IsMatch(text, @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]");
    public string[] SplitLogLine(string text) => Regex.Split(text, @"<[\^\*\=\-]*>");

    public int CountQuotedPasswords(string lines)
    {
        Regex regex = new Regex(@"""[^""]*password[^""]*""", RegexOptions.IgnoreCase);
        return regex.Matches(lines).Count;
    }

    public string RemoveEndOfLineText(string line)
    {
        string pattern = @"end-of-line\d+";
        return Regex.Replace(line, pattern, "");
    }

    public string[] ListLinesWithPasswords(string[] lines)
    {
        string pattern = @"\b(password\w+)\b";
        string[] answer = new string[lines.Length];
        
        for (int i = 0; i < lines.Length; i++)
        {
            var match = Regex.Match(lines[i], pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                answer[i] = $"{match.Value}: {lines[i]}";
            }
            else
            {
                answer[i] = $"--------: {lines[i]}";
            }
        }
        return answer;
    }
}
