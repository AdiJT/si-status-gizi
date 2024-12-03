using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusGizi.Domain.Entities;
using StatusGizi.Infrastructure.Database;
using StatusGizi.Web.Authentication;
using StatusGizi.Web.Models;
using StatusGizi.Web.Models.HomeModels;
using StatusGizi.Web.Services.Contracts;
using System.Diagnostics;

namespace StatusGizi.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISignInManager _signInManager;
        private readonly AppDbContext _appDbContext;
        private readonly IPasswordHasher<AppUser> _passwordHasher;
        private readonly IToastrNotificationService _notificationService;

        public HomeController(
            ILogger<HomeController> logger,
            ISignInManager signInManager,
            AppDbContext appDbContext,
            IPasswordHasher<AppUser> passwordHasher,
            IToastrNotificationService notificationService)
        {
            _logger = logger;
            _signInManager = signInManager;
            _appDbContext = appDbContext;
            _passwordHasher = passwordHasher;
            _notificationService = notificationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string? returnUrl)
        {
            returnUrl ??= Url.Action("Index")!;

            return View(new LoginVM { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM vm)
        {
            if (!ModelState.IsValid) return View(vm);

            var result = await _signInManager.SignIn(vm.UserName, vm.Password);
            if(result.IsFailure)
            {
                ModelState.AddModelError(string.Empty, result.Error.Message);
                return View(vm);
            }

            _notificationService.AddNotification(new ToastrNotification
            {
                Type = ToastrNotificationType.Success,
                Title = $"Selamat Datang!"
            });

            return Redirect(vm.ReturnUrl);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout(string? returnUrl)
        {
            returnUrl ??= Url.Action(nameof(Index))!;
            var result = await _signInManager.SignOut();

            return Redirect(returnUrl);
        }

        public IActionResult Daftar()
        {
            return View(new DaftarVM());
        }

        [HttpPost]
        public async Task<IActionResult> Daftar(DaftarVM vm)
        {
            if (!ModelState.IsValid) return View(vm);

            var posyandu = await _appDbContext.TblPosyandu.FirstOrDefaultAsync(p => p.Id == vm.PosyanduId);
            if(posyandu is null)
            {
                ModelState.AddModelError(nameof(DaftarVM.PosyanduId), "Posyandu tidak ditemukan");
                return View(vm);
            }

            if(await _appDbContext.TblAppUser.AnyAsync(a => a.UserName == vm.UserName))
            {
                ModelState.AddModelError(nameof(DaftarVM.UserName), "User name sudah digunakan");
                return View(vm);
            }

            var kader = new KaderPosyandu
            {
                Nama = vm.Nama,
                Posyandu = posyandu
            };

            var appUser = new AppUser
            {
                UserName = vm.UserName,
                PasswordHash = _passwordHasher.HashPassword(null, vm.Password),
                KaderPosyandu = kader,
                Role = AppUserRoles.Kader
            };

            _appDbContext.TblKaderPosyandu.Add(kader);
            _appDbContext.TblAppUser.Add(appUser);

            try
            {
                await _appDbContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Masalah");
                ModelState.AddModelError(string.Empty, "Terjadi masalah saat menyimpan data");
                return View(vm);
            }

            return RedirectToAction(nameof(Login));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
