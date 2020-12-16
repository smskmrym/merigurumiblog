using merigurumi.blog.Business.Interfaces;
using merigurumi.blog.DataAccess.Interfaces;
using merigurumi.blog.DTO.DTOs.AppUserDtos;
using merigurumi.blog.Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace merigurumi.blog.Business.concrete
{
    public class AppUserManager : GenericManager<AppUser>, IAppUserService
    {
        private readonly IGenericDal<AppUser> _genericDal;
        public AppUserManager(IGenericDal<AppUser> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto)
        {
            return await _genericDal.GetAsync(I => I.UserName == appUserLoginDto.UserName && I.Password == appUserLoginDto.Password);

        }

        public async Task<AppUser> FindByNameAsync(string userName)
        {
            return await _genericDal.GetAsync(I => I.UserName == userName);

        }
    }
}
