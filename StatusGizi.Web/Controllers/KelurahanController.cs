using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusGizi.Domain.Entities;
using StatusGizi.Domain.Enums;
using StatusGizi.Infrastructure.Database;
using StatusGizi.Web.Models;
using StatusGizi.Web.Models.KelurahanModels;
using StatusGizi.Web.Services.Contracts;
using System.Data;

namespace StatusGizi.Web.Controllers;

public class KelurahanController : Controller
{
    private readonly AppDbContext _appDbContext;
    private readonly IToastrNotificationService _notificationService;

    public KelurahanController(AppDbContext appDbContext, IToastrNotificationService notificationService)
    {
        _appDbContext = appDbContext;
        _notificationService = notificationService;
    }

    public async Task<IActionResult> Index()
    {
        var vm = await _appDbContext.TblDesaKelurahan
            .Include(p => p.DaftarPosyandu).ThenInclude(p => p.DaftarPengecekan)
            .ToListAsync();

        return View(vm);
    }

    [Authorize(Roles = AppUserRoles.Kader)]
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

    [Authorize(Roles = AppUserRoles.Kader)]
    public IActionResult Tambah()
    {
        return View(new TambahVM());
    }

    [Authorize(Roles = AppUserRoles.Kader)]
    [HttpPost]
    public async Task<IActionResult> Tambah(TambahVM vm)
    {
        if (!ModelState.IsValid) return View(vm);

        if(await _appDbContext.TblDesaKelurahan.AnyAsync(d => d.Nama == vm.Nama))
        {
            ModelState.AddModelError(nameof(TambahVM.Nama), $"Nama '{vm.Nama}' sudah digunakan");
            return View(vm);
        }

        var desaKelurahan = new DesaKelurahan
        {
            Nama = vm.Nama
        };
        _appDbContext.TblDesaKelurahan.Add(desaKelurahan);
        try
        {
            await _appDbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            ModelState.AddModelError(string.Empty, "Terjadi masalah saat mencoba menyimpan");
            return View(vm);
        }

        _notificationService.AddNotification(new ToastrNotification
        {
            Type = ToastrNotificationType.Success,
            Title = "Kelurahan Berhasil DiTambahkan!"
        });

        return RedirectToAction(nameof(Detail), new { id = desaKelurahan.Id });
    }
}
