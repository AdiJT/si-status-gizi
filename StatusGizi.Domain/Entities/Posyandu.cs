namespace StatusGizi.Domain.Entities;

public class Posyandu
{
    public int Id { get; set; }
    public string Nama { get; set; }

    public DesaKelurahan DesaKelurahan { get; set; }
    public List<Pengecekan> DaftarPengecekan { get; set; } = [];
}
