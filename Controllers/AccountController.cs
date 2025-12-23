using Microsoft.AspNetCore.Mvc;

namespace DataSync.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            // TODO: authentication logic
            return RedirectToAction("Index", "Pipeline");
        }
    }
}
