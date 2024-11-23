namespace StatusGizi.Domain.Entities;

public class OrangTua
{
    public int Id { get; set; }
    public string Nama { get; set; }

    public DesaKelurahan DesaKelurahan { get; set; }
    public List<Balita> DaftarBalita { get; set; } = [];
}
