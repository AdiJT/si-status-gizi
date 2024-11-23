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
            },
            new
            {
                Id = 14,
                Nama = "YUVEN SERAN",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 15,
                Nama = "PETRUS KAPITAN",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 16,
                Nama = "MISDA",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 17,
                Nama = "ADRIANUS IMPI",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 18,
                Nama = "GAUDENSIA N. TAEK",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 19,
                Nama = "NOBERTUS KLAU",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 20,
                Nama = "MARTINUS TEFLOPO",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 21,
                Nama = "MUSTOFA",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 22,
                Nama = "R. PRASONG",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 23,
                Nama = "HENDRIKUS LAISNESI",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 24,
                Nama = "ARI PANO",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 25,
                Nama = "RASID HANNS",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 26,
                Nama = "JUFRIANUS SERAN",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 27,
                Nama = "ADRIANUS LOROK",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 28,
                Nama = "MELFIANUS WALENG",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 29,
                Nama = "YEREMIA G.KABOSU",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 30,
                Nama = "JERIKSON E FAOT",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 31,
                Nama = "APOLINARIS AFEANPAH",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 32,
                Nama = "LINUS UN ARYANDI",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 33,
                Nama = "FLAVIANUS A. D. UN",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 34,
                Nama = "AGUSTINUS TALAN",
                DesaKelurahanId = 1
            },
            new
            {
                Id = 35,
                Nama = "JAMARIA NAMANG",
                DesaKelurahanId = 2
            },
            new
            {
                Id = 36,
                Nama = "HARI WADU",
                DesaKelurahanId = 2
            },
            new
            {
                Id = 37,
                Nama = "PAULUS PRAWIRA",
                DesaKelurahanId = 2
            },
            new
            {
                Id = 38,
                Nama = "IRFAN AMALO",
                DesaKelurahanId = 2
            },
            new
            {
                Id = 39,
                Nama = "KARLUS BEREMEO",
                DesaKelurahanId = 2
            },
            new
            {
                Id = 40,
                Nama = "JISMA",
                DesaKelurahanId = 2
            },
            new
            {
                Id = 41,
                Nama = "ERLIN KAMLASI",
                DesaKelurahanId = 2
            },
            new
            {
                Id = 42,
                Nama = "DIONISIUS NAHAK",
                DesaKelurahanId = 2
            },
            new
            {
                Id = 43,
                Nama = "SAHRUDIN",
                DesaKelurahanId = 2
            },
            new
            {
                Id = 44,
                Nama = "RANDI MANEK",
                DesaKelurahanId = 2
            },
            new
            {
                Id = 45,
                Nama = "SAVER TAEK",
                DesaKelurahanId = 2
            },


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
                OrangTuaId = 4
            },
            new
            {
                NIK = "5306613009216892",
                Nama = "DERIL TAMPANI",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 09, 30),
                BeratBadanWaktuLahir = 3.1d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 5
            },
            new
            {
                NIK = "5306611509215054",
                Nama = "GAMALIEL DAVIN LAHERA",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 09, 15),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 6
            },
            new
            {
                NIK = "5306611608216534",
                Nama = "AGUSTINUS I. NITBANI",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 08, 16),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 7
            },
            new
            {
                NIK = "5306611708211553",
                Nama = "DIRGARIUS A.TANEO",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 08, 17),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 8
            },
            new
            {
                NIK = "5306611506221514",
                Nama = "KHAMALIK SAVERIO",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 06, 15),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 49d,
                OrangTuaId = 9
            },
            new
            {
                NIK = "5306612705226233",
                Nama = "MUH. SYAHKIRULLAH ALGHANI",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 05, 27),
                BeratBadanWaktuLahir = 3.2d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 10
            },
            new
            {
                NIK = "5306612105226289",
                Nama = "FARHAN ZAKY",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 05, 21),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 11
            },
            new
            {
                NIK = "5306610606224235",
                Nama = "SEAN",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 06, 06),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 46d,
                OrangTuaId = 12
            },
            new
            {
                NIK = "5306611505225327",
                Nama = "MEIDA AMELIA Y FAOT",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 06, 06),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 13
            }
        );
        #endregion

        #region Pengecekan
        modelBuilder.Entity<Pengecekan>().HasData(
            new
            {
                Id = 1,
                TanggalPengecekan = new DateOnly(2022, 8, 15),
                BeratBadan = 5.3d,
                TinggiBadan = 52.9d,
                LingkarLenganAtas = 13d,
                KategoriGizi = KategoriGizi.Obesitas,
                BalitaNIK = "5306611607227754",
                PosyanduId = 1,
            },
            new
            {
                Id = 2,
                TanggalPengecekan = new DateOnly(2022, 8, 15),
                BeratBadan = 4.1d,
                TinggiBadan = 52.7d,
                LingkarLenganAtas = 11.8d,
                KategoriGizi = KategoriGizi.GiziBaik,
                BalitaNIK = "5306610207221488",
                PosyanduId = 1,
            },
            new
            {
                Id = 3,
                TanggalPengecekan = new DateOnly(2022, 8, 15),
                BeratBadan = 5.1d,
                TinggiBadan = 57.2d,
                LingkarLenganAtas = 11.5d,
                KategoriGizi = KategoriGizi.GiziBaik,
                BalitaNIK = "5306612306228330",
                PosyanduId = 1,
            },
            new
            {
                Id = 4,
                BalitaNIK = "5306612109211986",
                TanggalPengecekan = new DateOnly(2022, 8, 8),
                BeratBadan = 8.4d,
                TinggiBadan = 71.4d,
                LingkarLenganAtas = 15d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 10,
            },
            new
            {
                Id = 5,
                BalitaNIK = "5306613009216892",
                TanggalPengecekan = new DateOnly(2022, 8, 8),
                BeratBadan = 8.45d,
                TinggiBadan = 72.9d,
                LingkarLenganAtas = 13.5d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 10,
            },
            new
            {
                Id = 6,
                BalitaNIK = "5306611509215054",
                TanggalPengecekan = new DateOnly(2022, 8, 18),
                BeratBadan = 8.4d,
                TinggiBadan = 72.1d,
                LingkarLenganAtas = 14d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 7,
            },
            new
            {
                Id = 7,
                BalitaNIK = "5306611608216534",
                TanggalPengecekan = new DateOnly(2022, 8, 8),
                BeratBadan = 9.6d,
                TinggiBadan = 76.2d,
                LingkarLenganAtas = 14.2d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 10,
            },
            new
            {
                Id = 8,
                BalitaNIK = "5306611708211553",
                TanggalPengecekan = new DateOnly(2022, 8, 15),
                BeratBadan = 8d,
                TinggiBadan = 72d,
                LingkarLenganAtas = 12.4d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 1,
            },
            new
            {
                Id = 9,
                BalitaNIK = "5306611506221514",
                TanggalPengecekan = new DateOnly(2022, 8, 15),
                BeratBadan = 5.2d,
                TinggiBadan = 55.9d,
                LingkarLenganAtas = 15d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 1,
            },
            new
            {
                Id = 10,
                BalitaNIK = "5306612705226233",
                TanggalPengecekan = new DateOnly(2022, 8, 8),
                BeratBadan = 4.85d,
                TinggiBadan = 57.3d,
                LingkarLenganAtas = 0d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 10,
            },
            new
            {
                Id = 11,
                BalitaNIK = "5306612105226289",
                TanggalPengecekan = new DateOnly(2022, 8, 8),
                BeratBadan = 5.2d,
                TinggiBadan = 59.2d,
                LingkarLenganAtas = 14d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 10,
            },
            new
            {
                Id = 12,
                BalitaNIK = "5306610606224235",
                TanggalPengecekan = new DateOnly(2022, 8, 12),
                BeratBadan = 6.3d,
                TinggiBadan = 61.3d,
                LingkarLenganAtas = 14d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 5,
            },
            new
            {
                Id = 13,
                BalitaNIK = "5306611505225327",
                TanggalPengecekan = new DateOnly(2022, 8, 15),
                BeratBadan = 5.4d,
                TinggiBadan = 57.7d,
                LingkarLenganAtas = 13.2d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 1,
            },
            new
            {
                Id = 14,
                BalitaNIK = "5306611807227328",
                TanggalPengecekan = new DateOnly(2022, 8, 9),
                BeratBadan = 3.8d,
                TinggiBadan = 52.9d,
                LingkarLenganAtas = 11.7d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 6,
            },
            new
            {
                Id = 15,
                BalitaNIK = "5306610310212700",
                TanggalPengecekan = new DateOnly(2022, 8, 9),
                BeratBadan = 9.1d,
                TinggiBadan = 71.9d,
                LingkarLenganAtas = 15.5d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 6,
            },
            new
            {
                Id = 16,
                BalitaNIK = "5306612608217549",
                TanggalPengecekan = new DateOnly(2022, 8, 12),
                BeratBadan = 10.7d,
                TinggiBadan = 78d,
                LingkarLenganAtas = 15d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 4,
            },
            new
            {
                Id = 17,
                BalitaNIK = "5306611808214604",
                TanggalPengecekan = new DateOnly(2022, 8, 12),
                BeratBadan = 8.9d,
                TinggiBadan = 71.4d,
                LingkarLenganAtas = 16d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 4,
            },
            new
            {
                Id = 18,
                BalitaNIK = "5306611008217236",
                TanggalPengecekan = new DateOnly(2022, 8, 10),
                BeratBadan = 9.6d,
                TinggiBadan = 82.2d,
                LingkarLenganAtas = 14d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 13,
            },
            new
            {
                Id = 19,
                BalitaNIK = "5306612804228187",
                TanggalPengecekan = new DateOnly(2022, 8, 10),
                BeratBadan = 5.5d,
                TinggiBadan = 60.9d,
                LingkarLenganAtas = 13d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 13,
            },
            new
            {
                Id = 20,
                BalitaNIK = "5306612404221654",
                TanggalPengecekan = new DateOnly(2022, 8, 10),
                BeratBadan = 5.25d,
                TinggiBadan = 59.2d,
                LingkarLenganAtas = 12.5d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 13,
            },
            new
            {
                Id = 21,
                BalitaNIK = "5306610805228603",
                TanggalPengecekan = new DateOnly(2022, 8, 12),
                BeratBadan = 5.6d,
                TinggiBadan = 58.2d,
                LingkarLenganAtas = 0d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 4,
            },
            new
            {
                Id = 22,
                BalitaNIK = "5306610305228386",
                TanggalPengecekan = new DateOnly(2022, 8, 12),
                BeratBadan = 5.7d,
                TinggiBadan = 61.2d,
                LingkarLenganAtas = 0d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 4,
            },
            new
            {
                Id = 23,
                BalitaNIK = "5306611503229344",
                TanggalPengecekan = new DateOnly(2022, 8, 12),
                BeratBadan = 6.7d,
                TinggiBadan = 63d,
                LingkarLenganAtas = 14.5d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 4,
            }
        );
        #endregion

        return modelBuilder;
    }
}
