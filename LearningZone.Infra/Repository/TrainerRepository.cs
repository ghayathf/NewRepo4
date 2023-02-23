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
    public class TrainerRepository : ITrainerRepository
    {
        private readonly IDbContext dbContext;
        public TrainerRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateTrainer(FinalTrainer trainer)
        {
            var p = new DynamicParameters();
            p.Add("TSalary", trainer.Salary, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("TPosition", trainer.Trainerposition, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TQualification", trainer.Qualification, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TUser_ID", trainer.User_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Final_Trainer_Package.CREATETrainer", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteTrainer(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_Trainer_Package.DELETETrainer", p, commandType: CommandType.StoredProcedure);
        }

        public async Task< List<FinalTrainer>> GetAllTrainers()
        {
            var result = await dbContext.Connection.QueryAsync<FinalTrainer, FinalSection, FinalTrainer>("Final_Trainer_Package.GETALLTrainers", (Trainer, Section) =>
            {
                Trainer.FinalSections.Add(Section);
                return Trainer;
            },
                splitOn: "Trainer_Id,Sectionid",
                param:null,
                commandType:CommandType.StoredProcedure
            );

            var results = result.GroupBy(p => p.Trainerid).Select(g =>
            {
                var groupedPost = g.First();
                groupedPost.FinalSections = g.Select(p => p.FinalSections.Single()).ToList();

                return groupedPost;
            });

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
            p.Add("TSalary", trainer.Salary, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("TPosition", trainer.Trainerposition, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TQualification", trainer.Qualification, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TUser_ID", trainer.User_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Final_Trainer_Package.UpdateTrainer", p, commandType: CommandType.StoredProcedure);
        }
    }
}
