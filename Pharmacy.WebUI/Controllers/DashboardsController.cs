using Microsoft.AspNetCore.Mvc;

namespace Pharmacy.WebUI.Controllers;

public class DashboardsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}