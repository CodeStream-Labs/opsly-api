namespace OpslyApi.DTOs.Tasks
{
    public class TaskCreateRequest
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Config Config { get; set; }
        public RetryPolicy RetryPolicy { get; set; }
        public RollbackAction RollbackAction { get; set; }
        public List<string> DependsOn { get; set; }
    }

    public class RollbackAction
    {
        public string Command { get; set; }
    }

    public class Config
    {
        public string Command { get; set; }
        public string Target { get; set; }
    }

    public class RetryPolicy
    {
        public int MaxAttempts { get; set; }
        public int DelaySeconds { get; set; }
    }
}