﻿using Microsoft.EntityFrameworkCore;
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
            },
            new DesaKelurahan
            {
                Id = 5,
                Nama = "Bangka Kuleng",
            },
            new DesaKelurahan
            {
                Id = 6,
                Nama = "Bangka Leleng",
            },
            new DesaKelurahan
            {
                Id = 7,
                Nama = "Bangka Pau",
            },
            new DesaKelurahan
            {
                Id = 8,
                Nama = "Bea Waek",
            },
            new DesaKelurahan
            {
                Id = 9,
                Nama = "Compang Wesang",
            },
            new DesaKelurahan
            {
                Id = 10,
                Nama = "Golo Lobos",
            },
            new DesaKelurahan
            {
                Id = 11,
                Nama = "Golo Nderu",
            },
            new DesaKelurahan
            {
                Id = 12,
                Nama = "Golo Rengket",
            },
            new DesaKelurahan
            {
                Id = 13,
                Nama = "Gurung Turi",
            },
            new DesaKelurahan
            {
                Id = 14,
                Nama = "Mando Sawu",
            },
            new DesaKelurahan
            {
                Id = 15,
                Nama = "Nggalak Leleng",
            },
            new DesaKelurahan
            {
                Id = 16,
                Nama = "Pocolia",
            },
            new DesaKelurahan
            {
                Id = 17,
                Nama = "Satar Tesem",
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
            },
            new
            {
                Id = 20,
                Nama = "Bealing 1",
                DesaKelurahanId = 7
            },
            new
            {
                Id = 21,
                Nama = "Bealing 2",
                DesaKelurahanId = 7
            },
            new
            {
                Id = 22,
                Nama = "Bealing 2",
                DesaKelurahanId = 7
            },
            new
            {
                Id = 23,
                Nama = "Leci",
                DesaKelurahanId = 5
            },
            new
            {
                Id = 24,
                Nama = "Ceka Likang",
                DesaKelurahanId = 6
            },
            new
            {
                Id = 25,
                Nama = "Golo Tenda",
                DesaKelurahanId = 6
            },
            new
            {
                Id = 26,
                Nama = "Carang",
                DesaKelurahanId = 8
            },
            new
            {
                Id = 27,
                Nama = "Geleng",
                DesaKelurahanId = 9
            },
            new
            {
                Id = 28,
                Nama = "Golo Ara",
                DesaKelurahanId = 9
            },
            new
            {
                Id = 29,
                Nama = "Wesang",
                DesaKelurahanId = 9
            },
            new
            {
                Id = 30,
                Nama = "Lame 2",
                DesaKelurahanId = 10
            },
            new
            {
                Id = 31,
                Nama = "Pelus",
                DesaKelurahanId = 10
            },
            new
            {
                Id = 32,
                Nama = "Lamba",
                DesaKelurahanId = 11
            },
            new
            {
                Id = 33,
                Nama = "Nderu",
                DesaKelurahanId = 11
            },
            new
            {
                Id = 34,
                Nama = "Nggari",
                DesaKelurahanId = 11
            },
            new
            {
                Id = 35,
                Nama = "Majung",
                DesaKelurahanId = 12
            },
            new
            {
                Id = 36,
                Nama = "Ncuang",
                DesaKelurahanId = 13
            },
            new
            {
                Id = 37,
                Nama = "Ndueng",
                DesaKelurahanId = 13
            },
            new
            {
                Id = 38,
                Nama = "Nengkal",
                DesaKelurahanId = 13
            },
            new
            {
                Id = 39,
                Nama = "Pocong",
                DesaKelurahanId = 13
            },
            new
            {
                Id = 40,
                Nama = "Benteng Dima",
                DesaKelurahanId = 14
            },
            new
            {
                Id = 41,
                Nama = "Golo Laci",
                DesaKelurahanId = 14
            },
            new
            {
                Id = 42,
                Nama = "Kompas",
                DesaKelurahanId = 14
            },
            new
            {
                Id = 43,
                Nama = "Lewe",
                DesaKelurahanId = 15
            },
            new
            {
                Id = 44,
                Nama = "Watu Cie",
                DesaKelurahanId = 15
            },
            new
            {
                Id = 45,
                Nama = "Pandang",
                DesaKelurahanId = 16
            },
            new
            {
                Id = 46,
                Nama = "Pongkor",
                DesaKelurahanId = 16
            },
            new
            {
                Id = 47,
                Nama = "Moncok",
                DesaKelurahanId = 17
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
                Nama = "BONEFASIUS KEOR",
                DesaKelurahanId = 14
            },
            new
            {
                Id = 60,
                Nama = "ELFRIDA NDIMUN",
                DesaKelurahanId = 13
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
                NIK = "5319024912229990",
                Nama = "MELTIADES KEOR",
                JenisKelamin = JenisKelamin.Perempuan,
                TanggalLahir = new DateOnly(2022, 12, 9),
                BeratBadanWaktuLahir = 3.2d,
                TinggiBadanWaktuLahir = 51d,
                OrangTuaId = 59
            },
            new
            {
                NIK = "5319025103229974",
                Nama = "MARIA Y.T. QUIN",
                JenisKelamin = JenisKelamin.Perempuan,
                TanggalLahir = new DateOnly(2022, 3, 11),
                BeratBadanWaktuLahir = 3.2d,
                TinggiBadanWaktuLahir = 51d,
                OrangTuaId = 60
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
                PosyanduId =16 ,
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
                BalitaNIK = "5319024912229990",
                TanggalPengecekan = new DateOnly(2022, 12, 9),
                BeratBadan = 3.4d,
                TinggiBadan = 59.9d,
                LingkarLenganAtas = 10.5d,
                KategoriGizi = KategoriGizi.GiziBuruk,
                PosyanduId = 40,
            },
            new
            {
                Id = 38,
                BalitaNIK = "5319025103229974",
                TanggalPengecekan = new DateOnly(2022, 3, 11),
                BeratBadan = 6.8d,
                TinggiBadan = 75.9d,
                LingkarLenganAtas = 13.7d,
                KategoriGizi = KategoriGizi.GiziBuruk,
                PosyanduId = 36,
            }

        );
        #endregion

        #region StandarBeratMenurutBBTB
        modelBuilder.Entity<StandarBeratMenurutBBTB>().HasData(
            new StandarBeratMenurutBBTB
            {
                Id = 1,
                JenisKelamin = JenisKelamin.LakiLaki,
                TinggiBadan = 1,
                SDMinus3 = 1,
                SDMinus2 = 1,
                SDMinus1 = 1,
                MedianBeratBadan = 1,
                SDPlus1 = 1,
                SDPlus2 = 1,
                SDPlus3 = 1,
            }
        );
        #endregion

        return modelBuilder;
    }
}
