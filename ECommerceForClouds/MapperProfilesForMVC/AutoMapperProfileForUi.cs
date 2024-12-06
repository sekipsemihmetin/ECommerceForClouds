using AutoMapper;
using BLL.AllDtos;
using DAL.Entities;
using ECommerceForClouds.Models;

namespace ECommerceForClouds.MapperProfilesForMVC
{
    public class AutoMapperProfileForUi:Profile
    {
        public AutoMapperProfileForUi()
        {
            CreateMap<UserViewModel, UserDto>().ReverseMap();
            CreateMap<ProductViewModel, ProductDto>().ReverseMap();
            CreateMap<UserBasketViewModel,UserBasketDto >().ReverseMap();
        }
    }
}
