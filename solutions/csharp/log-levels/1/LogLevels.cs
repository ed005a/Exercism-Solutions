using System.Text.RegularExpressions;
static class LogLine
{
    private static string pattern1 = @"\[.+\]\:\s*(.+)\b\s*";
    private static string pattern2 = @"\[(.+)\]";
    public static string Message(string logLine) => Regex.Match(logLine, pattern1).Groups[1].Value;

    public static string LogLevel(string logLine) => Regex.Match(logLine, pattern2).Groups[1].Value.ToLower();

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
