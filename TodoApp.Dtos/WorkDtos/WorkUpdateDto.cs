using TodoApp.Dtos.Interfaces;

namespace TodoApp.Dtos.WorkDtos
{
    public class WorkUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public bool IsCompleted { get; set; }
    }
}
