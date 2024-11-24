namespace StatusGizi.Domain.Commons;

public static class TimeSpanExtension
{
    public static string Humanize(this TimeSpan timeSpan)
    {
        var inYears = (int)timeSpan.TotalDays / 365;
        var inMonths = ((int)timeSpan.TotalDays / 31) % 12;
        var inDays = (int)timeSpan.TotalDays % 365;

        return $"{inYears} tahun {inMonths} bulan {inDays} hari";
    }
}
