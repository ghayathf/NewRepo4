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
    public class TrainerRepository : ITrainerRepository
    {
        public readonly IDbContext dbContext;
        public TrainerRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateTrainer(FinalTrainer trainer)
        {
            var p = new DynamicParameters();
            p.Add("TSalary", trainer.Salary, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TPosition", trainer.Trainerposition, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TQualification", trainer.Qualification, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TUser_ID", trainer.UserId, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Final_Trainer_Package.CREATETrainer", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteTrainer(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_Trainer_Package.DELETETrainer", p, commandType: CommandType.StoredProcedure);
        }

        public List<FinalTrainer> GetAllTrainers()
        {
            IEnumerable<FinalTrainer> result = dbContext.Connection.Query<FinalTrainer>("Final_Trainer_Package.GETALLTrainers",
               commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public FinalTrainer GetTrainerByID(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<FinalTrainer> result = dbContext.Connection.Query<FinalTrainer>("Final_Trainer_Package.GetTrainerByID",
                p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public void UpdateTrainer(FinalTrainer trainer)
        {
            var p = new DynamicParameters();
            p.Add("IDD",trainer.Trainerid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("TSalary", trainer.Salary, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TPosition", trainer.Trainerposition, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TQualification", trainer.Qualification, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TUser_ID", trainer.UserId, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Final_Trainer_Package.UpdateTrainer", p, commandType: CommandType.StoredProcedure);
        }
    }
}
