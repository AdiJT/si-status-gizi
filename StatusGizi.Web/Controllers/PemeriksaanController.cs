using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusGizi.Domain.Enums;
using StatusGizi.Infrastructure.Database;
using StatusGizi.Web.Models.PemeriksaanController;

namespace StatusGizi.Web.Controllers;

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
}
