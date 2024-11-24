using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusGizi.Infrastructure.Database;

namespace StatusGizi.Web.Controllers;

public class BalitaController : Controller
{
    private readonly AppDbContext _appDbContext;

    public BalitaController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<IActionResult> Index()
    {
        var daftarBalita = await _appDbContext.TblBalita
            .Include(b => b.OrangTua).ThenInclude(o => o.DesaKelurahan)
            .Include(b => b.DaftarPengecekan).ThenInclude(p => p.Posyandu).ThenInclude(p => p.DesaKelurahan)
            .ToListAsync();

        return View(daftarBalita);
    }

    public async Task<IActionResult> Detail(string id)
    {
        var balita = await _appDbContext.TblBalita
            .Include(b => b.OrangTua).ThenInclude(o => o.DesaKelurahan)
            .Include(b => b.DaftarPengecekan).ThenInclude(p => p.Posyandu).ThenInclude(p => p.DesaKelurahan)
            .FirstOrDefaultAsync(b => b.NIK == id);

        if (balita is null) return NotFound();

        return View(balita);
    }
}
