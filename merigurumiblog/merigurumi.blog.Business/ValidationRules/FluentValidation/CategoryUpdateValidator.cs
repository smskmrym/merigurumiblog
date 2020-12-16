using FluentValidation;
using merigurumi.blog.DTO.DTOs.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace merigurumi.blog.Business.ValidationRules.FluentValidation
{
    public class CategoryUpdateValidator : AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(0, int.MaxValue).WithMessage("Id alanı boş geçilemez");
            RuleFor(I => I.Name).NotEmpty().WithMessage("ad alanı boş geçilemez");


        }


    }
}
