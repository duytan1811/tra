using Microsoft.AspNetCore.Mvc;

namespace Travel_ASP.Controllers
{
    [Route("admin/dashboard")]
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
