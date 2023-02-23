using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Core.Repository
{
    public interface ICategoryRepository
    {
        Task<List<FinalCategory>> GetAllCategories();
        FinalCategory GetCategoryById(int id);
        void CreateCategory(FinalCategory finalCategory);
        void UpdateCategory(FinalCategory finalCategory);
        void DeleteCategory(int id);
    }
}
