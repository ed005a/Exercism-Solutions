using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder stringBuilder = new StringBuilder(identifier);
        stringBuilder.Replace(' ', '_');
        stringBuilder.Replace("\0", "CTRL");
        bool capNext = false;
        for (int i = 0; i < stringBuilder.Length; i++)
        {
            if (stringBuilder[i] == '-') capNext = true;
            else
            {
                if (capNext && char.IsLetter(stringBuilder[i]))
                {
                    stringBuilder[i] = char.ToUpper(stringBuilder[i]);
                    capNext = false;
                }
            }
        }

        for (int i = 0; i < stringBuilder.Length; i++)
        {
            if (stringBuilder[i] == '_') continue;
            if (!char.IsLetter(stringBuilder[i]) || stringBuilder[i] >= '\u03B1' && stringBuilder[i] <= '\u03C9')
            {
                stringBuilder.Remove(i, 1);
                i--;
            }
        }
        return stringBuilder.ToString();
    }
}
