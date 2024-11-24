using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusGizi.Domain.Entities;
using StatusGizi.Infrastructure.Database;

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

        if (desaKelurahan is null) return View(new List<Pengecekan>());

        var daftarPengecekan = await _appDbContext.TblPengecekan
            .Include(p => p.Balita).ThenInclude(b => b.OrangTua).ThenInclude(o => o.DesaKelurahan)
            .Include(p => p.Posyandu).ThenInclude(p => p.DesaKelurahan)
            .Where(p => p.Posyandu.DesaKelurahan.Id == desaKelurahan.Id)
            .ToListAsync();

        return View(daftarPengecekan);
    }
}
