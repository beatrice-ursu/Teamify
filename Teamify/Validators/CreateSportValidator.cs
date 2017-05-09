using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using Teamify.Models.Sport;

namespace Teamify.Validators
{
    public class CreateSportValidator: AbstractValidator<CreateSportModel>
    {
        public CreateSportValidator()
        {
            RuleFor(x => x.NewSportName).NotEmpty().WithMessage("Name is required!");
            RuleFor(x => x.NewSportDescription).NotEmpty().WithMessage("Description is requried!");
            RuleFor(x => x.NewSportRules).NotEmpty().WithMessage("Rules are required!");
        }
    }
}