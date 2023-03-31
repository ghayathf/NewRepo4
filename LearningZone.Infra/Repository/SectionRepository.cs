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
    public class SectionRepository: ISectionRepository
    {
        private readonly IDbContext dbContext;
        public SectionRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<SecInfo> GetSecInfos(int SecId)
        {
            var p = new DynamicParameters();
            p.Add("SecId", SecId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<SecInfo> result = dbContext.Connection.Query<SecInfo>("Final_Section_Package.GETINFO",
                p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        public void CreateSection(FinalSection section)
        {
            var p = new DynamicParameters();
            p.Add("start_time", section.Starttime, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("end_time", section.Endtime, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("start_date", section.Startdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("end_date", section.Enddate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("url_meeting", section.Meetingurl, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("capacity_section", section.Sectioncapacity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("courseid", section.Course_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("trainerid", section.Trainer_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Final_Section_Package.CreateSection", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteSection(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_Section_Package.DeleteSection", p, commandType: CommandType.StoredProcedure);
        }

        public async Task<List<FinalSection>> GetAllSections()
        {
                var p = new DynamicParameters();
                var result = await dbContext.Connection.QueryAsync<FinalSection, FinalMaterial, FinalTraineesection,
                FinalSection>("Final_Section_Package.GetAllSections",
                (section, Material, ts) =>
                {
                    section.FinalMaterials.Add(Material);
                    section.FinalTraineesections.Add(ts);
                    return section;
                },
                splitOn: "Sectionid,Materialid,Tsid"
                ,
                param: null,
                commandType: CommandType.StoredProcedure
                );


                var results = result.GroupBy(p => p.Sectionid).Select(g =>
                {
                    var groupedPost = g.First();
                    groupedPost.FinalMaterials = g.Select(p => p.FinalMaterials.Single()).ToList();
                    groupedPost.FinalTraineesections = g.Select(p => p.FinalTraineesections.Single()).ToList();
                    return groupedPost;
                });
                return results.ToList();
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
            p.Add("start_time", section.Starttime, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("end_time", section.Endtime, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("start_date", section.Startdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("end_date", section.Enddate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("url_meeting", section.Meetingurl, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("capacity_section", section.Sectioncapacity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("courseid", section.Course_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("trainerid", section.Trainer_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Final_Section_Package.UpdateSection", p, commandType: CommandType.StoredProcedure);
        }
    }
}
