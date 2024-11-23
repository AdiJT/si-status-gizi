namespace StatusGizi.Domain.Entities;

public class DesaKelurahan
{
    public int Id { get; set; }
    public string Nama { get; set; }

    public List<OrangTua> DaftarOrangTua { get; set; } = [];
    public List<Posyandu> DaftarPosyandu { get; set; } = [];
}