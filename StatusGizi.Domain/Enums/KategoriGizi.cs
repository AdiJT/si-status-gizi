namespace StatusGizi.Domain.Enums;

public enum KategoriGizi
{
    GiziBuruk,  GiziKurang, GiziBaik, BerpotensiBerlebih, GiziBerlebih, Obesitas
}

public static class KategoriGiziExtension
{
    public static string Humanize(this KategoriGizi kategoriGizi) =>
        kategoriGizi switch
        {
            KategoriGizi.GiziBuruk => "Gizi Buruk",
            KategoriGizi.GiziKurang => "Gizi Kurang",
            KategoriGizi.GiziBaik => "Gizi Baik",
            KategoriGizi.BerpotensiBerlebih => "Berpotensi Berlebih",
            KategoriGizi.GiziBerlebih => "Gizi Berlebih",
            KategoriGizi.Obesitas => "Obesitas",
            _ => throw new NotImplementedException()
        };
}