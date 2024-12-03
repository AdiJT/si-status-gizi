using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StatusGizi.Web.Models;
using StatusGizi.Web.Services.Contracts;

namespace StatusGizi.Web.ViewComponents;

public class ToastrViewComponent : ViewComponent
{
    private readonly IToastrNotificationService _notificationService;

    public ToastrViewComponent(IToastrNotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public IViewComponentResult Invoke(ToastrOptions globalOptions)
    {
        string globalOptionsJson = JsonConvert.SerializeObject(globalOptions, new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            Formatting = Formatting.Indented,
        });
        return View((globalOptionsJson, _notificationService.GetNotificationJson()));
    }
}
