using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Lütfen rehber adını soyadını giriniz");
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Lütfen rehber açıklaması giriniz");
            RuleFor(x=>x.Image).NotEmpty().WithMessage("Lütfen rehber görselini giriniz");
            RuleFor(x=>x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakterden daha kısa bir rehber adı giriniz");
            RuleFor(x=>x.Name).MinimumLength(7).WithMessage("Lütfen 7 karakterden daha uzun bir rehber adı giriniz");

           
        }
    }
}
