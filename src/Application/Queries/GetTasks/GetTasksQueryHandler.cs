using MediatR;

namespace Application.Queries.GetTasks
{
    public class GetTasksQueryHandler : IRequestHandler<GetTasksQuery, GetTasksQueryResponse>
    {
        public async Task<GetTasksQueryResponse> Handle(GetTasksQuery request, CancellationToken cancellationToken)
        {
            // implement your logic to get tasks here
            // For demonstration, returning a static list of tasks
            var result = new GetTasksQueryResponse
            {
                Data = [],
                PageCount = 0,
                PageNumber = 1,
                PageSize = 5
            };
            return await Task.FromResult(result);
        }
    }
}
