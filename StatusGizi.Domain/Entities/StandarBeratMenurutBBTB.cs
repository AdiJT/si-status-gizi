using StatusGizi.Domain.Enums;

namespace StatusGizi.Domain.Entities;

public class StandarBeratMenurutBBTB
{
    public int Id { get; set; }

    public KategoriUmur KategoriUmur { get; set; }
    public JenisKelamin JenisKelamin { get; set; }

    public double TinggiBadan { get; set; }

    public double SDMinus3 { get; set; }
    public double SDMinus2 { get; set; }
    public double SDMinus1 { get; set; }

    public double MedianBeratBadan { get; set; }

    public double SDPlus3 { get; set; }
    public double SDPlus2 { get; set; }
    public double SDPlus1 { get; set; }
}