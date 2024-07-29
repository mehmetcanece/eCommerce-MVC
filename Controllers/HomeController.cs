using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using eTicaretMVC.Models;

namespace eTicaretMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [Route("/shop")]
    public IActionResult Shop()
    {
        return View();
    }

    [Route("/blog")]
    public IActionResult Blog()
    {
        return View();
    }

    [Route("/contact")]
    public IActionResult Contact()
    {
        return View();
    }
    [Route("/login")]
    public IActionResult Login()
    {
        return View();
    }

    [Route("/register")]
    public IActionResult Register()
    {
        return View();
    }

    [Route("/about")]
    public IActionResult About()
    {
        return View();
    }

    [Route("/faq")]
    public IActionResult FAQ()
    {
        return View();
    }

    [Route("/checkout")]
    public IActionResult Checkout()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
