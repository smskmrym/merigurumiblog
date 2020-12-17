using FluentValidation;
using merigurumi.blog.Business.concrete;
using merigurumi.blog.Business.Interfaces;
using merigurumi.blog.Business.Tools.JWTTool;
using merigurumi.blog.Business.ValidationRules.FluentValidation;
using merigurumi.blog.DataAccess.concrete.EFCore.Repositories;
using merigurumi.blog.DataAccess.Interfaces;
using merigurumi.blog.DTO.DTOs.AppUserDtos;
using merigurumi.blog.DTO.DTOs.CategoryBlogDtos;
using merigurumi.blog.DTO.DTOs.CategoryDtos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace merigurumi.blog.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBlogDal, EfBlogRepository>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryRepository>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();

            services.AddScoped<IJwtService, JwtManager>();


            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginValidator>();
            services.AddTransient<IValidator<CategoryAddDto>, CategoryAddValidator>();
            services.AddTransient<IValidator<CategoryBlogDto>, CategoryBlogValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateValidator>();
        }
    }
}
