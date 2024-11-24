using StatusGizi.Domain.Entities;

namespace StatusGizi.Web.Models.StatusGizi;

public class DetailVM
{
    public required DesaKelurahan DesaKelurahan { get; set; }
    public required List<Pengecekan> DaftarPengecekan { get; set; }
}
