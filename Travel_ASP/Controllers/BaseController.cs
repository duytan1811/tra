using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Travel_ASP.Common;

namespace Travel_ASP.Controllers
{
    public class BaseController : Controller
    {
        public CurrentUser CurrentUser { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
    }

}
