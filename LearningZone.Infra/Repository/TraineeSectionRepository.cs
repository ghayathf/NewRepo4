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
    public class TraineeSectionRepository : ITraineeSectionRepository
    {
        private readonly IDbContext dbContext;
        public TraineeSectionRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CREATETraineeSection(FinalTraineesection traineesection)
        {
            var p = new DynamicParameters();
            p.Add("TSMark", 0, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("TSAttendance", traineesection.Totalattendance, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("TSStatus", traineesection.T_S_Status, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("TID",traineesection.Trainee_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("SecID", traineesection.Section_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_TraineeSection_Package.CREATETraineeSection", p, commandType: CommandType.StoredProcedure);

        }
       
        public void DELETETraineeSection(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_TraineeSection_Package.DELETETraineeSection", p, commandType: CommandType.StoredProcedure);
        }

        public async Task<List<FinalTraineesection>> GETALLTraineeSections()
        {
            var p = new DynamicParameters();
            var result = await dbContext.Connection.QueryAsync<FinalTraineesection, FinalCertificate,FinalSolution,
            FinalTraineesection>("Final_TraineeSection_Package.GETALLTraineeSections",
            (TS, certificate, solution) =>
            {
                TS.FinalCertificates.Add(certificate);
                TS.FinalSolutions.Add(solution);
                return TS;
            },
            splitOn: "Tsid,Certificateid,Solutionid"
            ,
            param: null,
            commandType: CommandType.StoredProcedure
            );


            var results = result.GroupBy(p => p.Tsid).Select(g =>
            {
                var groupedPost = g.First();
                groupedPost.FinalCertificates = g.Select(p => p.FinalCertificates.Single()).ToList();
                groupedPost.FinalSolutions = g.Select(p => p.FinalSolutions.Single()).ToList();
                return groupedPost;
            });
            return results.ToList();
        }

        public FinalTraineesection GetTraineeSectionByID(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<FinalTraineesection> result = dbContext.Connection.Query<FinalTraineesection>("Final_TraineeSection_Package.GetTraineeSectionByID",
                p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public void UpdateTraineeSection(FinalTraineesection traineesection)
        {
            var p = new DynamicParameters();
            p.Add("IDD", traineesection.Tsid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("TSMark", traineesection.Totalmark, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("TSAttendance", traineesection.Totalattendance, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("TSStatus", traineesection.T_S_Status, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("TID", traineesection.Trainee_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("SecID", traineesection.Section_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_TraineeSection_Package.UpdateTraineeSection", p, commandType: CommandType.StoredProcedure);
        }
    }
}
