namespace StatusGizi.Domain.Enums;

public enum JenisKelamin
{
    LakiLaki, Perempuan
}

public static class JenisKelaminExtension
{
    public static string Humanize(this JenisKelamin jenisKelamin) =>
        jenisKelamin switch
        {
            JenisKelamin.LakiLaki => "L",
            JenisKelamin.Perempuan => "P",
            _ => throw new NotImplementedException()
        };
}