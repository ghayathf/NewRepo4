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
    public class SolutionRepository: ISolutionRepository
    {
        public readonly IDbContext dbContext;
        public SolutionRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateSolution(FinalSolution solution)
        {
            var p = new DynamicParameters();
            p.Add("SOL_MARK", solution.Solutionmark, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("SOL_FILE", solution.Solutionfile, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("SOL_NOTE", solution.Submitionnote, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TS", solution.TSId, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TAS_ID", solution.TaskId, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("FINAL_SOLUTION_PACKAGE.CREATE_NEW_SOLUTION", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteSolution(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("FINAL_SOLUTION_PACKAGE.DELETE_SOLUTION", p, commandType: CommandType.StoredProcedure);
        }

        public List<FinalSolution> GetAllSolutions()
        {
            IEnumerable<FinalSolution> result = dbContext.Connection.Query<FinalSolution>("FINAL_SOLUTION_PACKAGE.GETSOLUTIONINFO",
               commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public FinalSolution GetSolutionByID(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<FinalSolution> result = dbContext.Connection.Query<FinalSolution>("FINAL_SOLUTION_PACKAGE.GET_SOL_BY_ID",
                p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public void UpdateSolution(FinalSolution solution)
        {
            var p = new DynamicParameters();
            p.Add("SOL_ID", solution.Solutionid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("FINAL_SOLUTION_PACKAGE.EDIT_SOLUTION_INFO", p, commandType: CommandType.StoredProcedure);
        }
    }
}
