namespace OpslyApi.DTOs.Tasks
{
    public class TaskFiltersRequest
    {
        public string Status { get; set; }
        public DateTime? CreatedAfter { get; set; }
        public DateTime? CreatedBefore { get; set; }
        public string Owner { get; set; }
    }
}