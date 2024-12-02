using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusGizi.Domain.Entities;
using StatusGizi.Infrastructure.Database;

namespace StatusGizi.Web.Controllers;

public class PosyanduController : Controller
{
    private readonly AppDbContext _appDbContext;

    public PosyanduController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<IActionResult> Index()
    {
        var vm = await _appDbContext.TblPengecekan
            .Include(p => p.Posyandu)
            .GroupBy(p => p.Posyandu)
            .ToListAsync();

        return View(vm);
    }

    [Authorize(Roles = AppUserRoles.Kader)]
    public async Task<IActionResult> Detail(int id)
    {
        var posyandu = await _appDbContext.TblPosyandu
            .Include(p => p.DaftarPengecekan).ThenInclude(p => p.Balita)
            .FirstOrDefaultAsync(p => p.Id == id);

        if (posyandu is null) return NotFound();

        return View(posyandu);
    }
}
