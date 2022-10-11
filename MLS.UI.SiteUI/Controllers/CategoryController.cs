using Microsoft.AspNetCore.Mvc;
using MLS.Core.ApplicationServices;

namespace MLS.UI.SiteUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly TaskCategoryService _taskCategoryService;

        public CategoryController(TaskCategoryService taskCategoryService)
        {
            _taskCategoryService = taskCategoryService;
        }

        public IActionResult Index()
        {
            string categoryName = $"Category{DateTime.Now.Ticks}";
            _taskCategoryService.CreateCategory(categoryName);
            return View();
        }
    }
}
