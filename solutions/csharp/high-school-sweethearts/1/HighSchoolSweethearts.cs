using System.Globalization;
using System.Runtime.InteropServices.JavaScript;

public static class HighSchoolSweethearts
{
    public static string DisplaySingleLine(string studentA, string studentB)
    {
        int paddingLeft = 29 - studentA.Length;
        int paddingRight = 29 - studentB.Length;
        return new String(' ', paddingLeft) +  studentA + " ♡ " + studentB + new String(' ' , paddingRight);
    }

    public static string DisplayBanner(string studentA, string studentB) =>
        $"""
                              ******       ******
                            **      **   **      **
                          **         ** **         **
                         **            *            **
                         **                         **
                         **     {studentA} +  {studentB}    **
                          **                       **
                            **                   **
                              **               **
                                **           **
                                  **       **
                                    **   **
                                      ***
                                       *
                         """;

    public static string DisplayGermanExchangeStudents(string studentA
      , string studentB, DateTime start, float hours)
    {
      CultureInfo culture = new CultureInfo("de-DE");
      string ans = String.Format("{0} and {1} have been dating since {2:dd.MM.yyyy} - that's {3} hours", studentA, studentB, start.Date, hours.ToString("N2", culture));
      return ans;
    }
}
