using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductService _productService;
        private readonly DepartmentService _departmentService;

        public ProductsController(ProductService productService, DepartmentService departmentService)
        {
            _productService = productService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var list = _productService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var department = _departmentService.FindAll();
            var viewModel = new ProductsFormViewModel { Department = department };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            _productService.Insert(product);
            return RedirectToAction(nameof(Index));
        }

       /* public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _productService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _productService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _productService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }*/
    }
}