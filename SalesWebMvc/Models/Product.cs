using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double PriceSale { get; set; }
        public double PriceCost { get; set; }
        public int Quantity { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Product()
        {
        }

        public Product(int id, string description, double priceSale, double priceCost, int quantity, Department department)
        {
            Id = id;
            Description = description;
            PriceSale = priceSale;
            PriceCost = priceCost;
            Quantity = quantity;
            Department = department;
        }
    }
}
