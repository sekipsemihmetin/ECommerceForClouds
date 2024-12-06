using AutoMapper;
using BLL.AllDtos;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperProfiles
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product,ProductDto>().ReverseMap();
            CreateMap<User,UserDto>().ReverseMap();
            CreateMap<UserBasket,UserBasketDto>().ReverseMap();
        }
    }
}
