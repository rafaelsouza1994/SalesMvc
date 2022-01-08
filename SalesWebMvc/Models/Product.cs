using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, string description, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
