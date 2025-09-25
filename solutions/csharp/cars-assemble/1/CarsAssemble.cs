static class AssemblyLine
{
    public static double SuccessRate(int speed) => speed switch
    {
        0 => 0,
        >= 1 and <= 4 => 1,
        >= 5 and <= 8 => 0.9,
        9 => 0.8,
        10 => 0.77,
    };

    public static double ProductionRatePerHour(int speed) => (double)speed * SuccessRate(speed) * 221.0;

    public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
}
