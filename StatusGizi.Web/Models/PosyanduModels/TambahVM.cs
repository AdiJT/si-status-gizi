using System.ComponentModel.DataAnnotations;

namespace StatusGizi.Web.Models.PosyanduModels;

public class TambahVM
{
    [Display(Name = "Nama")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Nama { get; set; } = string.Empty;

    [Display(Name = "Desa/Keluarahan")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public int DesaKelurahanId { get; set; }
}
