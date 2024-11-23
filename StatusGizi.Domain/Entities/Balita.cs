using StatusGizi.Domain.Enums;

namespace StatusGizi.Domain.Entities;

public class Balita
{
    public int NIK { get; set; }
    public string Nama { get; set; }
    public DateOnly TanggalLahir { get; set; }
    public JenisKelamin JenisKelamin { get; set; }
    public double BeratBadanWaktuLahir { get; set; }
    public double TinggiBadanWaktuLahir { get; set; }

    public OrangTua OrangTua { get; set; }
}
