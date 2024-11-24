using Microsoft.AspNetCore.Mvc;
using StatusGizi.Web.Models;

namespace StatusGizi.Web.ViewComponents;

public class ChartViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(ChartVM chartModel)
    {
        return View(chartModel);
    }
}
