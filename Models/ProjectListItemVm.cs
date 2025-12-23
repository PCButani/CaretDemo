using System;

namespace DataSync.Web.Models
{
    public class ProjectListItemVm
    {
        public string ProjectCode { get; set; } = "";
        public string ClientName { get; set; } = "";
        public string Platform { get; set; } = "";
        public string Status { get; set; } = ""; // Queued / In Progress / Completed / Failed
        public string Owner { get; set; } = "";
        public DateTime? LastRunUtc { get; set; }
        public int ProgressPercent { get; set; }
        public string Risk { get; set; } = ""; // Green / Amber / Red
    }
}
