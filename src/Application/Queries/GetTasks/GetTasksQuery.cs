using MediatR;

namespace Application.Queries.GetTasks
{
    public class GetTasksQuery : IRequest<GetTasksQueryResponse>
    {
        public GetTaskFilter Filters { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public GetTasksQuery(GetTaskFilter filters, int pageSize = 5, int pageNumber = 1)
        {
            Filters = filters;
            PageSize = pageSize;
            PageNumber = pageNumber;
        }
    }

    public class GetTaskFilter
    {
        public string Status { get; set; }
        public DateTime? CreatedAfter { get; set; }
        public DateTime? CreatedBefore { get; set; }
        public string Owner { get; set; }
    }
}
