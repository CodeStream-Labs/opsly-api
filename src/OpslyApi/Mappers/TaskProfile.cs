using Application.Queries.GetTasks;
using AutoMapper;
using OpslyApi.DTOs.Tasks;

namespace OpslyApi.Mappers
{
    public class TaskProfile : Profile
    {
        public TaskProfile()
        {
            CreateMap<GetTaskFiltersRequest, GetTaskFilter>();
        }
    }
}
