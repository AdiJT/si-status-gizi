using Microsoft.EntityFrameworkCore;
using StatusGizi.Domain.Entities;
using StatusGizi.Domain.Enums;

namespace StatusGizi.Infrastructure.Database;

public static class ModelBuilderExtension
{
    public static ModelBuilder SeedingData(this ModelBuilder modelBuilder)
    {
        #region DesaKelurahan
        modelBuilder.Entity<DesaKelurahan>().HasData(
            new DesaKelurahan
            {
                Id = 1,
                Nama = "Beirafu",
            },
            new DesaKelurahan
            {
                Id = 2,
                Nama = "Berdao",
            },
            new DesaKelurahan
            {
                Id = 3,
                Nama = "Tulamalae",
            },
            new DesaKelurahan
            {
                Id = 4,
                Nama = "Umanen",
            }
        );
        #endregion

        #region Posyandu
        modelBuilder.Entity<Posyandu>().HasData(
            new
            {
                Id = 1,
                Nama = "Asparagus",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 2,
                Nama = "BTN",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 3,
                Nama = "Hali Nurak",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 4,
                Nama = "Kampung Jati",
                DesaKelurahanId = 2
            },
            new
            {
                Id = 5,
                Nama = "Ketapang",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 6,
                Nama = "Madrasah",
                DesaKelurahanId = 2
            },
            new
            {
                Id = 7,
                Nama = "Melati",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 8,
                Nama = "Nekafehan",
                DesaKelurahanId = 3
            },
            new
            {
                Id = 9,
                Nama = "Onoboi",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 10,
                Nama = "Sedap Malam",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 11,
                Nama = "Sesekoe A",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 12,
                Nama = "Sesekoe B",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 13,
                Nama = "Tatakiren",
                DesaKelurahanId = 2
            },
            new
            {
                Id = 14,
                Nama = "Toro",
                DesaKelurahanId = 3
            },
            new
            {
                Id = 15,
                Nama = "Tulamalae 1",
                DesaKelurahanId = 3
            },
            new
            {
                Id = 16,
                Nama = "Tulamalae 2",
                DesaKelurahanId = 3
            },
            new
            {
                Id = 17,
                Nama = "Wekatimun 1",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 18,
                Nama = "Wekatimun 2",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 19,
                Nama = "Wekatimun 3",
                DesaKelurahanId = 4
            }
        );
        #endregion

        #region OrangTua
        modelBuilder.Entity<OrangTua>().HasData(
            new
            {
                Id = 1,
                Nama = "VALENTINUS C.KIIK",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 2,
                Nama = "JULIUS S.ANDRADA",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 3,
                Nama = "ARSILIU NENOBAIS",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 4,
                Nama = "DAMIANUS LEKY",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 5,
                Nama = "DEFRI TAMPANI",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 6,
                Nama = "JULIUS D LAHERA",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 7,
                Nama = "DELVIANA MORUK",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 8,
                Nama = "OKTOVIANUS TANEO",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 9,
                Nama = "MUHAMAD SAVERIO",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 10,
                Nama = "KHANIFATUL",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 11,
                Nama = "JASMAN SEO",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 12,
                Nama = "RONALD",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 13,
                Nama = "MELKI SEDIK FAOT",
                DesaKelurahanId = 1
            }
        );
        #endregion

        #region Balita

        #endregion

        #region Pengecekan

        #endregion

        return modelBuilder;
    }
}
