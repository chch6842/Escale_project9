using Microsoft.AspNetCore.Mvc;
using escale.Models;
using System.Diagnostics;

namespace escale.Controllers
{
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
    [HttpGet]
    public IActionResult analysis()
    {
      return View();
    }
    [HttpGet]
    public IActionResult ServiceTerm()
    {
      return View();
    }

public IActionResult Contact()
    {
        return View();
    }

  }
}
