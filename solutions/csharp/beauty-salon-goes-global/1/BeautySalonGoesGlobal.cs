using System.Globalization;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    private static TimeZoneInfo GetTimeZone(Location location) => location switch
    {
        Location.NewYork => TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"),
        Location.London => TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"),
        Location.Paris => TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"),
        _ => TimeZoneInfo.Local,
    };
    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        TimeZoneInfo eastern = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"); 
        TimeZoneInfo gmt = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"); 
        TimeZoneInfo western = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
        DateTime dateTime = DateTime.Parse(appointmentDateDescription);
        return TimeZoneInfo.ConvertTimeToUtc(dateTime, GetTimeZone(location));
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel) => alertLevel switch
    {
        AlertLevel.Early => appointment.AddDays(-1),
        AlertLevel.Standard => appointment.AddMinutes(-105),
        AlertLevel.Late => appointment.AddMinutes(-30),
    };

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        TimeZoneInfo tzi = GetTimeZone(location);
        bool dstNow = tzi.IsDaylightSavingTime(dt);
        for (int i = 0; i < 7; i++)
        {
            if (dstNow != tzi.IsDaylightSavingTime(dt.AddDays(-i)))
                return true;
        }
        return false;
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        CultureInfo ci = location switch
        {
            Location.NewYork => new CultureInfo("en-US"),
            Location.London => new CultureInfo("en-GB"),
            Location.Paris => new CultureInfo("fr-FR"),
        };
        if (DateTime.TryParse(dtStr, ci, DateTimeStyles.None, out DateTime parsed))
        {
            return parsed;
        }
        return new DateTime(1, 1, 1);
    }
}
