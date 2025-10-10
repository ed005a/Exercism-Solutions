public static class ResistorColor
{
    private static string[] colorCodes = {"black", "brown", "red",  "orange", "yellow", "green", "blue", "violet", "grey", "white"};
    public static int ColorCode(string color)
    {
        for (int i = 0; i < colorCodes.Length; i++) if (colorCodes[i] == color) return i;
        return -1;
    }

    public static string[] Colors() =>  colorCodes;
}