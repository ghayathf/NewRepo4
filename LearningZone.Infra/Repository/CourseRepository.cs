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
            p.Add("CatID", finalCourse.CategoryId, DbType.Int32, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Final_Course_Package.CREATECourse", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteCourse(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, DbType.Int32, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Final_Course_Package.DELETECourse", p, commandType: CommandType.StoredProcedure);
        }

        public List<FinalCourse> GetAllCourses()
        {
            IEnumerable<FinalCourse> courses = dbContext.Connection.Query<FinalCourse>("Final_Course_Package.GETALLCourses"
                , commandType: CommandType.StoredProcedure);
            return courses.ToList();
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
            p.Add("CatID", finalCourse.CategoryId, DbType.Int32, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Final_Course_Package.UpdateCourse", p, commandType: CommandType.StoredProcedure);
        }
    }
}
