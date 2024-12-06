using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AllDtos
{
    public class ProductDto:BaseDto
    {
        public string Name { get; set; }
        public string Explanation { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public string PhotoUrl { get; set; }
        public int UserId { get; set; }
        public UserDto UserDto { get; set; }
        public List<UserBasketDto> UserBasketDtos { get; set; }
    }
}
