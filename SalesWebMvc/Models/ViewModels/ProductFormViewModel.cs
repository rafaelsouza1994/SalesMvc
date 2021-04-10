using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class ProductsFormViewModel
    {
        public Product Product { get; set; }
        public ICollection<Department> Department { get; set; }
    }
}