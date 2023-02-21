using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class CategoryService : ICategoryService
    {
        public readonly ICategoryRepository categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void CreateCategory(FinalCategory finalCategory)
        {
            categoryRepository.CreateCategory(finalCategory);
        }

        public void DeleteCategory(int id)
        {
            categoryRepository.DeleteCategory(id);
        }

        public List<FinalCategory> GetAllCategories()
        {
            return categoryRepository.GetAllCategories();
        }

        public FinalCategory GetCategoryById(int id)
        {
            return categoryRepository.GetCategoryById(id);
        }

        public void UpdateCategory(FinalCategory finalCategory)
        {
            categoryRepository.UpdateCategory(finalCategory);
        }
    }
}
