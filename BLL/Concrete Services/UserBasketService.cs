using AutoMapper;
using BLL.Abstract_Services;
using BLL.AllDtos;
using DAL.Abstarct_Repositories;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete_Services
{
    public class UserBasketService : IUserBasketService
    {
        private readonly IGenericRepository<UserBasket> _genericRepository;
        private readonly IMapper _mapper;

        public UserBasketService(IGenericRepository<UserBasket> genericRepository,IMapper mapper )
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }
        public async Task AddUserBasketAsync(UserBasketDto userBasketDto)
        {
            await _genericRepository.AddAsync(_mapper.Map<UserBasket>(userBasketDto));
        }
    }
}
