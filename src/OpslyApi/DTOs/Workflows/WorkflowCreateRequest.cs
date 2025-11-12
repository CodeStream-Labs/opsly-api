namespace OpslyApi.DTOs.Workflows
{
    public class WorkflowCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Tasks { get; set; }
        public OnFailureAction OnFailure { get; set; }
    }
    
    public class OnFailureAction
    {
        public string Strategy { get; set; }
        public string RollbackDepth { get; set; }
    }
}