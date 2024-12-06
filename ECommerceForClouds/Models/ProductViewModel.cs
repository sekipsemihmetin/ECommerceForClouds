using BLL.AllDtos;

namespace ECommerceForClouds.Models
{
    public class ProductViewModel:BaseViewModel
    {
        public string Name { get; set; }
        public string Explanation { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public IFormFile? Photo { get; set; }
        public string? PhotoUrl { get; set; }
        public int UserId { get; set; }
        
        public UserViewModel? UserViewModel { get; set; }
        public List<UserBasketViewModel>? UserBasketViewModels { get; set; }
    }
}
