﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Template.Domain.Models;

namespace Template.Api.Validators
{
    public class SimpleMessageCreateRequestValidator : AbstractValidator<SimpleMessageCreateRequest>
    {
        public SimpleMessageCreateRequestValidator()
        {
            RuleFor(msg => msg.Title)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty();
            RuleFor(msg => msg.Body).Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty();
        }
    }
}
