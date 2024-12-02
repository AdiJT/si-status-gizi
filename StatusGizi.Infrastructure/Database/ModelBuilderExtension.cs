using Microsoft.AspNetCore.Identity;
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
        var daftarOrangTua = new[]
        {
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
            new
            {
                Id = 46,
                Nama = "AGAPITUS UN",
                DesaKelurahanId = 3
            },
            new
            {
                Id = 47,
                Nama = "PEDRO DOS REIS",
                DesaKelurahanId = 3
            },
            new
            {
                Id = 48,
                Nama = "ALFRED BESSIE",
                DesaKelurahanId = 3
            },
            new
            {
                Id = 49,
                Nama = "JHON NAHAK",
                DesaKelurahanId = 3
            },
            new
            {
                Id = 50,
                Nama = "AMINUDIN",
                DesaKelurahanId = 3
            },
            new
            {
                Id = 51,
                Nama = "GERFAS LOLOMSAIT",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 52,
                Nama = "",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 53,
                Nama = "YOHANES KENJAM",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 54,
                Nama = "MANUEL N",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 55,
                Nama = "SONNY LY RAU",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 56,
                Nama = "YOHANES FAHIK",
                DesaKelurahanId = 3
            },
            new
            {
                Id = 57,
                Nama = "STEFANUS NAIMUNI",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 58,
                Nama = "MARIA A. SEKAB",
                DesaKelurahanId = 3
            },
            new
            {
                Id = 59,
                Nama = "YASINTUS NAHAK",
                DesaKelurahanId = 3
            },
            new
            {
                Id = 60,
                Nama = "SUSAN NAES",
                DesaKelurahanId = 3
            },
            new
            {
                Id = 61,
                Nama = "DIONISIUS MAU",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 62,
                Nama = "AGUSTINO DE. J",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 63,
                Nama = "YASINTUS KOFI",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 64,
                Nama = "I PUTU DEDI SETIAWAN",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 65,
                Nama = "FLORA",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 66,
                Nama = "MUHAMMAD ISA F USI",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 67,
                Nama = "FRANSISKUS PONGKI SERAN",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 68,
                Nama = "ADELINO O. SOARES",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 69,
                Nama = "JAFRIANUS NAIFATIN",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 70,
                Nama = "FRANSISKUS TRINDADE",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 71,
                Nama = "SON UKAT",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 72,
                Nama = "LONGGINUS LOE",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 73,
                Nama = "UKAT",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 74,
                Nama = "GERFAS LOLOMSAIT",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 75,
                Nama = "",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 76,
                Nama = "YOHANES KENJAM",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 77,
                Nama = "MANUEL N",
                DesaKelurahanId = 4
            },
            new
            {
                Id = 78,
                Nama = "SONNY LY RAU",
                DesaKelurahanId = 4
            }
        };

        modelBuilder.Entity<OrangTua>().HasData(daftarOrangTua);
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
                TanggalLahir = new DateOnly(2021, 09, 21),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 4
            },
            new
            {
                NIK = "5306613009216892",
                Nama = "DERIL TAMPANI",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2021, 09, 30),
                BeratBadanWaktuLahir = 3.1d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 5
            },
            new
            {
                NIK = "5306611509215054",
                Nama = "GAMALIEL DAVIN LAHERA",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2021, 09, 15),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 6
            },
            new
            {
                NIK = "5306611608216534",
                Nama = "AGUSTINUS I. NITBANI",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2021, 08, 16),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 7
            },
            new
            {
                NIK = "5306611708211553",
                Nama = "DIRGARIUS A.TANEO",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2021, 08, 17),
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
            },
            new
            {
                NIK = "5306611807227328",
                Nama = "ADRIELO HABU PAH",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 07, 18),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 35
            },
            new
            {
                NIK = "5306610310212700",
                Nama = "GIRLAND WADU",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 10, 03),
                BeratBadanWaktuLahir = 2.9d,
                TinggiBadanWaktuLahir = 49d,
                OrangTuaId = 36
            },
            new
            {
                NIK = "5306612608217549",
                Nama = "AGUSTINUS H. PRAWIRA",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2021, 08, 26),
                BeratBadanWaktuLahir = 3.4d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 37
            },
            new
            {
                NIK = "5306611808214604",
                Nama = "ABIMAE AMALO",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2021, 08, 18),
                BeratBadanWaktuLahir = 2.8d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 38
            },
            new
            {
                NIK = "5306611008217236",
                Nama = "AGUS R. BEREMEO",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 08, 10),
                BeratBadanWaktuLahir = 2.9d,
                TinggiBadanWaktuLahir = 49d,
                OrangTuaId = 39
            },
            new
            {
                NIK = "5306612804228187",
                Nama = "KRISTIAN PARERA",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 04, 28),
                BeratBadanWaktuLahir = 3.1d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 40
            },
            new
            {
                NIK = "5306612404221654",
                Nama = "ALEXANDRIO Z. KEFI",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 04, 24),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 41
            },
            new
            {
                NIK = "5306610805228603",
                Nama = "ARSENIUS NAHAK",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 05, 08),
                BeratBadanWaktuLahir = 2.6d,
                TinggiBadanWaktuLahir = 49d,
                OrangTuaId = 42
            },
            new
            {
                NIK = "5306610305228386",
                Nama = "MUHAMAD ARHAM SYAKAL",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 05, 03),
                BeratBadanWaktuLahir = 2.8d,
                TinggiBadanWaktuLahir = 49d,
                OrangTuaId = 43
            },
            new
            {
                NIK = "5306611503229344",
                Nama = "CANELO ALVARES MANEK",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 03, 15),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 44
            },
            new
            {
                NIK = "5306611607222447",
                Nama = "ALEXSIUS EL KAPITAN",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 07, 16),
                BeratBadanWaktuLahir = 2.6d,
                TinggiBadanWaktuLahir = 49d,
                OrangTuaId = 46
            },
            new
            {
                NIK = "5306611106228326",
                Nama = "VASCO PEREIRA REIS",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 06, 11),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 49d,
                OrangTuaId = 47
            },
            new
            {
                NIK = "5306610807221629",
                Nama = "DANTE A. BESSIE",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 07, 8),
                BeratBadanWaktuLahir = 3.2d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 48
            },
            new
            {
                NIK = "5306611410216937",
                Nama = "KORNELIS D. NAHAK",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2021, 10, 14),
                BeratBadanWaktuLahir = 2.8d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 49
            },
            new
            {
                NIK = "5306612709216413",
                Nama = "ILHAM BAHMID",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2021, 9, 27),
                BeratBadanWaktuLahir = 3.1d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 50
            },
            new
            {
                NIK = "5306611907229365",
                Nama = "GRACIANO LOLOMSAIT",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 7, 19),
                BeratBadanWaktuLahir = 2.6d,
                TinggiBadanWaktuLahir = 49d,
                OrangTuaId = 51
            },
            new
            {
                NIK = "5306612807224014",
                Nama = "AGNESIA TIARA SIN MAU",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 7, 28),
                BeratBadanWaktuLahir = 2.6d,
                TinggiBadanWaktuLahir = 45d,
                OrangTuaId = 52
            },
            new
            {
                NIK = "5303244310870001",
                Nama = "ALANA FERNANDES",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 7, 18),
                BeratBadanWaktuLahir = 3.1d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 53
            },
            new
            {
                NIK = "5304214606940004",
                Nama = "ALFIAN E. N",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 7, 1),
                BeratBadanWaktuLahir = 2.9d,
                TinggiBadanWaktuLahir = 49d,
                OrangTuaId = 54
            },
            new
            {
                NIK = "5306611706223451",
                Nama = "GIBRAN M. LY RATU",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 6, 17),
                BeratBadanWaktuLahir = 3.5d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 55
            },
            new
            {
                NIK = "5306612404198011",
                Nama = "ARYANTO ENYSIUS FAHIK",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2019, 4, 24),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 56
            },
            new
            {
                NIK = "5306616807201646",
                Nama = "AGATHA L.F.NAIMUNI",
                JenisKelamin = JenisKelamin.Perempuan,
                TanggalLahir = new DateOnly(2020, 7, 28),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 49d,
                OrangTuaId = 57
            },
            new
            {
                NIK = "5306611708215871",
                Nama = "GABRIEL RADINGA",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2021, 8, 17),
                BeratBadanWaktuLahir = 2.5d,
                TinggiBadanWaktuLahir = 49d,
                OrangTuaId = 58
            },
            new
            {
                NIK = "5306612509215198",
                Nama = "VARELIO NAHAK",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2021, 9, 25),
                BeratBadanWaktuLahir = 2.7d,
                TinggiBadanWaktuLahir = 49d,
                OrangTuaId = 59
            },
            new
            {
                NIK = "5306612601222598",
                Nama = "GILBERT BANUNAEK",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 1, 26),
                BeratBadanWaktuLahir = 3.2d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 60
            },
            new
            {
                NIK = "5306611707228503",
                Nama = "JOAKIM JOVANO MAU",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 7, 17),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 61
            },
            new
            {
                NIK = "5306610306226179",
                Nama = "MARIA RASTIANA DE.J",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 6, 3),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 62
            },
            new
            {
                NIK = "5306612104224910",
                Nama = "APRILIO ADEN KOFI",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 4, 21),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 63
            },
            new
            {
                NIK = "5306612303229952",
                Nama = "KOMANG B.D.S.P",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 3, 23),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 64
            },
            new
            {
                NIK = "5306611401221414",
                Nama = "JEREMI TURNIP",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 1, 14),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 65
            },
            new
            {
                NIK = "5306610310217582",
                Nama = "MUHAMMAD SYFID",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2021, 10, 3),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 66
            },
            new
            {
                NIK = "5306612405226168",
                Nama = "ALBERT SERAN",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 5, 24),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 67
            },
            new
            {
                NIK = "5306610311217965",
                Nama = "MIKHAEL O. SOARES",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2021, 11, 3),
                BeratBadanWaktuLahir = 3.1d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 68
            },
            new
            {
                NIK = "5306612609215986",
                Nama = "GILBERT NAIFATIN",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2021, 9, 26),
                BeratBadanWaktuLahir = 3.1d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 69
            },
            new
            {
                NIK = "5306613103226645",
                Nama = "ANTONIO TRINDADE DA COSTA",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 3, 31),
                BeratBadanWaktuLahir = 3d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 70
            },
            new
            {
                NIK = "5306611502224363",
                Nama = "DAFA UKAT",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2022, 2, 15),
                BeratBadanWaktuLahir = 2.5d,
                TinggiBadanWaktuLahir = 49d,
                OrangTuaId = 71
            },
            new
            {
                NIK = "5306612010213287",
                Nama = "EDWARD F. C. LOE",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2021, 10, 20),
                BeratBadanWaktuLahir = 2.8d,
                TinggiBadanWaktuLahir = 48d,
                OrangTuaId = 72
            },
            new
            {
                NIK = "5306612907215730",
                Nama = "JESON UKAT",
                JenisKelamin = JenisKelamin.LakiLaki,
                TanggalLahir = new DateOnly(2021, 7, 29),
                BeratBadanWaktuLahir = 3.1d,
                TinggiBadanWaktuLahir = 50d,
                OrangTuaId = 73
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
                TanggalPengecekan = new DateOnly(2021, 8, 9),
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
                TanggalPengecekan = new DateOnly(2021, 8, 10),
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
            },
            new
            {
                Id = 24,
                BalitaNIK = "5306611607222447",
                TanggalPengecekan = new DateOnly(2022, 8, 11),
                BeratBadan = 4.2d,
                TinggiBadan = 53.5d,
                LingkarLenganAtas = 0d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 16,
            },
            new
            {
                Id = 25,
                BalitaNIK = "5306611106228326",
                TanggalPengecekan = new DateOnly(2022, 8, 8),
                BeratBadan = 6.3d,
                TinggiBadan = 63d,
                LingkarLenganAtas = 0d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 14,
            },
            new
            {
                Id = 26,
                BalitaNIK = "5306610807221629",
                TanggalPengecekan = new DateOnly(2022, 8, 11),
                BeratBadan = 4.8d,
                TinggiBadan = 58.5d,
                LingkarLenganAtas = 0d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 16,
            },
            new
            {
                Id = 27,
                BalitaNIK = "5306611410216937",
                TanggalPengecekan = new DateOnly(2021, 8, 16),
                BeratBadan = 7.5d,
                TinggiBadan = 71.8d,
                LingkarLenganAtas = 12.5d,
                KategoriGizi = KategoriGizi.GiziKurang,
                PosyanduId = 8,
            },
            new
            {
                Id = 28,
                BalitaNIK = "5306612709216413",
                TanggalPengecekan = new DateOnly(2021, 8, 12),
                BeratBadan = 9.4d,
                TinggiBadan = 72.3d,
                LingkarLenganAtas = 14.5d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 15,
            },
            new
            {
                Id = 29,
                BalitaNIK = "5306611907229365",
                TanggalPengecekan = new DateOnly(2022, 8, 5),
                BeratBadan = 4.7d,
                TinggiBadan = 57d,
                LingkarLenganAtas = 0d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 17,
            },
            new
            {
                Id = 30,
                BalitaNIK = "5306612807224014",
                TanggalPengecekan = new DateOnly(2022, 8, 19),
                BeratBadan = 3.6d,
                TinggiBadan = 51d,
                LingkarLenganAtas = 0d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 9,
            },
            new
            {
                Id = 31,
                BalitaNIK = "5303244310870001",
                TanggalPengecekan = new DateOnly(2022, 8, 18),
                BeratBadan = 4.1d,
                TinggiBadan = 53.2d,
                LingkarLenganAtas = 0d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 12,
            },
            new
            {
                Id = 32,
                BalitaNIK = "5304214606940004",
                TanggalPengecekan = new DateOnly(2022, 8, 18),
                BeratBadan = 4.3d,
                TinggiBadan = 53.4d,
                LingkarLenganAtas = 0d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 12,
            },
            new
            {
                Id = 33,
                BalitaNIK = "5306611706223451",
                TanggalPengecekan = new DateOnly(2022, 8, 5),
                BeratBadan = 5.1d,
                TinggiBadan = 55.8d,
                LingkarLenganAtas = 0d,
                KategoriGizi = KategoriGizi.GiziBaik,
                PosyanduId = 17,
            },
            new
            {
                Id = 34,
                BalitaNIK = "5306612404198011",
                TanggalPengecekan = new DateOnly(2022, 8, 11),
                BeratBadan = 9d,
                TinggiBadan = 88d,
                LingkarLenganAtas = 14d,
                KategoriGizi = KategoriGizi.GiziBuruk,
                PosyanduId = 16,
            },
            new
            {
                Id = 35,
                BalitaNIK = "5306616807201646",
                TanggalPengecekan = new DateOnly(2022, 8, 12),
                BeratBadan = 7.3d,
                TinggiBadan = 77d,
                LingkarLenganAtas = 13d,
                KategoriGizi = KategoriGizi.GiziBuruk,
                PosyanduId = 19,
            },
            new
            {
                Id = 36,
                BalitaNIK = "5306611708215871",
                TanggalPengecekan = new DateOnly(2022, 8, 12),
                BeratBadan = 6.2d,
                TinggiBadan = 71.2d,
                LingkarLenganAtas = 13d,
                KategoriGizi = KategoriGizi.GiziBuruk,
                PosyanduId = 15,
            },
            new
            {
                Id = 37,
                BalitaNIK = "5306612509215198",
                TanggalPengecekan = new DateOnly(2022, 8, 12),
                BeratBadan = 8.1d,
                TinggiBadan = 65.3d,
                LingkarLenganAtas = 14d,
                KategoriGizi = KategoriGizi.BerpotensiBerlebih,
                PosyanduId = 15,
            },
            new
            {
                Id = 38,
                BalitaNIK = "5306612509215198",
                TanggalPengecekan = new DateOnly(2022, 8, 12),
                BeratBadan = 8.1d,
                TinggiBadan = 64.7d,
                LingkarLenganAtas = 15d,
                KategoriGizi = KategoriGizi.BerpotensiBerlebih,
                PosyanduId = 15,
            },
            new
            {
                Id = 39,
                BalitaNIK = "5306611707228503",
                TanggalPengecekan = new DateOnly(2022, 8, 19),
                BeratBadan = 5.1d,
                TinggiBadan = 54.3d,
                LingkarLenganAtas = 0d,
                KategoriGizi = KategoriGizi.BerpotensiBerlebih,
                PosyanduId = 15,
            },
            new
            {
                Id = 40,
                BalitaNIK = "5306610306226179",
                TanggalPengecekan = new DateOnly(2022, 8, 9),
                BeratBadan = 5.2d,
                TinggiBadan = 55.3d,
                LingkarLenganAtas = 15d,
                KategoriGizi = KategoriGizi.BerpotensiBerlebih,
                PosyanduId = 11,
            },
            new
            {
                Id = 41,
                BalitaNIK = "5306612104224910",
                TanggalPengecekan = new DateOnly(2022, 8, 5),
                BeratBadan = 6.8d,
                TinggiBadan = 60.8d,
                LingkarLenganAtas = 0d,
                KategoriGizi = KategoriGizi.BerpotensiBerlebih,
                PosyanduId = 17,
            },
            new
            {
                Id = 42,
                BalitaNIK = "5306612303229952",
                TanggalPengecekan = new DateOnly(2022, 8, 9),
                BeratBadan = 8.9d,
                TinggiBadan = 66.3d,
                LingkarLenganAtas = 19d,
                KategoriGizi = KategoriGizi.BerpotensiBerlebih,
                PosyanduId = 9,
            },
            new
            {
                Id = 43,
                BalitaNIK = "5306611401221414",
                TanggalPengecekan = new DateOnly(2022, 8, 8),
                BeratBadan = 9.5d,
                TinggiBadan = 70d,
                LingkarLenganAtas = 17d,
                KategoriGizi = KategoriGizi.BerpotensiBerlebih,
                PosyanduId = 2,
            },
            new
            {
                Id = 44,
                BalitaNIK = "5306610310217582",
                TanggalPengecekan = new DateOnly(2022, 8, 15),
                BeratBadan = 10d,
                TinggiBadan = 70d,
                LingkarLenganAtas = 14d,
                KategoriGizi = KategoriGizi.GiziBerlebih,
                PosyanduId = 18,
            },
            new
            {
                Id = 45,
                BalitaNIK = "5306610310217582",
                TanggalPengecekan = new DateOnly(2022, 8, 20),
                BeratBadan = 6.9d,
                TinggiBadan = 58d,
                LingkarLenganAtas = 14.4d,
                KategoriGizi = KategoriGizi.GiziBerlebih,
                PosyanduId = 3,
            },
            new
            {
                Id = 46,
                BalitaNIK = "5306610311217965",
                TanggalPengecekan = new DateOnly(2022, 8, 19),
                BeratBadan = 10d,
                TinggiBadan = 69d,
                LingkarLenganAtas = 14d,
                KategoriGizi = KategoriGizi.GiziBerlebih,
                PosyanduId = 9,
            },
            new
            {
                Id = 47,
                BalitaNIK = "5306612609215986",
                TanggalPengecekan = new DateOnly(2022, 8, 18),
                BeratBadan = 7.3d,
                TinggiBadan = 72.8d,
                LingkarLenganAtas = 14d,
                KategoriGizi = KategoriGizi.GiziKurang,
                PosyanduId = 12,
            },
            new
            {
                Id = 48,
                BalitaNIK = "5306613103226645",
                TanggalPengecekan = new DateOnly(2022, 8, 9),
                BeratBadan = 5.5d,
                TinggiBadan = 62d,
                LingkarLenganAtas = 13d,
                KategoriGizi = KategoriGizi.GiziKurang,
                PosyanduId = 11,
            },
            new
            {
                Id = 49,
                BalitaNIK = "5306611502224363",
                TanggalPengecekan = new DateOnly(2022, 8, 5),
                BeratBadan = 5.8d,
                TinggiBadan = 63.7d,
                LingkarLenganAtas = 0d,
                KategoriGizi = KategoriGizi.GiziKurang,
                PosyanduId = 17,
            },
            new
            {
                Id = 50,
                BalitaNIK = "5306612010213287",
                TanggalPengecekan = new DateOnly(2022, 8, 15),
                BeratBadan = 6.8d,
                TinggiBadan = 68.8d,
                LingkarLenganAtas = 13d,
                KategoriGizi = KategoriGizi.GiziKurang,
                PosyanduId = 18,
            },
            new
            {
                Id = 51,
                BalitaNIK = "5306612907215730",
                TanggalPengecekan = new DateOnly(2022, 8, 8),
                BeratBadan = 7.8d,
                TinggiBadan = 74d,
                LingkarLenganAtas = 14d,
                KategoriGizi = KategoriGizi.GiziKurang,
                PosyanduId = 2,
            }


        );
        #endregion

        #region StandarBeratMenurutBBTB
        modelBuilder.Entity<StandarBeratMenurutBBTB>().HasData(
            new
            {
                Id = 1,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 45d,
                SDMinus3 = 1.9d,
                SDMinus2 = 2d,
                SDMinus1 = 2.2d,
                MedianBeratBadan = 2.4d,
                SDPlus1 = 2.7d,
                SDPlus2 = 3d,
                SDPlus3 = 3.3d,
            },
            new
            {
                Id = 2,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 45.5d,
                SDMinus3 = 1.9d,
                SDMinus2 = 2.1d,
                SDMinus1 = 2.3d,
                MedianBeratBadan = 2.5d,
                SDPlus1 = 2.8d,
                SDPlus2 = 3.1d,
                SDPlus3 = 3.4d,
            },
            new
            {
                Id = 3,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 46d,
                SDMinus3 = 2.0d,
                SDMinus2 = 2.2d,
                SDMinus1 = 2.4d,
                MedianBeratBadan = 2.6d,
                SDPlus1 = 2.9d,
                SDPlus2 = 3.1d,
                SDPlus3 = 3.5d,
            },
            new
            {
                Id = 4,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 46.5d,
                SDMinus3 = 2.1d,
                SDMinus2 = 2.3d,
                SDMinus1 = 2.5d,
                MedianBeratBadan = 2.7d,
                SDPlus1 = 3.0d,
                SDPlus2 = 3.2d,
                SDPlus3 = 3.6d,
            },
            new
            {
                Id = 5,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 47d,
                SDMinus3 = 2.1d,
                SDMinus2 = 2.3d,
                SDMinus1 = 2.5d,
                MedianBeratBadan = 2.8d,
                SDPlus1 = 3.0d,
                SDPlus2 = 3.3d,
                SDPlus3 = 3.7d,
            },
            new
            {
                Id = 6,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 47.5d,
                SDMinus3 = 2.2d,
                SDMinus2 = 2.4d,
                SDMinus1 = 2.6d,
                MedianBeratBadan = 2.9d,
                SDPlus1 = 3.1d,
                SDPlus2 = 3.4d,
                SDPlus3 = 3.8d,
            },
            new
            {
                Id = 7,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 48d,
                SDMinus3 = 2.3d,
                SDMinus2 = 2.5d,
                SDMinus1 = 2.7d,
                MedianBeratBadan = 2.9d,
                SDPlus1 = 3.2d,
                SDPlus2 = 3.6d,
                SDPlus3 = 3.9d,
            },
            new
            {
                Id = 8,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 48.5d,
                SDMinus3 = 2.3d,
                SDMinus2 = 2.6d,
                SDMinus1 = 2.8d,
                MedianBeratBadan = 3d,
                SDPlus1 = 3.2d,
                SDPlus2 = 3.7d,
                SDPlus3 = 4d,
            },
            new
            {
                Id = 9,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 49d,
                SDMinus3 = 2.4d,
                SDMinus2 = 2.6d,
                SDMinus1 = 2.9d,
                MedianBeratBadan = 3.1d,
                SDPlus1 = 3.4d,
                SDPlus2 = 3.8d,
                SDPlus3 = 4.2d,
            },
            new
            {
                Id = 10,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 49.5d,
                SDMinus3 = 2.5d,
                SDMinus2 = 2.7d,
                SDMinus1 = 3.0d,
                MedianBeratBadan = 3.2d,
                SDPlus1 = 3.5d,
                SDPlus2 = 3.9d,
                SDPlus3 = 4.3d,
            },
            new
            {
                Id = 11,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 50d,
                SDMinus3 = 2.6d,
                SDMinus2 = 2.8d,
                SDMinus1 = 3.0d,
                MedianBeratBadan = 3.3d,
                SDPlus1 = 3.6d,
                SDPlus2 = 4.0d,
                SDPlus3 = 4.4d,
            },
            new
            {
                Id = 12,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 50.5d,
                SDMinus3 = 2.7d,
                SDMinus2 = 2.9d,
                SDMinus1 = 3.1d,
                MedianBeratBadan = 3.4d,
                SDPlus1 = 3.8d,
                SDPlus2 = 4.1d,
                SDPlus3 = 4.5d,
            },
            new
            {
                Id = 13,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 51d,
                SDMinus3 = 2.7d,
                SDMinus2 = 3d,
                SDMinus1 = 3.2d,
                MedianBeratBadan = 3.5d,
                SDPlus1 = 3.9d,
                SDPlus2 = 4.2d,
                SDPlus3 = 4.7d,
            },
            new
            {
                Id = 14,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 51.5d,
                SDMinus3 = 2.8d,
                SDMinus2 = 3.1d,
                SDMinus1 = 3.3d,
                MedianBeratBadan = 3.6d,
                SDPlus1 = 4d,
                SDPlus2 = 4.4d,
                SDPlus3 = 4.8d,
            },
            new
            {
                Id = 15,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 52d,
                SDMinus3 = 2.9d,
                SDMinus2 = 3.2d,
                SDMinus1 = 3.5d,
                MedianBeratBadan = 3.8d,
                SDPlus1 = 4.1d,
                SDPlus2 = 4.5d,
                SDPlus3 = 5d,
            },
            new
            {
                Id = 16,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 52.5d,
                SDMinus3 = 3d,
                SDMinus2 = 3.3d,
                SDMinus1 = 3.6d,
                MedianBeratBadan = 3.9d,
                SDPlus1 = 4.2d,
                SDPlus2 = 4.6d,
                SDPlus3 = 5.1d,
            },
            new
            {
                Id = 17,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 53d,
                SDMinus3 = 3.1d,
                SDMinus2 = 3.4d,
                SDMinus1 = 3.7d,
                MedianBeratBadan = 4d,
                SDPlus1 = 4.4d,
                SDPlus2 = 4.8d,
                SDPlus3 = 5.3d,
            },
            new
            {
                Id = 18,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 53.5d,
                SDMinus3 = 3.2d,
                SDMinus2 = 3.5d,
                SDMinus1 = 3.8d,
                MedianBeratBadan = 4.1d,
                SDPlus1 = 4.5d,
                SDPlus2 = 4.9d,
                SDPlus3 = 5.4d,
            },
            new
            {
                Id = 19,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 54d,
                SDMinus3 = 3.3d,
                SDMinus2 = 3.6d,
                SDMinus1 = 3.9d,
                MedianBeratBadan = 4.3d,
                SDPlus1 = 4.7d,
                SDPlus2 = 5.1d,
                SDPlus3 = 5.6d,
            },
            new
            {
                Id = 20,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 54.5d,
                SDMinus3 = 3.4d,
                SDMinus2 = 3.7d,
                SDMinus1 = 4d,
                MedianBeratBadan = 4.4d,
                SDPlus1 = 4.8d,
                SDPlus2 = 5.3d,
                SDPlus3 = 5.8d,
            },
            new
            {
                Id = 21,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 55d,
                SDMinus3 = 3.6d,
                SDMinus2 = 3.8d,
                SDMinus1 = 4.2d,
                MedianBeratBadan = 4.5d,
                SDPlus1 = 5d,
                SDPlus2 = 5.4d,
                SDPlus3 = 6d,
            },
            new
            {
                Id = 22,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 55.5d,
                SDMinus3 = 3.7d,
                SDMinus2 = 4d,
                SDMinus1 = 4.3d,
                MedianBeratBadan = 4.7d,
                SDPlus1 = 5.1d,
                SDPlus2 = 5.6d,
                SDPlus3 = 6.1d,
            },
            new
            {
                Id = 23,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 56d,
                SDMinus3 = 3.8d,
                SDMinus2 = 4.1d,
                SDMinus1 = 4.4d,
                MedianBeratBadan = 4.8d,
                SDPlus1 = 5.3d,
                SDPlus2 = 5.8d,
                SDPlus3 = 6.3d,
            },
            new
            {
                Id = 24,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 56.5d,
                SDMinus3 = 3.9d,
                SDMinus2 = 4.2d,
                SDMinus1 = 4.6d,
                MedianBeratBadan = 5d,
                SDPlus1 = 5.4d,
                SDPlus2 = 5.9d,
                SDPlus3 = 6.5d,
            },
            new
            {
                Id = 35,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 57d,
                SDMinus3 = 4d,
                SDMinus2 = 4.3d,
                SDMinus1 = 4.7d,
                MedianBeratBadan = 5.1d,
                SDPlus1 = 5.6d,
                SDPlus2 = 6.1d,
                SDPlus3 = 6.7d,
            },
            new
            {
                Id = 36,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 57.5d,
                SDMinus3 = 4.1d,
                SDMinus2 = 4.5d,
                SDMinus1 = 4.9d,
                MedianBeratBadan = 5.3d,
                SDPlus1 = 5.7d,
                SDPlus2 = 6.3d,
                SDPlus3 = 6.9d,
            },
            new
            {
                Id = 37,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 58d,
                SDMinus3 = 4.3d,
                SDMinus2 = 4.6d,
                SDMinus1 = 5d,
                MedianBeratBadan = 5.4d,
                SDPlus1 = 5.9d,
                SDPlus2 = 6.4d,
                SDPlus3 = 7.1d,
            },
            new
            {
                Id = 38,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 58.5d,
                SDMinus3 = 4.4d,
                SDMinus2 = 4.7d,
                SDMinus1 = 5.1d,
                MedianBeratBadan = 5.6d,
                SDPlus1 = 6.1d,
                SDPlus2 = 6.6d,
                SDPlus3 = 7.2d,
            },
            new
            {
                Id = 39,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 59d,
                SDMinus3 = 4.5d,
                SDMinus2 = 4.8d,
                SDMinus1 = 5.3d,
                MedianBeratBadan = 5.7d,
                SDPlus1 = 6.2d,
                SDPlus2 = 6.8d,
                SDPlus3 = 7.4d,
            },
            new
            {
                Id = 40,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 59.5d,
                SDMinus3 = 4.6d,
                SDMinus2 = 5d,
                SDMinus1 = 5.4d,
                MedianBeratBadan = 5.9d,
                SDPlus1 = 6.4d,
                SDPlus2 = 7d,
                SDPlus3 = 7.6d,
            },
            new
            {
                Id = 41,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 60d,
                SDMinus3 = 4.7d,
                SDMinus2 = 5.1d,
                SDMinus1 = 5.5d,
                MedianBeratBadan = 6d,
                SDPlus1 = 6.5d,
                SDPlus2 = 7.1d,
                SDPlus3 = 7.8d,
            },
            new
            {
                Id = 42,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 60.5d,
                SDMinus3 = 4.8d,
                SDMinus2 = 5.2d,
                SDMinus1 = 5.6d,
                MedianBeratBadan = 6.1d,
                SDPlus1 = 6.7d,
                SDPlus2 = 7.3d,
                SDPlus3 = 8d,
            },
            new
            {
                Id = 43,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 61d,
                SDMinus3 = 4.9d,
                SDMinus2 = 5.3d,
                SDMinus1 = 5.8d,
                MedianBeratBadan = 6.3d,
                SDPlus1 = 6.8d,
                SDPlus2 = 7.4d,
                SDPlus3 = 8.1d,
            },
            new
            {
                Id = 44,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 61.5d,
                SDMinus3 = 5d,
                SDMinus2 = 5.4d,
                SDMinus1 = 5.9d,
                MedianBeratBadan = 6.4d,
                SDPlus1 = 7d,
                SDPlus2 = 7.6d,
                SDPlus3 = 8.3d,
            },
            new
            {
                Id = 45,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 62d,
                SDMinus3 = 5.1d,
                SDMinus2 = 5.6d,
                SDMinus1 = 6d,
                MedianBeratBadan = 6.5d,
                SDPlus1 = 7.1d,
                SDPlus2 = 7.7d,
                SDPlus3 = 8.5d,
            },
            new
            {
                Id = 46,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 62.5d,
                SDMinus3 = 5.2d,
                SDMinus2 = 5.7d,
                SDMinus1 = 6.1d,
                MedianBeratBadan = 6.7d,
                SDPlus1 = 7.2d,
                SDPlus2 = 7.9d,
                SDPlus3 = 8.6d,
            },
            new
            {
                Id = 47,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 63d,
                SDMinus3 = 5.3d,
                SDMinus2 = 5.8d,
                SDMinus1 = 6.2d,
                MedianBeratBadan = 6.8d,
                SDPlus1 = 7.4d,
                SDPlus2 = 8d,
                SDPlus3 = 8.8d,
            },
            new
            {
                Id = 48,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 63.5d,
                SDMinus3 = 5.4d,
                SDMinus2 = 5.9d,
                SDMinus1 = 6.4d,
                MedianBeratBadan = 6.9d,
                SDPlus1 = 7.5d,
                SDPlus2 = 8.2d,
                SDPlus3 = 8.9d,
            },
            new
            {
                Id = 49,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 64d,
                SDMinus3 = 5.5d,
                SDMinus2 = 6d,
                SDMinus1 = 6.5,
                MedianBeratBadan = 7d,
                SDPlus1 = 7.6d,
                SDPlus2 = 8.3d,
                SDPlus3 = 9.1d,
            },
            new
            {
                Id = 50,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 64.5d,
                SDMinus3 = 5.6d,
                SDMinus2 = 6.1d,
                SDMinus1 = 6.6d,
                MedianBeratBadan = 7.1d,
                SDPlus1 = 7.8d,
                SDPlus2 = 8.5d,
                SDPlus3 = 9.3d,
            },
            new
            {
                Id = 51,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 65d,
                SDMinus3 = 5.7d,
                SDMinus2 = 6.2d,
                SDMinus1 = 6.7d,
                MedianBeratBadan = 7.3d,
                SDPlus1 = 7.9d,
                SDPlus2 = 8.6d,
                SDPlus3 = 9.4d,
            },
            new
            {
                Id = 52,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 65.5d,
                SDMinus3 = 5.8d,
                SDMinus2 = 6.3d,
                SDMinus1 = 6.8d,
                MedianBeratBadan = 7.4d,
                SDPlus1 = 8d,
                SDPlus2 = 8.7d,
                SDPlus3 = 9.6d,
            },
            new
            {
                Id = 53,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 66d,
                SDMinus3 = 5.9d,
                SDMinus2 = 6.4d,
                SDMinus1 = 6.9d,
                MedianBeratBadan = 7.5d,
                SDPlus1 = 8.2d,
                SDPlus2 = 8.9d,
                SDPlus3 = 9.7d,
            },
            new
            {
                Id = 54,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 66.5d,
                SDMinus3 = 6d,
                SDMinus2 = 6.5d,
                SDMinus1 = 7d,
                MedianBeratBadan = 7.6d,
                SDPlus1 = 8.3d,
                SDPlus2 = 9d,
                SDPlus3 = 9.9d,
            },
            new
            {
                Id = 55,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 67d,
                SDMinus3 = 6.1d,
                SDMinus2 = 6.6d,
                SDMinus1 = 7.1d,
                MedianBeratBadan = 7.7d,
                SDPlus1 = 8.4d,
                SDPlus2 = 9.2d,
                SDPlus3 = 10d,
            },
            new
            {
                Id = 56,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 67.5d,
                SDMinus3 = 6.2d,
                SDMinus2 = 6.7d,
                SDMinus1 = 7.2d,
                MedianBeratBadan = 7.9d,
                SDPlus1 = 8.5d,
                SDPlus2 = 9.3d,
                SDPlus3 = 10.2d,
            },
            new
            {
                Id = 57,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 68d,
                SDMinus3 = 6.3d,
                SDMinus2 = 6.8d,
                SDMinus1 = 7.3d,
                MedianBeratBadan = 8d,
                SDPlus1 = 8.7d,
                SDPlus2 = 9.4d,
                SDPlus3 = 10.3d,
            },
            new
            {
                Id = 58,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 68.5d,
                SDMinus3 = 6.4d,
                SDMinus2 = 6.9d,
                SDMinus1 = 7.5d,
                MedianBeratBadan = 8.1d,
                SDPlus1 = 8.8d,
                SDPlus2 = 9.6d,
                SDPlus3 = 10.5d,
            },
            new
            {
                Id = 59,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 69d,
                SDMinus3 = 6.5d,
                SDMinus2 = 7d,
                SDMinus1 = 7.6d,
                MedianBeratBadan = 8.2d,
                SDPlus1 = 8.9d,
                SDPlus2 = 9.7d,
                SDPlus3 = 10.6d,
            },
            new
            {
                Id = 60,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 69.5d,
                SDMinus3 = 6.6d,
                SDMinus2 = 7.1d,
                SDMinus1 = 7.7d,
                MedianBeratBadan = 8.3d,
                SDPlus1 = 9d,
                SDPlus2 = 9.8d,
                SDPlus3 = 10.8d,
            },
            new
            {
                Id = 61,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 70.5d,
                SDMinus3 = 6.6d,
                SDMinus2 = 7.2d,
                SDMinus1 = 7.8d,
                MedianBeratBadan = 8.4d,
                SDPlus1 = 9.2d,
                SDPlus2 = 10d,
                SDPlus3 = 10.9d,
            },
            new
            {
                Id = 62,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 70.5d,
                SDMinus3 = 6.7d,
                SDMinus2 = 7.3d,
                SDMinus1 = 7.9d,
                MedianBeratBadan = 8.5d,
                SDPlus1 = 9.3d,
                SDPlus2 = 10.1d,
                SDPlus3 = 11.1d,
            },
            new
            {
                Id = 63,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 71d,
                SDMinus3 = 6.8d,
                SDMinus2 = 7.4d,
                SDMinus1 = 8d,
                MedianBeratBadan = 8.6d,
                SDPlus1 = 9.4d,
                SDPlus2 = 10.2d,
                SDPlus3 = 11.2d,
            },
            new
            {
                Id = 64,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 71.5d,
                SDMinus3 = 6.9d,
                SDMinus2 = 7.5d,
                SDMinus1 = 8.1d,
                MedianBeratBadan = 8.8d,
                SDPlus1 = 9.5d,
                SDPlus2 = 10.4d,
                SDPlus3 = 11.3d,
            },
            new
            {
                Id = 65,
                KategoriUmur = KategoriUmur.BulanBawah24,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 72d,
                SDMinus3 = 7d,
                SDMinus2 = 7.6d,
                SDMinus1 = 8.2d,
                MedianBeratBadan = 8.9d,
                SDPlus1 = 9.6d,
                SDPlus2 = 10.5d,
                SDPlus3 = 11.5d,
            }

            );
        #endregion

        #region KaderPosyandu
        modelBuilder.Entity<KaderPosyandu>().HasData(
            new
            {
                Id = 1,
                Nama = "Kader Posyandu 1",
                PosyanduId = 1
            }
        );
        #endregion

        #region AppUser
        var daftarAppUser = daftarOrangTua.Select(o => new
        {
            o.Id,
            UserName = o.Nama.ToLower().Split(' ')[0],
            PasswordHash = "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==",
            Role = AppUserRoles.OrangTua,
            OrangTuaId = o.Id
        }).ToArray();

        modelBuilder.Entity<AppUser>().HasData(daftarAppUser);
        modelBuilder.Entity<AppUser>().HasData(new
        {
            Id = daftarOrangTua.Length + 1,
            UserName = "kader1",
            PasswordHash = "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==",
            Role = AppUserRoles.Kader,
            KaderPosyanduId = 1
        });

        #endregion

        return modelBuilder;
    }
}
