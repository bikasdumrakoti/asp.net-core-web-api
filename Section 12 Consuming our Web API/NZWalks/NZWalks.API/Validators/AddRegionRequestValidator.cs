﻿using FluentValidation;
using NZWalks.API.Models.DTO;

namespace NZWalks.API.Validators
{
    public class AddRegionRequestValidator : AbstractValidator<AddRegionRequestDto>
    {
        public AddRegionRequestValidator()
        {
            RuleFor(x => x.Code).NotEmpty();
            RuleFor(x => x.Code).MinimumLength(3);
            RuleFor(x => x.Code).MaximumLength(3);
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Name).MaximumLength(100);
        }
    }
}
