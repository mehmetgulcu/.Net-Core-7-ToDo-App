using FluentValidation;
using TodoApp.Dtos.WorkDtos;

namespace TodoApp.Business.ValidationRules
{
    public class WorkCreateDtoValidator : AbstractValidator<WorkCreateDto>
    {
        public WorkCreateDtoValidator()
        {
            RuleFor(x => x.Definition).NotEmpty().WithMessage("İş tanımı boş geçilemez.").MinimumLength(3).WithMessage("En az 3 karakter giriniz.").MaximumLength(150);
        }
    }
}
