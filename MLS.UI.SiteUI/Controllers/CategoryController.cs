using Microsoft.AspNetCore.Mvc;
using MLS.Core.ApplicationServices;

namespace MLS.UI.SiteUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ProductCategoryService _productCategoryService;

        public CategoryController(ProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        public IActionResult Index()
        {
            string categoryName = $"Category{DateTime.Now.Ticks}";
            _productCategoryService.CreateCategory(categoryName);
            return View();
        }
    }
}
