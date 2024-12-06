using BLL.AllDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract_Services
{
    public interface IProductService
    {
        Task AddProductAsync(ProductDto productDto);
        Task<List<ProductDto>> GelAllProductsAsync();
    }
}
