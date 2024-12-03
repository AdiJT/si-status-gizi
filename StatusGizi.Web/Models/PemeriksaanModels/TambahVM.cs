using StatusGizi.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace StatusGizi.Web.Models.PemeriksaanModels;

public class TambahVM
{
    [Display(Name = "Balita")]
    [Required(ErrorMessage = "{0} harus dipilih")]
    public string NIK { get; set; } = string.Empty;

    [Display(Name = "Posyandu")]
    [Required(ErrorMessage = "{0} harus dipilih")]
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