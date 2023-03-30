using FluentValidation;
using TodoApp.Dtos.WorkDtos;

namespace TodoApp.Business.ValidationRules
{
    public class WorkUpdateDtoValidator : AbstractValidator<WorkUpdateDto>
    {
        public WorkUpdateDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Definition).NotEmpty().WithMessage("Bu bölüm boş geçilemez.").MinimumLength(3).MaximumLength(150);
        }
    }
}
