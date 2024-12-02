namespace StatusGizi.Domain.Entities;

public class KaderPosyandu
{
    public int Id { get; set; }
    public string Nama { get; set; }

    public Posyandu Posyandu { get; set; }
    public AppUser? AppUser { get; set; }
}
