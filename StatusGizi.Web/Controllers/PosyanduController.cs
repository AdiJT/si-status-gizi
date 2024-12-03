using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusGizi.Domain.Entities;
using StatusGizi.Infrastructure.Database;
using StatusGizi.Web.Models.PosyanduModels;
using StatusGizi.Web.Services.Contracts;

namespace StatusGizi.Web.Controllers;

public class PosyanduController : Controller
{
    private readonly AppDbContext _appDbContext;
    private readonly IToastrNotificationService _notificationService;

    public PosyanduController(AppDbContext appDbContext, IToastrNotificationService notificationService)
    {
        _appDbContext = appDbContext;
        _notificationService = notificationService;
    }

    public async Task<IActionResult> Index()
    {
        var vm = await _appDbContext.TblPosyandu
            .Include(p => p.DaftarPengecekan)
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

    [Authorize(Roles = AppUserRoles.Kader)]
    public IActionResult Tambah() => View(new TambahVM());

    [HttpPost]
    [Authorize(Roles = AppUserRoles.Kader)]
    public async Task<IActionResult> Tambah(TambahVM vm)
    {
        if(!ModelState.IsValid) return View(vm);

        var desaKelurahan = await _appDbContext.TblDesaKelurahan
            .Include(d => d.DaftarPosyandu)
            .FirstOrDefaultAsync(d => d.Id == vm.DesaKelurahanId);

        if(desaKelurahan is null)
        {
            ModelState.AddModelError(nameof(TambahVM.DesaKelurahanId), "Desa/Kelurahan tidak ditemukan");
            return View(vm);
        }

        if(desaKelurahan.DaftarPosyandu.Any(p => p.Nama == vm.Nama))
        {
            ModelState.AddModelError(nameof(TambahVM.Nama),
                $"Nama posyandu '{vm.Nama}' sudah digunakan posyandu lain di {desaKelurahan.Nama}");
            return View(vm);
        }

        var posyandu = new Posyandu
        {
            Nama = vm.Nama,
            DesaKelurahan = desaKelurahan
        };
        _appDbContext.TblPosyandu.Add(posyandu);

        try
        {
            await _appDbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            ModelState.AddModelError(string.Empty, "Terjadi kesalahan saat mencoba menyimpan perubahan");
            return View(vm);
        }

        _notificationService.AddSuccess("Posyandu berhasil ditambahkan");

        return RedirectToAction(nameof(Index));
    }
}
