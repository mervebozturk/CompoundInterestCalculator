using Business.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation
{
    public class BilesikFaizValidator : AbstractValidator<BilesikFaizPayload>
    {
        public BilesikFaizValidator()
        {
            RuleFor(c => c.AnaPara).NotEmpty().WithMessage("Lütfen Ana Para Miktarını Giriniz!");
            RuleFor(c => c.Sure).NotEmpty().WithMessage("Lütfen Faiz Süresini Giriniz!");
            RuleFor(c => c.FaizOrani).NotEmpty().WithMessage("Lütfen Faiz Oranını Giriniz!");
        }
    }
}
