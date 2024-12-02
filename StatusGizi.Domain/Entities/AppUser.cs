namespace StatusGizi.Domain.Entities;

public class AppUser
{
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;

    public int? OrangTuaId { get; set; }
    public int? KaderPosyanduId { get; set; }

    public OrangTua? OrangTua { get; set; }
    public KaderPosyandu? KaderPosyandu { get; set; }
}

public static class AppUserRoles
{
    public static readonly string Kader = "Kader";
    public static readonly string OrangTua = "OrangTua";
}