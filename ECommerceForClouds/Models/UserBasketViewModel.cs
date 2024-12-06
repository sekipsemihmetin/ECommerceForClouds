using BLL.AllDtos;

namespace ECommerceForClouds.Models
{
    public class UserBasketViewModel
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public UserViewModel UserViewModel { get; set; }
        public ProductViewModel ProductViewModel { get; set; }
    }
}
