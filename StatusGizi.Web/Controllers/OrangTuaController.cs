using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusGizi.Domain.Entities;
using StatusGizi.Infrastructure.Database;
using StatusGizi.Web.Models.OrangTuaModels;
using StatusGizi.Web.Services.Contracts;

namespace StatusGizi.Web.Controllers;

[Authorize(Roles = AppUserRoles.Kader)]
public class OrangTuaController : Controller
{
    private readonly AppDbContext _appDbContext;
    private readonly IPasswordHasher<AppUser> _passwordHasher;
    private readonly IToastrNotificationService _notificationService;

    public OrangTuaController(
        AppDbContext appDbContext,
        IPasswordHasher<AppUser> passwordHasher,
        IToastrNotificationService notificationService)
    {
        _appDbContext = appDbContext;
        _passwordHasher = passwordHasher;
        _notificationService = notificationService;
    }

    public async Task<IActionResult> Index()
    {
        var daftarOrangTua = await _appDbContext.TblOrangTua
            .Include(o => o.DesaKelurahan)
            .Include(o => o.DaftarBalita)
            .ToListAsync();

        return View(daftarOrangTua);
    }

    public async Task<IActionResult> Detail(int id)
    {
        var orangTua = await _appDbContext.TblOrangTua
            .Include(o => o.DesaKelurahan)
            .Include(o => o.DaftarBalita).ThenInclude(b => b.DaftarPengecekan).ThenInclude(p => p.Posyandu)
            .FirstOrDefaultAsync(o => o.Id == id);

        if (orangTua is null) return NotFound();

        return View(orangTua);
    }

    public IActionResult Tambah() => View(new TambahVM());

    [HttpPost]
    public async Task<IActionResult> Tambah(TambahVM vm)
    {
        if(!ModelState.IsValid) return View(vm);

        var desaKelurahan = await _appDbContext.TblDesaKelurahan
            .Include(k => k.DaftarOrangTua)
            .FirstOrDefaultAsync(k => k.Id == vm.DesaKelurahanId);

        if(desaKelurahan is null)
        {
            ModelState.AddModelError(nameof(TambahVM.DesaKelurahanId), "Desa/Kelurahan tidak ditemukan");
            return View(vm);
        }

        var orangTua = new OrangTua
        {
            Nama = vm.Nama,
            DesaKelurahan = desaKelurahan
        };

        var appUser = new AppUser
        {
            UserName = orangTua.Nama.ToLower().Split(" ").First(),
            PasswordHash = _passwordHasher.HashPassword(null, "password"),
            OrangTua = orangTua,
            Role = AppUserRoles.OrangTua
        };

        _appDbContext.TblOrangTua.Add(orangTua);
        _appDbContext.TblAppUser.Add(appUser);

        try
        {
            await _appDbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            ModelState.AddModelError(string.Empty, "Terjadi kesalahan saat mencoba menyimpan perubahan");
            return View(vm);
        }

        _notificationService.AddSuccess("Orang Tua berhasil ditambahkan");

        return RedirectToAction(nameof(Detail), new { id = orangTua.Id });
    }
}
