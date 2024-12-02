using StatusGizi.Domain.Entities;

namespace StatusGizi.Web.Models.PemeriksaanModels;

public class IndexVM
{
    public required Pengecekan Pengecekan { get; set; }
    public required StandarBeratMenurutBBTB StandarBeratMenurutBBTB { get; set; }
}
