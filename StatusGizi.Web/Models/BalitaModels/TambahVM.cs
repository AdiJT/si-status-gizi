using StatusGizi.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace StatusGizi.Web.Models.BalitaModels;

public class TambahVM
{
    [Display(Name = "NIK")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [RegularExpression("^\\d{16}$", ErrorMessage = "{0} tidak valid")]
    public string NIK { get; set; } = string.Empty;

    [Display(Name = "Nama")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Nama { get; set; } = string.Empty;

    [Display(Name = "Tanggal Lahir")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public DateOnly TanggalLahir { get; set; }

    [Display(Name = "Jenis Kelamin")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public JenisKelamin JenisKelamin { get; set; }

    [Display(Name = "Berat Badan Lahir (Kg)")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Range(1e-10, double.MaxValue, ErrorMessage = "{0} tidak boleh negatif atau 0")]
    public double BeratBadanLahir { get; set; }

    [Display(Name = "Tinggi Badan Lahir (cm)")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Range(1e-10, double.MaxValue, ErrorMessage = "{0} tidak boleh negatif atau 0")]
    public double TinggiBadanLahir { get; set; }

    [Display(Name = "Orang Tua")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public int OrangTuaId { get; set; }
}
