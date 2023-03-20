using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using LearningZone.Infra.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

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
        public Task<List<FinalCategory>> GetAllCategories()
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

        [Route("UploadImage")]
        [HttpPost]
        public FinalCategory UploadImage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullpath = Path.Combine("C:\\LearningHub_Angular\\src\\assets\\HomeAssets\\images", fileName);

            using (var stream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            FinalCategory item = new FinalCategory();
            item.Categoryimage = fileName;

            return item;
        }
    }
}
