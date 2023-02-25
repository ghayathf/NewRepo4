using Dapper;
using LearningZone.Core.Common;
using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Infra.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDbContext dbContext;
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

        public async Task<List<FinalCategory>> GetAllCategories()
        {
            var p = new DynamicParameters();
            var result = await dbContext.Connection.QueryAsync<FinalCategory, FinalCourse,
            FinalCategory>("Final_category_Package.GetAllCategory",
            (category, course) =>
            {
                category.FinalCourses.Add(course);
                return category;
            },
            splitOn: "Categoryid , Courseid"
            ,
            param: null,
            commandType: CommandType.StoredProcedure
            );


            var results = result.GroupBy(p => p.Categoryid).Select(g =>
            {
                var groupedPost = g.First();
                groupedPost.FinalCourses = g.Select(p => p.FinalCourses.Single()).ToList();
                return groupedPost;
            });
            return results.ToList();
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
