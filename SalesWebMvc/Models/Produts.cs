using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Products
    {
        public int Id { get; set; }
        public Department Department { get; set; }
        public string Description { get; set; }
        public double PriceSale { get; set; }
        public double PriceCost { get; set; }
        public int Quantity { get; set; }

        public Products()
        {

        }

        public Products(int id, Department department, string description, double priceSale, double priceCost, int quantity)
        {
            Id = id;
            Department = department;
            Description = description;
            PriceSale = priceSale;
            PriceCost = priceCost;
            Quantity = quantity;
        }
    }
}
