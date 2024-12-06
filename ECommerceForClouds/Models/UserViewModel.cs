using BLL.AllDtos;

namespace ECommerceForClouds.Models
{
    public class UserViewModel:BaseViewModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public List<ProductViewModel> ProductViewModels { get; set; }
        public List<UserBasketViewModel>  UserBasketViewModels { get; set; }
    }
}
