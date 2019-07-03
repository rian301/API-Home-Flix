﻿using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Can't found the object.");
                });

            RuleFor(c => c.Cpf)
                .NotEmpty().WithMessage("É necessário digitar o CPF.")
                .NotNull().WithMessage("É necessário digitar o CPF.");

            RuleFor(c => c.DataNascimento)
                .NotEmpty().WithMessage("É necessário informar a data de nacimento.")
                .NotNull().WithMessage("É necessário informar a data de nacimento.");

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("É necessário informar o nome.")
                .NotNull().WithMessage("É necessário informar o nome.");
        }
    }
}
