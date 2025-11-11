namespace OpslyApi.DTOs.Workflows
{
    public class WorkflowFiltersRequest
    {
        public string Status { get; set; }
        public DateTime? CreatedAfter { get; set; }
        public DateTime? CreatedBefore { get; set; }
        public string Owner { get; set; }
    }
}