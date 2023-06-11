using Microsoft.AspNetCore.Mvc;

namespace ASP_.NET_MVC.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Error404()
        {
            return View();
        }
    }
}
