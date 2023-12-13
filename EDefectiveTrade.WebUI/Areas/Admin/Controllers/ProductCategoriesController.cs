using EDefectiveTrade.Business.DTOs.ProductCategory;
using EDefectiveTrade.Business.Services.Interfaces;
using EDefectiveTrade.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EDefectiveTrade.WebUI.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ProductCategoriesController : Controller
    {
        private readonly IProductCategoryService _service;
        public ProductCategoriesController(IProductCategoryService service)
        {
            _service = service;
        }


        public async Task< IActionResult> Index()
        {
            List<ProductCategoryDTO> categories=await _service.GetListAsync();

            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> Create(ProductCategoryDTO model)
        {
          var item=  await _service.AddAsync(model);
            if (item != null)
            {
                TempData["success"] = "Kateqoriya uğurla əlavə edildi.";
                return RedirectToAction("Index");
            }
            return View(item);
        }
    }
}
