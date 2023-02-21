using Dapper;
using LearningZone.Core.Common;
using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LearningZone.Infra.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public readonly IDbContext dbContext;
        public CategoryRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateCategory(FinalCategory finalCategory)
        {
            var p = new DynamicParameters();
            p.Add("cat_name", finalCategory.Categoryname, DbType.String, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Final_category_Package.CreateCategory", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteCategory(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, DbType.Int32, direction: ParameterDirection.Input);
            dbContext.Connection.Execute("Final_category_Package.DeleteCategory", p, commandType: CommandType.StoredProcedure);
        }

        public List<FinalCategory> GetAllCategories()
        {
            IEnumerable<FinalCategory> categories = dbContext.Connection.Query<FinalCategory>("Final_category_Package.GetAllCategory"
                , commandType: CommandType.StoredProcedure);
            return categories.ToList();
        }

        public FinalCategory GetCategoryById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<FinalCategory> categories = dbContext.Connection.Query<FinalCategory>("Final_category_Package.GetCategoryById", p
                , commandType: CommandType.StoredProcedure);
            return categories.FirstOrDefault();
        }

        public void UpdateCategory(FinalCategory finalCategory)
        {
            var p = new DynamicParameters();
            p.Add("id", finalCategory.Categoryid, DbType.Int32, direction: ParameterDirection.Input);
            p.Add("cat_name", finalCategory.Categoryname, DbType.String, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Final_category_Package.UpdateCategory", p, commandType: CommandType.StoredProcedure);
        }
    }
}
