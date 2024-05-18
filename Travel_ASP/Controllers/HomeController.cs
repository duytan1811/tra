using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using STM.DataAccess.Contexts;
using Travel_ASP.Models;

namespace Travel_ASP.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly TravelDbContext _db;

    public HomeController(ILogger<HomeController> logger, TravelDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        var popTours= _db.Tours.Take(3).ToList();
        ViewData["PopTours"] = popTours;

        var popBlogs = _db.Blogs.Take(3).ToList();
        ViewData["PopBlogs"] = popBlogs;

        var provinces = _db.Provinces.ToList();
        ViewData["Provinces"] = provinces;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
