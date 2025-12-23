using Application.Common;

namespace Application.Queries.GetTasks
{
    public class GetTasksQueryResponse : Paginnation
    {
        public List<object> Data { get; set; }
    }
}
