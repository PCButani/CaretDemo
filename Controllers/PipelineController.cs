using DataSync.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataSync.Web.Controllers
{
    public class PipelineController : Controller
    {
        public IActionResult Index()
        {
            // TEMP sample data (we’ll replace with DB later)
            var projects = new List<ProjectListItemVm>
            {
                new ProjectListItemVm
                {
                    ProjectCode = "DMT-1024",
                    ClientName = "Acme Retail UK",
                    Platform = "ZolaSuite",
                    Status = "Ready to go",
                    Owner = "Dhaval",
                    LastRunUtc = DateTime.UtcNow.AddHours(-6),
                    ProgressPercent = 62,
                    Risk = "Amber"
                },
                new ProjectListItemVm
                {
                    ProjectCode = "DMT-1027",
                    ClientName = "BlueMart",
                    Platform = "Shopify",
                    Status = "Queued",
                    Owner = "Team A",
                    LastRunUtc = null,
                    ProgressPercent = 0,
                    Risk = "Green"
                },
                new ProjectListItemVm
                {
                    ProjectCode = "DMT-1011",
                    ClientName = "Legacy CRM Migration",
                    Platform = "Custom/CSV",
                    Status = "Planned",
                    Owner = "SQL Team",
                    LastRunUtc = DateTime.UtcNow.AddDays(-2),
                    ProgressPercent = 100,
                    Risk = "Green"
                }
            };

            return View(projects);
        }

        // TEMP TEST (to confirm controller is loading)
        public IActionResult Test()
        {
            return Content("Pipeline controller is running");
        }
    }
}
