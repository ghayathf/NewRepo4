using Dapper;
using LearningZone.Core.Common;
using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using LearningZone.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Infra.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly IDbContext dbContext;
        public CourseRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateCourse(FinalCourse finalCourse)
        {
            var p = new DynamicParameters();
            p.Add("CourseN", finalCourse.Coursename, DbType.String, direction: ParameterDirection.Input);
            p.Add("CourseD", finalCourse.Coursedescription, DbType.String, direction: ParameterDirection.Input);
            p.Add("CourseImg", finalCourse.Courseimage, DbType.String, direction: ParameterDirection.Input);
            p.Add("CourseLev", finalCourse.Courselevel, DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CatID", finalCourse.category_Id, DbType.Int32, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Final_Course_Package.CREATECourse", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteCourse(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, DbType.Int32, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Final_Course_Package.DELETECourse", p, commandType: CommandType.StoredProcedure);
        }

        public async Task<List<FinalCourse>> GetAllCourses()
        {
            var p = new DynamicParameters();
            var result = await dbContext.Connection.QueryAsync<FinalCourse, FinalSection,
            FinalCourse>("Final_Course_Package.GETALLCourses",
            (course, section) =>
            {
                course.FinalSections.Add(section);
                return course;
            },
            splitOn: "CourseId , SectionId"
            ,
            param: null,
            commandType: CommandType.StoredProcedure
            );


            var results = result.GroupBy(p => p.Courseid).Select(g =>
            {
                var groupedPost = g.First();
                groupedPost.FinalSections = g.Select(p => p.FinalSections.Single()).ToList();
                return groupedPost;
            });
            return results.ToList();
        }

        public FinalCourse GetCourseById(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<FinalCourse> courses = dbContext.Connection.Query<FinalCourse>("Final_Course_Package.GetCourseByID",p
                , commandType: CommandType.StoredProcedure);
            return courses.FirstOrDefault();
        }

        public void UpdateCourse(FinalCourse finalCourse)
        {
            var p = new DynamicParameters();
            p.Add("IDD", finalCourse.Courseid, DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CourseN", finalCourse.Coursename, DbType.String, direction: ParameterDirection.Input);
            p.Add("CourseD", finalCourse.Coursedescription, DbType.String, direction: ParameterDirection.Input);
            p.Add("CourseImg", finalCourse.Courseimage, DbType.String, direction: ParameterDirection.Input);
            p.Add("CourseLev", finalCourse.Courselevel, DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CatID", finalCourse.category_Id, DbType.Int32, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Final_Course_Package.UpdateCourse", p, commandType: CommandType.StoredProcedure);
        }
        public List<SearchCourse> SearcheStudenCourse(SearchCourse searchCourse)
        {
            var p = new DynamicParameters();
            p.Add("course_name", searchCourse.Coursename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("course_level", searchCourse.Courselevel, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("category_name", searchCourse.Categoryname, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Query<SearchCourse>("Final_Course_Package.SearchCourse", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
