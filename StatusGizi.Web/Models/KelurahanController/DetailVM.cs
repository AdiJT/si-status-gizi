using StatusGizi.Domain.Entities;

namespace StatusGizi.Web.Models.KelurahanController;

public class DetailVM
{
    public required DesaKelurahan DesaKelurahan { get; set; }
    public required List<Pengecekan> DaftarPengecekan { get; set; }
}
