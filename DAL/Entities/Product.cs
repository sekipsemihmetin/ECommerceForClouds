using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Product:BaseClass
    {
        public string Name { get; set; }
        public string Explanation { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Stock{ get; set; }
        public double Price { get; set; }
        public string PhotoUrl { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public List<UserBasket> UserBaskets { get; set; }

    }
}
