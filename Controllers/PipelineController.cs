using Microsoft.AspNetCore.Mvc;

namespace DataSync.Web.Controllers
{
    public class PipelineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // TEMP TEST (to confirm controller is loading)
        public IActionResult Test()
        {
            return Content("Pipeline controller is running");
        }
    }
}
