using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Validators
{
    public class CardValidator : AbstractValidator<Card>
    {
        public CardValidator()
        {
            RuleFor(c => c.titulo)
                .NotEmpty().WithMessage("É necessário digitar o Título.")
                .NotNull().WithMessage("É necessário digitar o Título.");

            RuleFor(c => c.descricao)
                    .NotEmpty().WithMessage("É necessário informar a Descrição.")
                    .NotNull().WithMessage("É necessário informar a Descrição.");

            RuleFor(c => c.link)
                    .NotEmpty().WithMessage("É necessário informar um link.")
                    .NotNull().WithMessage("É necessário informarum link.");
            RuleFor(c => c.imagem)
                    .NotEmpty().WithMessage("É necessário adicionar uma imagem.")
                    .NotNull().WithMessage("É necessário adicionar uma imagem.");
        }
    }
}


