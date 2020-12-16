﻿using FluentValidation;
using merigurumi.blog.DTO.DTOs.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace merigurumi.blog.Business.ValidationRules.FluentValidation
{
    public class CategoryAddValidator : AbstractValidator<CategoryAddDto>
    {
        public CategoryAddValidator()
        {
            RuleFor(I => I.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");

        }
    }
}
