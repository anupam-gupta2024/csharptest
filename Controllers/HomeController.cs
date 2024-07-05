using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Message = "Master Your .Net Skills";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult about()
    {
        ViewBag.Message = "LEARN MORE ABOUT US";
        return View();
    }

    public IActionResult contact()
    {
        ViewBag.Message = "CONTACT US HERE TO HELP";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
