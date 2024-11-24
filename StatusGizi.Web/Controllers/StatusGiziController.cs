using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusGizi.Domain.Entities;
using StatusGizi.Domain.Enums;
using StatusGizi.Infrastructure.Database;
using StatusGizi.Web.Models.StatusGizi;

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
}
