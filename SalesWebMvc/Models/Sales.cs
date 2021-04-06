using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models.ViewModels;

namespace SalesWebMvc.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public Seller Seller { get; set; }
        public double ValueSale { get; set; }
        DateTime DateTimeSale { get; set; }
        public int Quantity { get; set; }
        /*public ICollection<SalesRecord> Sellers { get; set; } = new List<Seller>();*/

        public Sales()
        {

        }

        public Sales(int id, Seller seller, double valueSale, DateTime dateTimeSale, int quantity)
        {
            Id = id;
            Seller = seller;
            ValueSale = valueSale;
            DateTimeSale = dateTimeSale;
            Quantity = quantity;
        }



     /*   public void AddSales(SalesRecord sr)
        {
            Products.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }*/

    }
}
