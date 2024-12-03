using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusGizi.Domain.Entities;
using StatusGizi.Domain.Enums;
using StatusGizi.Infrastructure.Database;
using StatusGizi.Web.Models.PemeriksaanModels;

namespace StatusGizi.Web.Controllers;

[Authorize(Roles = AppUserRoles.Kader)]
public class PemeriksaanController : Controller
{
    private readonly AppDbContext _appDbContext;

    public PemeriksaanController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<IActionResult> Index(int id)
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

        return View(new IndexVM { StandarBeratMenurutBBTB = standarBeratMenurutBBTB, Pengecekan = pengecekan });
    }

    public IActionResult Tambah()
    {
        return View(new TambahVM { TanggalUkur = DateOnly.FromDateTime(DateTime.Now)});
    }

    [HttpPost]
    public async Task<IActionResult> Tambah(TambahVM vm)
    {
        if (!ModelState.IsValid) return View(vm);

        var balita = await _appDbContext.TblBalita.FirstOrDefaultAsync(b => b.NIK == vm.NIK);
        if (balita is null)
        {
            ModelState.AddModelError(nameof(TambahVM.NIK), "Balita tidak ditemukan");
            return View(vm);
        }

        var posyandu = await _appDbContext.TblPosyandu.FirstOrDefaultAsync(p => p.Id == vm.PosyanduId);
        if (posyandu is null)
        {
            ModelState.AddModelError(nameof(TambahVM.PosyanduId), "Posyandu tidak ditemukan");
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

        return RedirectToAction(nameof(Index), new { id = pengecekan.Id });
    }
}
