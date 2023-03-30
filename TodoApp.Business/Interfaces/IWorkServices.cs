using TodoApp.Common.ResponseObjects;
using TodoApp.Dtos.WorkDtos;

namespace TodoApp.Business.Interfaces
{
    public interface IWorkServices
    {
        Task<IResponse<List<WorkListDto>>> GetAll();
        Task<IResponse<WorkCreateDto>> Create(WorkCreateDto dto);
        Task<IResponse<IDto>> GetById<IDto>(int id);
        Task<IResponse> Remove(int id);
        Task<IResponse<WorkUpdateDto>> Update(WorkUpdateDto dto);
    }
}
