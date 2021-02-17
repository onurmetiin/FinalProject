using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty(); //boş olamaz
            RuleFor(p => p.ProductName).MinimumLength(2); //min ürün adı 2 karakter
            RuleFor(p => p.UnitPrice).NotEmpty().When(p => p.CategoryId == 1); //catId 1 ise boş olamaz
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1).WithMessage("hata mesajı");
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("ürünler a harfi ile başlamalı");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
