using FluentValidation;
using Teamify.Models.Sport;

namespace Teamify.Validators
{
    public class AddSportRequestValidator : AbstractValidator<AddSportRequestModel>
    {
        public AddSportRequestValidator()
        {
            RuleFor(x => x.SportName).NotEmpty().WithMessage("Name is required!");
            RuleFor(x => x.SportDescription).NotEmpty().WithMessage("Description is requried!");
            RuleFor(x => x.SportRules).NotEmpty().WithMessage("Rules are required!");
        }
    }
}