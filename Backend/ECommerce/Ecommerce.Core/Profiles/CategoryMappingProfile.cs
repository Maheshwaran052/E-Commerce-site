using Ecommerce.Core.DTOs.Categories;
using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Ecommerce.Core.DTOs;

namespace Ecommerce.Core.Profiles
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<CreateCategoryDto, Category>();
            CreateMap<UpdateCategoryDto, Category>();
            CreateMap<Category, CategoryResponseDto>();
            CreateMap<Category, CategoryWithProductsDto>();
        }
    }
}
