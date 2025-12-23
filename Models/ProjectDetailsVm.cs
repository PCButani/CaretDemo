namespace DataSync.Web.Models.ViewModels
{
    public class ProjectDetailsVm
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string ClientName { get; set; } = "";
        public string SourcePlatform { get; set; } = "";
        public string TargetPlatform { get; set; } = "";
        public string Status { get; set; } = "";          // e.g., "Active", "Paused", "Completed"
        public string Health { get; set; } = "";          // e.g., "Good", "Warning", "Critical"
        public string Owner { get; set; } = "";
        public string Environment { get; set; } = "";     // e.g., "UAT", "PROD"
        public string LastRunText { get; set; } = "";     // e.g., "Today, 09:10"
        public string NextRunText { get; set; } = "";     // e.g., "Tomorrow, 01:00"
        public int PipelinesTotal { get; set; }
        public int PipelinesSucceeded { get; set; }
        public int PipelinesFailed { get; set; }
        public int ExceptionsOpen { get; set; }
        public int RulesTotal { get; set; }
        public int RulesFailed { get; set; }
    }
}
