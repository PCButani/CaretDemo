using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using DataSync.Web.Models;              // ✅ IMPORTANT: this is where ProjectListItemVm likely lives
using DataSync.Web.Models.ViewModels;   // ✅ this is where ProjectDetailsVm lives

namespace DataSync.Web.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: /Projects
        [HttpGet]
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
                    Status = "In Progress",
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
                    Status = "Completed",
                    Owner = "SQL Team",
                    LastRunUtc = DateTime.UtcNow.AddDays(-2),
                    ProgressPercent = 100,
                    Risk = "Green"
                }
            };

            return View(projects);
        }

        // GET: /Projects/Details/1
        [HttpGet]
        public IActionResult Details(int id)
        {
            var vm = BuildProjectDetailsVm(id);
            if (vm == null) return NotFound();

            ViewData["ActiveTab"] = "Overview";
            return View(vm);
        }

        // GET: /Projects/Fetch/1
        [HttpGet]
        public IActionResult Fetch(int id)
        {
            var vm = BuildProjectDetailsVm(id);
            if (vm == null) return NotFound();

            ViewData["ActiveTab"] = "Fetch";
            return View(vm);
        }
        // =========================
        // VERIFY (Step 1)
        // =========================
        public IActionResult Process(int id)
        {
            var vm = BuildProjectDetailsVm(id);
            if (vm == null) return NotFound();

            ViewData["ActiveTab"] = "Process";

            // IMPORTANT: render Verify.cshtml, not Details.cshtml
            return View(vm); // will load Views/Projects/Verify.cshtml
        }
        public IActionResult Verify(int id)
        {
            var vm = BuildProjectDetailsVm(id);
            if (vm == null) return NotFound();

            ViewData["ActiveTab"] = "Verify";

            // IMPORTANT: render Verify.cshtml, not Details.cshtml
            return View(vm); // will load Views/Projects/Verify.cshtml
        }
        public IActionResult TransformDashboardTest()
        {
            return View();
        }
        public IActionResult IssueDetails(int id)
        {
            var vm = BuildProjectDetailsVm(id);
            if (vm == null) return NotFound();
            ViewData["ActiveTab"] = "Verify";
            // IMPORTANT: render IssueDetails.cshtml, not Details.cshtml
            return View(vm); // will load Views/Projects/IssueDetails.cshtml
        }
        public IActionResult ContactSummary(int id)
        {
            var vm = BuildProjectDetailsVm(id);
            if (vm == null) return NotFound();

            ViewData["ActiveTab"] = "Fetch";

            // IMPORTANT: render Verify.cshtml, not Details.cshtml
            return View(vm); // will load Views/Projects/Verify.cshtml
        }
        public IActionResult Config(int id)
        {
            var vm = BuildProjectDetailsVm(id);
            if (vm == null) return NotFound();

            ViewData["ActiveTab"] = "Config";

            // IMPORTANT: render Verify.cshtml, not Details.cshtml
            return View(vm); // will load Views/Projects/Verify.cshtml
        }
        public IActionResult Entityconfig(int id)
        {
            var vm = BuildProjectDetailsVm(id);
            if (vm == null) return NotFound();

            ViewData["ActiveTab"] = "Config";

            // IMPORTANT: render Verify.cshtml, not Details.cshtml
            return View(vm); // will load Views/Projects/Verify.cshtml
        }
        // --------------------------------------------
        // TEMP: mock builder (later replace with DB/ADF)
        // --------------------------------------------
        private ProjectDetailsVm BuildProjectDetailsVm(int id)
        {
            return new ProjectDetailsVm
            {
                Id = id,
                Name = $"Project #{id} – ZolaSuite Migration",
                ClientName = "ZolaSuite",
                SourcePlatform = "ZolaSuite",
                TargetPlatform = "DMT Master",
                Status = "Active",
                Health = "Good",
                Owner = "Sarah Chen",
                Environment = "UAT",
                LastRunText = "Today, 09:10",
                NextRunText = "Tomorrow, 01:00",
                PipelinesTotal = 12,
                PipelinesSucceeded = 10,
                PipelinesFailed = 2,
                ExceptionsOpen = 18,
                RulesTotal = 146,
                RulesFailed = 7
            };
        }
    }
}
