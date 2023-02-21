using Dapper;
using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Infra.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LearningZone.Infra.Repository
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly DbContext _dbContext;
        public TestimonialRepository(DbContext  dbContext)
        {
            this._dbContext = dbContext;
        }
        public void CreateHomeTestimonial(FinalTestimonial finalTestimonial)
        {
            var p = new DynamicParameters();
            p.Add("message", finalTestimonial.Testimonialmessage, dbType: DbType.String, ParameterDirection.Input);
            p.Add("status", finalTestimonial.Testimonialstatus, dbType: DbType.String, ParameterDirection.Input);
            p.Add("USERID", finalTestimonial.UserId, dbType: DbType.String, ParameterDirection.Input);
            

            var result = _dbContext.Connection.Execute("Final_Testimonial_Package.CreateTestimonial", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteTestimonial(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int32, ParameterDirection.Input);

            var result = _dbContext.Connection.Execute("Final_Testimonial_Package.DELETETestimoniaL", p, commandType: CommandType.StoredProcedure);
        }

        public List<FinalTestimonial> GetAllTestimonial()
        {

            IEnumerable<FinalTestimonial> result = _dbContext.Connection.Query<FinalTestimonial>("Final_Testimonial_Package.GetAllTestimonial", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public FinalTestimonial GetTestimonialById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, ParameterDirection.Input);
            IEnumerable<FinalTestimonial> result = _dbContext.Connection.Query<FinalTestimonial>("Final_Testimonial_Package.GetTestimonialById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void UpdateTestimonial(FinalTestimonial finalTestimonial)
        {
            var p = new DynamicParameters();
            p.Add("id", finalTestimonial.Testimonialid, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("message", finalTestimonial.Testimonialmessage, dbType: DbType.String, ParameterDirection.Input);
            p.Add("status", finalTestimonial.Testimonialstatus, dbType: DbType.String, ParameterDirection.Input);
            p.Add("USERID", finalTestimonial.UserId, dbType: DbType.String, ParameterDirection.Input);


            var result = _dbContext.Connection.Execute("Final_Testimonial_Package.UpdateTestimonial", p, commandType: CommandType.StoredProcedure);
        }
    }
}
