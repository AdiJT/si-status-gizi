using System.ComponentModel.DataAnnotations;

namespace StatusGizi.Web.Models.HomeModels;

public class LoginVM
{
    [Display(Name = "User Name")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string UserName { get; set; } = string.Empty;

    [Display(Name = "Password")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;

    public required string ReturnUrl { get; set; }
}
