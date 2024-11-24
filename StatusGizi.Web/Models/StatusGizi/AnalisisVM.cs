using StatusGizi.Domain.Entities;

namespace StatusGizi.Web.Models.StatusGizi;

public class AnalisisVM
{
    public required Pengecekan Pengecekan { get; set; }
    public required StandarBeratMenurutBBTB StandarBeratMenurutBBTB { get; set; }
}
