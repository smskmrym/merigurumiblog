using FluentValidation;
using merigurumi.blog.DTO.DTOs.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace merigurumi.blog.Business.ValidationRules.FluentValidation
{
    public class AppUserLoginValidator :AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginValidator()
        {
            RuleFor(I => I.UserName).NotEmpty().WithMessage("Lütfen kullanıcı adınızı giriniz");
            RuleFor(I => I.Password).NotEmpty().WithMessage("Lütfen  parolanızı giriniz");
        }
    }
}
