using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class Home : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}