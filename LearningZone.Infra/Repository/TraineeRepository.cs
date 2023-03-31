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
    public class TraineeRepository : ITraineeRepository
    {
        private readonly IDbContext dbContext;
        public TraineeRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<TraineeInfo> GetTraineeInfosByUsd(int usid)
        {
            var p = new DynamicParameters();
            p.Add("usid", usid, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            IEnumerable<TraineeInfo> result = dbContext.Connection.Query<TraineeInfo>("Final_TraineeSection_Package.GetAllTraineeInfoByUserId ", p,
             commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        public void DELETETrainee(int IDD)
        {
            var p = new DynamicParameters();
            p.Add("IDD", IDD, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_Trainee_PACKAGE.DELETETrainee", p, commandType: System.Data.CommandType.StoredProcedure);
        }
        public List<SectionTrainees> GetSectionTrainees(int secId)
        {
            var p = new DynamicParameters();
            p.Add("secId", secId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            IEnumerable<SectionTrainees> result = dbContext.Connection.Query<SectionTrainees>("Final_Trainee_PACKAGE.GetAllSectionTrainees ",p,
             commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<AcceptedTrainee> GetAllAccepted()
        {
            IEnumerable<AcceptedTrainee> result = dbContext.Connection.Query<AcceptedTrainee>("Final_Trainee_PACKAGE.GETALLAcceptedTrainee ",
             commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task <List<FinalTrainee>> GETALLTrainees()
        {
            var result = await dbContext.Connection.QueryAsync<FinalTrainee,FinalTraineesection,FinalTrainee>("Final_Trainee_PACKAGE.GETALLTrainees", (Trainee, TraineeSection) =>
            {
                Trainee.FinalTraineesections.Add(TraineeSection);
                return Trainee;
            },

            splitOn: "Traineeid,Tsid",
             param: null,
            commandType: CommandType.StoredProcedure
            );

            var results = result.GroupBy(p => p.Traineeid).Select(g =>
            {
                var groupedPost = g.First();
                groupedPost.FinalTraineesections = g.Select(p => p.FinalTraineesections.Single()).ToList();
           
                return groupedPost;
            });

         
            return result.ToList();
        }

        public List<TraineeUser> GetAllTraineeUsers()
        {
            IEnumerable<TraineeUser> result = dbContext.Connection.Query<TraineeUser>("Final_Trainee_PACKAGE.GETALLUSERTrainee",
              commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public FinalTrainee GetTraineeByID(int IDD)
        {
            var p = new DynamicParameters();
            p.Add("IDD", IDD, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<FinalTrainee> result = dbContext.Connection.Query<FinalTrainee>("Final_Trainee_PACKAGE.GetTraineeByID", p, commandType: System.Data.CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void InsertTrainee(FinalTrainee trainee)
        {
            var p = new DynamicParameters();
            p.Add("Address", trainee.Address, DbType.String, direction: ParameterDirection.Input);
            p.Add("Major", trainee.Major, DbType.String, direction: ParameterDirection.Input);
            p.Add("University", trainee.University, DbType.String, direction: ParameterDirection.Input);
            p.Add("TraineeField", trainee.Traineefield, DbType.String, direction: ParameterDirection.Input);
            p.Add("RegisterStatus",trainee.Registerstatus /*trainee.Registerstatus*/, DbType.Int32, direction: ParameterDirection.Input);
            p.Add("User_ID", trainee.User_Id, DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_Trainee_PACKAGE.InsertTrainee", p, commandType: CommandType.StoredProcedure);
        }

        public List<SearchTrainee> SerchTrainees(SearchTrainee trainee)
        {
            var p = new DynamicParameters();
            p.Add("FName", trainee.Address, DbType.String, direction: ParameterDirection.Input);
            p.Add("LName", trainee.Address, DbType.String, direction: ParameterDirection.Input);
            p.Add("Address_", trainee.Address, DbType.String, direction: ParameterDirection.Input);
            p.Add("Major_", trainee.Major, DbType.String, direction: ParameterDirection.Input);
            p.Add("University_", trainee.University, DbType.String, direction: ParameterDirection.Input);
            p.Add("Trainee_Field", trainee.Traineefield, DbType.String, direction: ParameterDirection.Input);
            IEnumerable<SearchTrainee> result = dbContext.Connection.Query<SearchTrainee>("Final_Trainee_PACKAGE.SearchTrainee", p, commandType: System.Data.CommandType.StoredProcedure);
            return result.ToList();
        }

        public void UpdateTrainee(FinalTrainee trainee)
        {
            var p = new DynamicParameters();
            p.Add("IDD", trainee.Traineeid, dbType: DbType.Int32, direction:ParameterDirection.Input);
            p.Add("Address_", trainee.Address, DbType.String, direction: ParameterDirection.Input);
            p.Add("Major_", trainee.Major, DbType.String, direction: ParameterDirection.Input);
            p.Add("University_", trainee.University, DbType.String, direction: ParameterDirection.Input);
            p.Add("Trainee_Field", trainee.Traineefield, DbType.String, direction: ParameterDirection.Input);
            p.Add("Register_Status", trainee.Registerstatus, DbType.Int32, direction: ParameterDirection.Input);
            p.Add("UserID", trainee.User_Id, DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_Trainee_PACKAGE.UpdateTrainee", p, commandType: CommandType.StoredProcedure);
        }
    }
}
