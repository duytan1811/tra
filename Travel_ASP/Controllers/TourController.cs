using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using STM.DataAccess.Contexts;
using Travel_ASP.Models;
using Travel_ASP.ViewModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Travel_ASP.Controllers
{
    [Route("admin/tours")]
    public class TourController : Controller
    {
        private readonly TravelDbContext _db;

        public TourController(TravelDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var tours = _db.Tours.ToList();
            ViewData["Tours"] = tours;
            return View();
        }

        [HttpGet("createOrEdit")]
        public IActionResult CreateOrEdit(Guid? id)
        {
            var tour = new TourViewModel();
            if (id.HasValue)
            {
                tour = _db.Tours.Where(x => x.Id == id).Select(x => new TourViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    DayCount = x.DayCount,
                    MinPeople = x.MinPeople,
                    MaxPeople = x.MaxPeople,
                    Price = x.Price,
                    Detail = x.Detail,
                    Description = x.Description,
                    ProvinceId = x.ProvinceId,
                    Discount = x.Discount,
                }).FirstOrDefault();
            }
            ViewData["Tour"] = tour;
            return View();
        }

        [HttpPost("save")]
        public IActionResult Save(TourViewModel dto)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            string fileName = string.Empty;
            if (dto.Image != null)
            {
                FileInfo fileInfo = new FileInfo(dto.Image.FileName);
                fileName = dto.Image.FileName;

                string fileNameWithPath = Path.Combine(path, fileName);

                using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                {
                    dto.Image.CopyTo(stream);
                }
            }

            if (dto.Id.HasValue)
            {
                var tourData = _db.Tours.FirstOrDefault(x => x.Id == dto.Id);
                tourData.Name = dto.Name;
                tourData.DayCount = dto.DayCount;
                tourData.MinPeople = dto.MinPeople;
                tourData.MaxPeople = dto.MaxPeople;
                tourData.Price = dto.Price;
                tourData.Detail = dto.Detail;
                tourData.Description = dto.Description;
                tourData.ProvinceId = dto.ProvinceId;
                tourData.Discount = dto.Discount;
                tourData.Image = (!string.IsNullOrEmpty(tourData.Image) && !string.IsNullOrEmpty(fileName)) || !string.IsNullOrEmpty(fileName) ? fileName : tourData.Image;
                _db.Tours.Update(tourData);
                _db.SaveChanges();
            }
            else
            {
                var tourData = new Tour
                {
                    Name = dto.Name,
                    DayCount = dto.DayCount,
                    MinPeople = dto.MinPeople,
                    MaxPeople = dto.MaxPeople,
                    Price = dto.Price,
                    Detail = dto.Detail,
                    Description = dto.Description,
                    ProvinceId = dto.ProvinceId,
                    Discount = dto.Discount,
                    Image = fileName,
                };
                _db.Tours.Add(tourData);
                _db.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        [HttpPost("delete")]
        public IActionResult Delete(Guid id)
        {
            var tours = _db.Tours.FirstOrDefault(x => x.Id == id);
            _db.Tours.Remove(tours);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            var tours = _db.Tours.ToList();
            ViewData["Tours"] = tours;
            return View();
        }

        [HttpGet("list/{id}")]
        public IActionResult TourDetail(Guid id)
        {
            var tour = _db.Tours.FirstOrDefault(x=>x.Id == id);
            ViewData["Tour"] = tour;
            return View();
        }

    }
}
