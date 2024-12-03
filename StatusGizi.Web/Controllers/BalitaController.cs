using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusGizi.Domain.Entities;
using StatusGizi.Infrastructure.Database;
using StatusGizi.Web.Models.BalitaModels;
using StatusGizi.Web.Services.Contracts;

namespace StatusGizi.Web.Controllers;

[Authorize(Roles = AppUserRoles.Kader)]
public class BalitaController : Controller
{
    private readonly AppDbContext _appDbContext;
    private readonly IToastrNotificationService _notificationService;

    public BalitaController(AppDbContext appDbContext, IToastrNotificationService notificationService)
    {
        _appDbContext = appDbContext;
        _notificationService = notificationService;
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

    public IActionResult Tambah() => View(new TambahVM());

    [HttpPost]
    public async Task<IActionResult> Tambah(TambahVM vm)
    {
        if (!ModelState.IsValid) return View(vm);

        if(await _appDbContext.TblBalita.AnyAsync(b => b.NIK == vm.NIK))
        {
            ModelState.AddModelError(nameof(TambahVM.NIK), $"NIK '{vm.NIK}' dimiliki oleh balita lain");
            return View(vm);
        }

        var orangTua = await _appDbContext.TblOrangTua.FirstOrDefaultAsync(o => o.Id == vm.OrangTuaId);
        if(orangTua is null)
        {
            ModelState.AddModelError(nameof(TambahVM.OrangTuaId), "Orang Tua tidak ditemukan");
            return View(vm);
        }

        var balita = new Balita
        {
            NIK = vm.NIK,
            Nama = vm.Nama,
            JenisKelamin = vm.JenisKelamin,
            BeratBadanWaktuLahir = vm.BeratBadanLahir,
            TinggiBadanWaktuLahir = vm.TinggiBadanLahir,
            TanggalLahir = vm.TanggalLahir,
            OrangTua = orangTua
        };

        _appDbContext.TblBalita.Add(balita);

        try
        {
            await _appDbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            ModelState.AddModelError(string.Empty, "Terjadi kesalahan saat mencoba menyimpan perubahan");
            return View(vm);
        }

        _notificationService.AddSuccess("Balita berhasil ditambahkan");

        return RedirectToAction(nameof(Detail), new { id = balita.NIK });
    }
}
