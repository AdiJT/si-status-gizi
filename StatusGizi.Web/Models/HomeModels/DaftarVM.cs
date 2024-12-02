using System.ComponentModel.DataAnnotations;

namespace StatusGizi.Web.Models.HomeModels;

public class DaftarVM
{
    [Display(Name = "Nama")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Nama { get; set; } = string.Empty;

    [Display(Name = "Posyandu")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public int PosyanduId { get; set; }

    [Display(Name = "User Name")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string UserName { get; set; } = string.Empty;

    [Display(Name = "Password")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Password { get; set; } = string.Empty;

    [Display(Name = "Konfirmasi Password")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Compare(nameof(Password), ErrorMessage = "{0} harus sama dengan {1}")]
    public string KonfirmasiPassword { get; set; } = string.Empty;
}
