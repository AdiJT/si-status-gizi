using StatusGizi.Domain.Commons;
using StatusGizi.Domain.Entities;

namespace StatusGizi.Web.Authentication;

public interface ISignInManager
{
    Task<Result> SignIn(string userName, string password);
    Task<Result> SignOut();
    Task<AppUser?> GetUser();
}