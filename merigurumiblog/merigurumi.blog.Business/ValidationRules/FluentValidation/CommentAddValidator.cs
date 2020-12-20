using FluentValidation;
using merigurumi.blog.DTO.DTOs.CommentDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace merigurumi.blog.Business.ValidationRules.FluentValidation
{
    public class CommentAddValidator : AbstractValidator<CommentAddDto>
    {
        public CommentAddValidator()
        {
            RuleFor(I => I.AuthorName).NotEmpty().WithMessage("Lütfen adınızı giriniz");
            RuleFor(I => I.AuthorEmail).NotEmpty().WithMessage("Lütfen mailinizi giriniz");
            RuleFor(I => I.Description).NotEmpty().WithMessage("Lütfen açıklama giriniz");

        }
    }
}
