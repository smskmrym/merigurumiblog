﻿using merigurumi.blog.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace merigurumi.blog.DTO.DTOs.CategoryDtos
{
    public class CategoryAddDto :IDto
    {
        public string Name { get; set; }
    }
}
