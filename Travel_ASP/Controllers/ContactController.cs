using Microsoft.AspNetCore.Mvc;
using STM.DataAccess.Contexts;
using Travel_ASP.Models;
using Travel_ASP.ViewModels;

namespace Travel_ASP.Controllers
{
    public class ContactController : Controller
    {
        private readonly TravelDbContext _db;

        public ContactController(TravelDbContext db)
        {
            _db = db;
        }

        [HttpGet("admin/contacts")]
        public IActionResult Index()
        {
            var contacts= _db.Contacts.ToList();
            ViewData["Contacts"]=contacts;
            return View();
        }

        [HttpGet("admin/contacts/{id}")]
        public IActionResult Detail(Guid id)
        {
            var contact = _db.Contacts.FirstOrDefault(x => x.Id == id);
            ViewData["Contact"] = contact;
            return View();
        }

        [HttpPost("admin/contacts/delete")]
        public IActionResult Delete(Guid id)
        {
            var contact = _db.Contacts.FirstOrDefault(x => x.Id == id);
            _db.Contacts.Remove(contact);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact/send")]
        public IActionResult SendContact(ContactViewModel dto)
        {
            
            var newContact= new Contact()
            {
                Content = dto.Content,
                Email = dto.Email,
                FullName = dto.FullName,
                Phone = dto.Phone,
                Subject = dto.Subject,
            };

            _db.Contacts.Add(newContact);
            _db.SaveChanges();
            TempData["Message"] = "Gửi liên hệ thành công";
            return RedirectToAction("Contact");
        }
    }
}
