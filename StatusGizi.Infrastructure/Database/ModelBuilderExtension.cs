using Microsoft.EntityFrameworkCore;
using StatusGizi.Domain.Entities;
using StatusGizi.Domain.Enums;

namespace StatusGizi.Infrastructure.Database;

public static class ModelBuilderExtension
{
    public static ModelBuilder SeedingData(this ModelBuilder modelBuilder)
    {
        var daftarStandarBeratBadanBawah24 = new[]
        {
            new StandarBeratMenurutBBTB
            {
                Id = 1,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 45,
                MedianBeratBadan = 2.4,
                SDMinus1 = 2.2,
                SDMinus2 = 2,
                SDMinus3 = 1.9,
                SDPlus1 = 2.7,
                SDPlus2 = 3,
                SDPlus3 = 3.3,
            }
        };

        var daftarStandarBeratBadan2460Bulan = new[]
        {
        };

        modelBuilder.Entity<StandarBeratMenurutBBTB>().HasData(daftarStandarBeratBadanBawah24);
        modelBuilder.Entity<StandarBeratMenurutBBTB>().HasData(daftarStandarBeratBadan2460Bulan);

        return modelBuilder;
    }
}
