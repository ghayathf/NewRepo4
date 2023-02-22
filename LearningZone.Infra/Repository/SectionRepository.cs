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
    public class SectionRepository: ISectionRepository
    {
        private readonly IDbContext dbContext;
        public SectionRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateSection(FinalSection section)
        {
            var p = new DynamicParameters();
            p.Add("start_time", section.Starttime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("end_time", section.Endtime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("start_date", section.Startdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("end_date", section.Enddate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("url_meeting", section.Meetingurl, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("capacity_section", section.Sectioncapacity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("courseid", section.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("trainerid", section.TrainerId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Final_Section_Package.CreateSection", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteSection(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_Section_Package.DeleteSection", p, commandType: CommandType.StoredProcedure);
        }

        public List<FinalSection> GetAllSections()
        {
            IEnumerable<FinalSection> result = dbContext.Connection.Query<FinalSection>("Final_Section_Package.GetAllSections",
              commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public FinalSection GetSectionByID(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<FinalSection> result = dbContext.Connection.Query<FinalSection>("Final_Section_Package.GetSectionById",
                p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public void UpdateSection(FinalSection section)
        {
            var p = new DynamicParameters();
            p.Add("Id", section.Sectionid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("start_time", section.Starttime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("end_time", section.Endtime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("start_date", section.Startdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("end_date", section.Enddate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("url_meeting", section.Meetingurl, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("capacity_section", section.Sectioncapacity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("courseid", section.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("trainerid", section.TrainerId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Final_Section_Package.UpdateSection", p, commandType: CommandType.StoredProcedure);
        }
    }
}
