using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Models;

namespace MyWebsite.Areas.Help.Controllers;

[Area("Help")]
[Route("Help/{Controller}/{action}/{id?}")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // This attribute tag can eliminate ambigous routing errors. 
    // This index falls under the help route. 
    // putting this tag eliminates this index method from being the default route for the project and instead
    // specifies this is the default route for the areas section.
       
    public IActionResult Index()
    {
        return View();
    }

    // Action methods are for telling ASP.NET what to display. 
    // Layouts are not routed they are inherited stuff.
    
    public IActionResult Tutorial()
    {
        return View();
    }
 
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
