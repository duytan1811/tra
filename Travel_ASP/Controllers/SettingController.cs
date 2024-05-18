using Microsoft.AspNetCore.Mvc;
using STM.DataAccess.Contexts;
using Travel_ASP.ViewModels;

namespace Travel_ASP.Controllers
{
    public class SettingController : Controller
    {
        private readonly TravelDbContext _db;

        public SettingController(TravelDbContext db)
        {
            _db = db;
        }

        [HttpGet("admin/settings")]
        public IActionResult Index()
        {
            var settingApp = _db.Configurations.FirstOrDefault(x => x.Key == "appName");
            var settingEmail = _db.Configurations.FirstOrDefault(x => x.Key == "email");
            var settingPhone = _db.Configurations.FirstOrDefault(x => x.Key == "phone");
            var data = new SettingViewModel()
            {
                AppName = settingApp.Value,
                Email = settingEmail.Value,
                Phone = settingPhone.Value,
            };
            return View(data);
        }


        [HttpPost("admin/settings/save")]
        public IActionResult Save(SettingViewModel dto)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            if (dto.DefaultBlogImage != null)
            {
                var setting = _db.Configurations.FirstOrDefault(x => x.Key == "defaultBlogImage");
                string fileName = string.Empty;

                FileInfo fileInfo = new FileInfo(dto.DefaultBlogImage.FileName);
                fileName = dto.DefaultBlogImage.FileName;

                string fileNameWithPath = Path.Combine(path, fileName);

                using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                {
                    dto.DefaultBlogImage.CopyTo(stream);
                }
                setting.Value = fileName;
                _db.Configurations.Update(setting);
            }

            if (dto.DefaultTourImage != null)
            {
                var setting = _db.Configurations.FirstOrDefault(x => x.Key == "defaultTourImage");
                string fileName = string.Empty;

                FileInfo fileInfo = new FileInfo(dto.DefaultTourImage.FileName);
                fileName = dto.DefaultTourImage.FileName;

                string fileNameWithPath = Path.Combine(path, fileName);

                using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                {
                    dto.DefaultTourImage.CopyTo(stream);
                }
                setting.Value = fileName;
                _db.Configurations.Update(setting);
            }

            var settingAppName = _db.Configurations.FirstOrDefault(x => x.Key == "appName");
            if (settingAppName != null)
            {
                settingAppName.Value = dto.AppName;
                _db.Configurations.Update(settingAppName);
            }

            var settingEmail = _db.Configurations.FirstOrDefault(x => x.Key == "email");
            if (settingEmail != null)
            {
                settingEmail.Value = dto.Email;
                _db.Configurations.Update(settingEmail);
            }

            var settingPhone = _db.Configurations.FirstOrDefault(x => x.Key == "phone");
            if (settingPhone != null)
            {
                settingPhone.Value = dto.Phone;
                _db.Configurations.Update(settingPhone);
            }

            _db.SaveChanges();
            ViewData["Message"] = "Cập nhật thông tin website thành công";
            return RedirectToAction("Index");
        }
    }
}
