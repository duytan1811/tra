using Microsoft.AspNetCore.Mvc;
using STM.DataAccess.Contexts;
using Travel_ASP.ViewModels;

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

        var defaultImage = _db.Configurations.FirstOrDefault(x => x.Key == "defaultTourImage");
        foreach (var tour in popTours)
        {
            if (string.IsNullOrEmpty(tour.Image))
            {
                tour.Image = defaultImage.Value;
            }
        }
        return View();
    }

    [HttpPost("search")]
    public IActionResult Search(SearchViewModel dto)
    {
        return RedirectToAction("List","Tour",dto);
    }
}
