using System.ComponentModel.DataAnnotations;

namespace StatusGizi.Web.Models.KelurahanModels;

public class TambahVM
{
    [Display(Name = "Nama")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Nama { get; set; } = string.Empty;
}
