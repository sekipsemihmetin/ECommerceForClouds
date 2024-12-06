using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AllDtos
{
    public class UserBasketDto:BaseDto
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public UserDto UserDto { get; set; }
        public ProductDto ProductDto { get; set; }
    }
}
