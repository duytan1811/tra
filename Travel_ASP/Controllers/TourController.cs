using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using STM.DataAccess.Contexts;
using Travel_ASP.Models;
using Travel_ASP.ViewModels;

namespace Travel_ASP.Controllers
{
    public class TourController : Controller
    {
        private readonly TravelDbContext _db;

        public TourController(TravelDbContext db)
        {
            _db = db;
        }

        [HttpGet("admin/tours")]

        public IActionResult Index()
        {
            var tours = _db.Tours.ToList();
            var defaultImage = _db.Configurations.FirstOrDefault(x => x.Key == "defaultTourImage");
            foreach (var tour in tours)
            {
                if (string.IsNullOrEmpty(tour.Image))
                {
                    tour.Image = defaultImage.Value;
                }
            }
            ViewData["Tours"] = tours;
            return View();
        }

        [HttpGet("admin/tours/createOrEdit")]
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
            var provinces = _db.Provinces.ToList();

            ViewData["Provinces"] = provinces;
            return View(tour);
        }

        [HttpPost("admin/tours/save")]
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
                    CreatedAt = DateTime.Now,
                };
                _db.Tours.Add(tourData);
                _db.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        [HttpPost("admin/tours/delete")]
        public IActionResult Delete(Guid id)
        {
            var tours = _db.Tours.FirstOrDefault(x => x.Id == id);
            _db.Tours.Remove(tours);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("tours/list")]
        public IActionResult List(SearchViewModel dto)
        {

            var query = _db.Tours.AsQueryable();

            if (dto.Province.HasValue)
            {
                query = query.Where(x => x.ProvinceId == dto.Province.Value);
            }
            if (dto.DayCount.HasValue)
            {
                if (dto.DayCount != 4)
                {
                    query = query.Where(x => x.DayCount == dto.DayCount);
                }
                else
                {
                    query = query.Where(x => x.DayCount > 3);
                }
            }
            if (dto.PeopleCount.HasValue)
            {
                if (dto.PeopleCount == 1)
                {
                    query = query.Where(x => x.MaxPeople < 3);
                }
                else if (dto.PeopleCount == 2)
                {
                    query = query.Where(x => x.MaxPeople <= 8 && x.MinPeople >= 3);
                }
                else if (dto.PeopleCount == 3)
                {
                    query = query.Where(x => x.MinPeople > 8);
                }
            }

            var tours = query.Include(x => x.Province).ToList();

            var defaultImage = _db.Configurations.FirstOrDefault(x => x.Key == "defaultTourImage");
            foreach (var tour in tours)
            {
                if (string.IsNullOrEmpty(tour.Image))
                {
                    tour.Image = defaultImage.Value;
                }
            }
            ViewData["Tours"] = tours;
            return View();
        }

        [HttpGet("tours/list/{id}")]
        public IActionResult TourDetail(Guid id)
        {
            var tour = _db.Tours.Include(x => x.Province).FirstOrDefault(x => x.Id == id);
            var defaultImage = _db.Configurations.FirstOrDefault(x => x.Key == "defaultTourImage");

            if (string.IsNullOrEmpty(tour.Image))
            {
                tour.Image = defaultImage.Value;
            }

            ViewData["Tour"] = tour;
            return View();
        }

    }
}
