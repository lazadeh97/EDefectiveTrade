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
            var categories=await _service.GetAllAsync();

            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductCategoryDTO productCategoryDTO)
        {
            var response = await _service.Create(productCategoryDTO);
            if (response !=null)
            {
                TempData["success"] = "Kateqoriya uğurla əlavə edildi.";
                return RedirectToAction("Index");
            }
            return View(response);
        }
        public async Task<IActionResult> Update(Guid id)
        {
            var category = await _service.GetByIdAsync(id);
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductCategoryDTO productCategoryDTO)
        {
            //var category = await _service.GetByIdAsync(productCategoryDTO.Id);           
            var result = await _service.Update(productCategoryDTO);
            if (result != null)
            {
                TempData["success"] = "Kateqoriya uğurla dəyişdirildi.";
                return RedirectToAction("Index");
            }
            return View(result);

        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var category = await _service.GetByIdAsync(id);

            return View(category);
        }

        //[HttpPost]
        //public async Task<IActionResult> Delete(ProductCategoryDTO entity)
        //{
        //    var result = await _service.DeleteByIdAsync(entity.Id);

        //    if (result !=null)
        //    {
        //        return Json(new { success = true, message = "Category successfully deleted." });
        //    }

        //    return Json(new { success = false, message = "Category not found or deletion failed." });
        //}

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> Delete(ProductCategoryDTO entity)
        {
            var item = await _service.DeleteByIdAsync(entity.Id);
            TempData["success"] = "Kateqoriya uğurla silindi.";
            return RedirectToAction("Index");
        }
    }
}
