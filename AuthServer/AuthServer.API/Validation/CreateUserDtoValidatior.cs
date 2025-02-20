﻿using AuthServer.Core.Dtos;
using FluentValidation;


namespace AuthServer.API.Validation
{
    public class CreateUserDtoValidatior : AbstractValidator<CreateUserDto>
    {
        public CreateUserDtoValidatior()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required").EmailAddress().WithMessage("Email is wrong");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Username is required");
        }
    }
}
