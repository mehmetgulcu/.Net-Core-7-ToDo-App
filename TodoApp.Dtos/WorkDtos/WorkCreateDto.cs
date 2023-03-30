using System.ComponentModel.DataAnnotations;
using TodoApp.Dtos.Interfaces;

namespace TodoApp.Dtos.WorkDtos
{
    public class WorkCreateDto : IDto
    {
        [Required(ErrorMessage = "Açıklama alanı boş bırakılamaz !")]
        public string Definition { get; set; }
        public bool IsCompleted { get; set; }
    }

}
