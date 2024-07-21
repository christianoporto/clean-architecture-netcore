using FluentValidation;

namespace CleanArchitectureApp.Application.Features.Forms.Queries.GetFormList
{
    public class GetFormListQueryValidator : AbstractValidator<GetFormListQuery>
    {
        public GetFormListQueryValidator()
        {
            RuleFor(x => x.accountId)
                .NotEmpty().WithMessage("AccountId is required.");
        }
    }
}
