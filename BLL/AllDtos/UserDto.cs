using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AllDtos
{
    public class UserDto:BaseDto
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public List<ProductDto> ProductDtos { get; set; }
        public List<UserBasketDto> UserBasketDtos { get; set; }
    }
}
