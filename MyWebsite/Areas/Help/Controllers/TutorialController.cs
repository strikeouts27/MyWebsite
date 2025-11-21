using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Models;

namespace MyWebsite.Areas.Help.Controllers;

[Area("Help")]
[Route("Help/{Controller}/{action}/{id?}")]
public class TutorialController : Controller
{

    private readonly ILogger<HomeController> _logger;

    public TutorialController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Page1()
    {
        return View();
    }

    public IActionResult Page2()
    {
        return View();
    }

    public IActionResult Page3()
    {
        return View();
    }
}