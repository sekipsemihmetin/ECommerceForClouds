namespace ECommerceForClouds.Models
{
    public class BaseViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
