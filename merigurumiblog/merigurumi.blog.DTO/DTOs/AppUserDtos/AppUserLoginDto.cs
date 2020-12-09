using merigurumi.blog.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace merigurumi.blog.DTO.DTOs.AppUserDtos
{
    public class AppUserLoginDto :IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
