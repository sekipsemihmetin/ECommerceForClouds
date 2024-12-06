using AutoMapper;
using BLL.Abstract_Services;
using BLL.AllDtos;
using DAL.Abstarct_Repositories;
using DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete_Services
{
    public class ProductService : IProductService
    {
        
        private readonly IGenericRepository<Product> _genericRepository;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> genericRepository,IMapper mapper)
        {
           
            _genericRepository = genericRepository;
           _mapper = mapper;
        }
        public async Task AddProductAsync(ProductDto productDto)
        {
            await _genericRepository.AddAsync(_mapper.Map<Product>(productDto));
        }

        public async Task<List<ProductDto>> GelAllProductsAsync()
        {
            var getall = await _genericRepository.GetAllAsync();
            return _mapper.Map<List<ProductDto>>(getall);
        }

     
       
    }
}
