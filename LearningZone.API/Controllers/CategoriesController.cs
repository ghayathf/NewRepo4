using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using LearningZone.Infra.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LearningZone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [HttpPost]
        [Route("CreateCategory")]
        public void CreateCategory(FinalCategory finalCategory)
        {
            categoryService.CreateCategory(finalCategory);
        }
        [HttpDelete]
        [Route("DeleteCategory/{id}")]
        public void DeleteCategory(int id)
        {
            categoryService.DeleteCategory(id);
        }
        [HttpGet]
        [Route("GetAllCategories")]
        public List<FinalCategory> GetAllCategories()
        {
            return categoryService.GetAllCategories();
        }
        [HttpGet]
        [Route("GetCategoryById/{id}")]
        public FinalCategory GetCategoryById(int id)
        {
            return categoryService.GetCategoryById(id);
        }
        [HttpPut]
        [Route("UpdateCategory")]
        public void UpdateCategory(FinalCategory finalCategory)
        {
            categoryService.UpdateCategory(finalCategory);
        }
    }
}
