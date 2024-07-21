using FluentValidation;

namespace CleanArchitectureApp.Application.Features.Forms.Commands.CreateForm
{
    public class CreateFormCommandValidator : AbstractValidator<CreateFormCommand>
    {
        public CreateFormCommandValidator()
        {
            RuleFor(x => x.name).NotEmpty().WithMessage("Form name required");
        }
    }
}
