using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidationDeneme.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(P => P.Name).NotEmpty().WithMessage("Name alanını boş bırakmayınız")
                .MaximumLength(10).WithMessage("Name alanı en fazla 10 karakter olmalı")
                .MinimumLength(5).WithMessage("Name alanı en az 5 karakter olmalı");
        }
    }
}
