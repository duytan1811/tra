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
            var tours= _db.Tours.ToList();
            ViewData["Tours"] = tours;
            return View();
        }

        [HttpGet("createOrEdit")]
        public IActionResult CreateOrEdit(Guid? id)
        {
            var tours = _db.Tours.ToList();
            ViewData["Tours"] = tours;
            return View();
        }

        [HttpPost("save")]
        public IActionResult Save(TourViewModel dto)
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            FileInfo fileInfo = new FileInfo(dto.Image.FileName);
            string fileName = dto.Image.FileName + fileInfo.Extension;

            string fileNameWithPath = Path.Combine(path, fileName);

            using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
            {
                dto.Image.CopyTo(stream);
            }
            var tourData = new Tour
            {
                Name=dto.Name,
                DayCount=dto.DayCount,
                MinPeople=dto.MinPeople,
                MaxPeople=dto.MaxPeople,
                Price=dto.Price,
                Detail=dto.Detail,
                Description=dto.Description,
                ProvinceId=dto.ProvinceId,
                Discount=dto.Discount,  
                Image= fileName,
            };

            if(dto.Id.HasValue)
            {
                _db.Tours.Update(tourData);
            }
            else
            {
                _db.Tours.Add(tourData);

            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            var tours = _db.Tours.FirstOrDefault(x=>x.Id==id);
            _db.Tours.Remove(tours);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
