using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusGizi.Domain.Entities;
using StatusGizi.Domain.Enums;
using StatusGizi.Infrastructure.Database;
using StatusGizi.Web.Models.StatusGizi;
using System.Data;

namespace StatusGizi.Web.Controllers;

public class StatusGiziController : Controller
{
    private readonly AppDbContext _appDbContext;

    public StatusGiziController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<IActionResult> Index()
    {
        var vm = await _appDbContext.TblPengecekan
            .Include(p => p.Balita)
            .Include(p => p.Posyandu).ThenInclude(p => p.DesaKelurahan)
            .GroupBy(p => p.Posyandu.DesaKelurahan)
            .ToListAsync();

        return View(vm);
    }

    public async Task<IActionResult> Detail(int id)
    {
        var desaKelurahan = await _appDbContext.TblDesaKelurahan
            .FirstOrDefaultAsync(d => d.Id == id);

        if (desaKelurahan is null) return NotFound();

        var daftarPengecekan = await _appDbContext.TblPengecekan
            .Include(p => p.Balita).ThenInclude(b => b.OrangTua).ThenInclude(o => o.DesaKelurahan)
            .Include(p => p.Posyandu).ThenInclude(p => p.DesaKelurahan)
            .Where(p => p.Posyandu.DesaKelurahan.Id == desaKelurahan.Id)
            .ToListAsync();

        return View(new DetailVM
        {
            DesaKelurahan = desaKelurahan,
            DaftarPengecekan = daftarPengecekan,
        });
    }

    public async Task<IActionResult> Analisis(int id)
    {
        var pengecekan = await _appDbContext
            .TblPengecekan
            .Include(p => p.Balita).ThenInclude(b => b.OrangTua).ThenInclude(o => o.DesaKelurahan)
            .Include(p => p.Posyandu).ThenInclude(p => p.DesaKelurahan)
            .FirstOrDefaultAsync(p => p.Id == id);

        if (pengecekan is null) return NotFound();

        var kategoriUmur = pengecekan.UsiaDalamBulan <= 24 ? KategoriUmur.BulanBawah24 : KategoriUmur.Bulan24Sampai60;

        var standarBeratMenurutBBTB = await _appDbContext
            .TblStandarBeratMenurutBBTB
            .Where(s => s.JenisKelamin == pengecekan.Balita.JenisKelamin && s.KategoriUmur == kategoriUmur && s.TinggiBadan <= pengecekan.TinggiBadan)
            .OrderBy(s => s.TinggiBadan)
            .LastOrDefaultAsync();

        if (standarBeratMenurutBBTB is null) return BadRequest();

        return View(new AnalisisVM { StandarBeratMenurutBBTB = standarBeratMenurutBBTB, Pengecekan = pengecekan });
    }

    public IActionResult IsiData()
    {
        return View(new IsiDataVM());
    }

    [HttpPost]
    public async Task<IActionResult> IsiData(IsiDataVM vm)
    {
        var orangTua = await _appDbContext.TblOrangTua.Include(o => o.DaftarBalita).FirstOrDefaultAsync(o => o.Nama == vm.OrangTua);

        if (orangTua is null)
        {
            var desaKelurahan = await _appDbContext.TblDesaKelurahan.FirstOrDefaultAsync(d => d.Id == vm.DesaKelurahanTinggalId);
            if (desaKelurahan is null)
            {
                ModelState.AddModelError(nameof(IsiDataVM.DesaKelurahanTinggalId), "Desa/Kelurahan tidak ditemukan");
                return View(vm);
            }

            orangTua = new OrangTua
            {
                Nama = vm.Nama,
                DesaKelurahan = desaKelurahan
            };
            _appDbContext.TblOrangTua.Add(orangTua);
        }

        var balita = await _appDbContext.TblBalita.Include(b => b.OrangTua).FirstOrDefaultAsync(b => b.NIK == vm.NIK);
        if (balita is null)
        {
            balita = new Balita
            {
                NIK = vm.NIK,
                Nama = vm.Nama,
                JenisKelamin = vm.JenisKelamin,
                TanggalLahir = vm.TanggalLahir,
                BeratBadanWaktuLahir = vm.BeratBadanLahir,
                TinggiBadanWaktuLahir = vm.TinggiBadanLahir,
                OrangTua = orangTua
            };
            _appDbContext.TblBalita.Add(balita);
        }

        var posyandu = await _appDbContext.TblPosyandu.FirstOrDefaultAsync(p => p.Id == vm.PosyanduId);
        if (posyandu is null)
        {
            ModelState.AddModelError(nameof(IsiDataVM.PosyanduId), "Posyandu stidak ditemukan");
            return View(vm);
        }

        var pengecekan = new Pengecekan
        {
            Balita = balita,
            Posyandu = posyandu,
            LingkarLenganAtas = vm.LingkarLenganAtas,
            BeratBadan = vm.BeratBadan,
            TanggalPengecekan = vm.TanggalUkur,
            TinggiBadan = vm.TinggiBadan,
        };

        var kategoriUmur = pengecekan.UsiaDalamBulan <= 24 ? KategoriUmur.BulanBawah24 : KategoriUmur.Bulan24Sampai60;
        var standarBeratMenurutBBTB = await _appDbContext
            .TblStandarBeratMenurutBBTB
            .Where(s => s.JenisKelamin == pengecekan.Balita.JenisKelamin && s.KategoriUmur == kategoriUmur && s.TinggiBadan <= pengecekan.TinggiBadan)
            .OrderBy(s => s.TinggiBadan)
            .LastOrDefaultAsync();

        if (standarBeratMenurutBBTB is null) return BadRequest();

        if (pengecekan.BeratBadan < standarBeratMenurutBBTB.SDMinus3)
        {
            pengecekan.KategoriGizi = KategoriGizi.GiziBuruk;
        }
        else if (pengecekan.BeratBadan >= standarBeratMenurutBBTB.SDMinus3 && pengecekan.BeratBadan < standarBeratMenurutBBTB.SDMinus2)
        {
            pengecekan.KategoriGizi = KategoriGizi.GiziKurang;
        }
        else if (pengecekan.BeratBadan >= standarBeratMenurutBBTB.SDMinus2 && pengecekan.BeratBadan <= standarBeratMenurutBBTB.SDPlus1)
        {
            pengecekan.KategoriGizi = KategoriGizi.GiziBaik;
        }
        else if (pengecekan.BeratBadan > standarBeratMenurutBBTB.SDPlus1 && pengecekan.BeratBadan <= standarBeratMenurutBBTB.SDPlus2)
        {
            pengecekan.KategoriGizi = KategoriGizi.BerpotensiBerlebih;
        }
        else if (pengecekan.BeratBadan > standarBeratMenurutBBTB.SDPlus2 && pengecekan.BeratBadan <= standarBeratMenurutBBTB.SDPlus3)
        {
            pengecekan.KategoriGizi = KategoriGizi.GiziBerlebih;
        }
        else
        {
            pengecekan.KategoriGizi = KategoriGizi.Obesitas;
        }

        _appDbContext.TblPengecekan.Add(pengecekan);

        try
        {
            await _appDbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            ModelState.AddModelError(string.Empty, "Terjadi error saat menyimpan data ke database");
            return View(vm);
        }

        return RedirectToAction(nameof(Analisis), new { id = pengecekan.Id });
    }
}
