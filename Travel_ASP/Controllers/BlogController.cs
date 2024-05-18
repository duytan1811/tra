using Microsoft.AspNetCore.Mvc;
using STM.DataAccess.Contexts;
using Travel_ASP.Models;
using Travel_ASP.ViewModels;

namespace Travel_ASP.Controllers
{
    public class BlogController : Controller
    {
        private readonly TravelDbContext _db;
        public BlogController(TravelDbContext db)
        {
            _db = db;
        }

        [HttpGet("admin/blogs")]

        public IActionResult Index()
        {
            var blogs = _db.Blogs.ToList();

            var defaultImage = _db.Configurations.FirstOrDefault(x => x.Key == "defaultBLogImage");

            foreach (var blog in blogs)
            {
                if (string.IsNullOrEmpty(blog.Image))
                {
                    blog.Image = defaultImage.Value;
                }
            }
            ViewData["Blogs"] = blogs;
            return View();
        }

        [HttpGet("admin/blogs/createOrEdit")]
        public IActionResult CreateOrEdit(Guid? id)
        {
            var blog = new BlogViewModel();
            if (id.HasValue)
            {
                blog = _db.Blogs.Where(x => x.Id == id).Select(x => new BlogViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Image = x.Image,
                    Description = x.Description,
                }).FirstOrDefault();
            }
            
            return View(blog);
        }

        [HttpPost("admin/blogs/save")]
        public IActionResult Save(BlogViewModel dto)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            string fileName = string.Empty;

            if (dto.ImageImport != null)
            {
                FileInfo fileInfo = new FileInfo(dto.ImageImport.FileName);
                fileName = dto.ImageImport.FileName;

                string fileNameWithPath = Path.Combine(path, fileName);

                using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                {
                    dto.ImageImport.CopyTo(stream);
                }
            }

            if (dto.Id.HasValue)
            {
                var blogData = _db.Blogs.FirstOrDefault(x => x.Id == dto.Id);
                blogData.Name = dto.Name;
                blogData.Description = dto.Description;
                blogData.Image = (!string.IsNullOrEmpty(blogData.Image) && !string.IsNullOrEmpty(fileName)) || !string.IsNullOrEmpty(fileName) ? fileName : blogData.Image;
                _db.Blogs.Update(blogData);
                _db.SaveChanges();
            }
            else
            {
                var blogData = new Blog
                {
                    Name = dto.Name,
                    Description = dto.Description,
                    Image = fileName,
                    CreatedAt = DateTime.Now,
                };
                _db.Blogs.Add(blogData);
                _db.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        [HttpPost("admin/blogs/delete")]
        public IActionResult Delete(Guid id)
        {
            var blog = _db.Blogs.FirstOrDefault(x => x.Id == id);
            _db.Blogs.Remove(blog);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("blogs/list")]
        public IActionResult List()
        {
            var blogs = _db.Blogs.ToList();
            var defaultImage = _db.Configurations.FirstOrDefault(x => x.Key == "defaultBLogImage");
            foreach (var blog in blogs)
            {
                if (string.IsNullOrEmpty(blog.Image))
                {
                    blog.Image = defaultImage.Value;
                }
            }
            ViewData["Blogs"] = blogs;
            return View();
        }

        [HttpGet("blogs/list/{id}")]
        public IActionResult BlogDetail(Guid id)
        {
            var blog = _db.Blogs.FirstOrDefault(x => x.Id == id);
            var lastBlogs = _db.Blogs.Take(5).ToList();

            var defaultImage = _db.Configurations.FirstOrDefault(x => x.Key == "defaultBLogImage");
            if (string.IsNullOrEmpty(blog.Image))
            {
                blog.Image = defaultImage.Value;
            }

            foreach (var item in lastBlogs)
            {
                if (string.IsNullOrEmpty(item.Image))
                {
                    item.Image = defaultImage.Value;
                }
            }
            ViewData["LastBlogs"] = lastBlogs;
            return View(blog);
        }
    }
}
