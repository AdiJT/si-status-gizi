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
        modelBuilder.Entity<Balita>().HasData(
            new
            {
                NIK = "5306611607227754",
                Nama = "LEANDREY C.KIIK",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 07, 16),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 49d,
                OrangTuaId = 1
            }, 
            new
            {
                NIK = "5306610207221488",
                Nama = "LEANDER CHESTER ANDRADA",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 07, 2),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 2
            },
            new
            {
                NIK = "5306612306228330",
                Nama = "RAFLY JALEXA",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 06, 23),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 3
            },
            new
            {
                NIK = "5306612109211986",
                Nama = "SAMUEL A. LEKY",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 09, 21),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 3
            },
            new
            {
                NIK = "5306613009216892",
                Nama = "DERIL TAMPANI",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 09, 30),
                BeratBadanWaktuLahir = 3.1d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 3
            },
            new
            {
                NIK = "5306611509215054",
                Nama = "GAMALIEL DAVIN LAHERA",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 09, 15),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 3
            },
            new
            {
                NIK = "5306611608216534",
                Nama = "AGUSTINUS I. NITBANI",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 08, 16),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 3
            },
            new
            {
                NIK = "5306611708211553",
                Nama = "DIRGARIUS A.TANEO",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 08, 17),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 3
            },
            new
            {
                NIK = "5306611506221514",
                Nama = "KHAMALIK SAVERIO",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 06, 15),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 49d,
                OrangTuaId = 3
            },
            new
            {
                NIK = "5306612705226233",
                Nama = "MUH. SYAHKIRULLAH ALGHANI",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 05, 27),
                BeratBadanWaktuLahir = 3.2d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 3
            },
            new
            {
                NIK = "5306612105226289",
                Nama = "FARHAN ZAKY",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 05, 21),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 3
            },
            new
            {
                NIK = "5306610606224235",
                Nama = "SEAN",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 06, 06),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 46d,
                OrangTuaId = 3
            },
            new
            {
                NIK = "5306611505225327",
                Nama = "MEIDA AMELIA Y FAOT",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 06, 06),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 3
            }
        );
        #endregion

        #region Pengecekan

        #endregion

        return modelBuilder;
    }
}
