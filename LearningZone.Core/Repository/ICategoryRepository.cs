using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Repository
{
    public interface ICategoryRepository
    {
        List<FinalCategory> GetAllCategories();
        FinalCategory GetCategoryById(int id);
        void CreateCategory(FinalCategory finalCategory);
        void UpdateCategory(FinalCategory finalCategory);
        void DeleteCategory(int id);
    }
}
