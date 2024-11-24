using StatusGizi.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace StatusGizi.Web.Models.StatusGizi;

public class IsiDataVM
{
    [Display(Name = "NIK")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string NIK { get; set; } = string.Empty;

    [Display(Name = "Nama")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Nama { get; set; } = string.Empty;

    [Display(Name = "Tanggal Lahir")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public DateOnly TanggalLahir { get; set; }

    [Display(Name = "BB Lahir (Kg)")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Range(0, double.MaxValue, ErrorMessage = "{0} minimal {1}")]
    public double BeratBadanLahir { get; set; }

    [Display(Name = "TB Lahir (cm)")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Range(0, double.MaxValue, ErrorMessage = "{0} minimal {1}")]
    public double TinggiBadanLahir { get; set; }

    [Display(Name = "Jenis Kelamin")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public JenisKelamin JenisKelamin { get; set; }

    [Display(Name = "Nama Orang Tua")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string OrangTua { get; set; } = string.Empty;

    [Display(Name = "Desa/Kelurahan Tinggal")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public int DesaKelurahanTinggalId { get; set; }

    [Display(Name = "Posyandu")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public int PosyanduId { get; set; }

    [Display(Name = "LiLA (cm)")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Range(0, double.MaxValue, ErrorMessage = "{0} minimal {1}")]
    public double LingkarLenganAtas { get; set; }

    [Display(Name = "Tinggi Badan (cm)")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Range(0, double.MaxValue, ErrorMessage = "{0} minimal {1}")]
    public double TinggiBadan { get; set; }

    [Display(Name = "Berat Badan (Kg)")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Range(0, double.MaxValue, ErrorMessage = "{0} minimal {1}")]
    public double BeratBadan { get; set; }

    [Display(Name = "Tanggal Pengukuran")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public DateOnly TanggalUkur { get; set; }
}