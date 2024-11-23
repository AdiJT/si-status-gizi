using StatusGizi.Domain.Enums;

namespace StatusGizi.Domain.Entities;

public class Pengecekan
{
    public int Id { get; set; }
    public double LingkarLenganAtas { get; set; }
    public double BeratBadan { get; set; }
    public double TinggiBadan { get; set; }
    public DateOnly TanggalPengecekan { get; set; }
    public KategoriGizi KategoriGizi { get; set; }

    public TimeSpan Usia  => TimeSpan.FromDays(TanggalPengecekan.DayNumber - Balita.TanggalLahir.DayNumber);

    public Balita Balita { get; set; }
    public Posyandu Posyandu { get; set; }
}
