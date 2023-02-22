using Dapper;
using LearningZone.Core.Common;
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
    public class TaskRepository : ITaskRepository
    {
        private readonly IDbContext _dbContext;

        public TaskRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateTask(FinalTask finalTask)
        {
            var p = new DynamicParameters();
            p.Add("TType", finalTask.Tasktype, dbType: DbType.String, ParameterDirection.Input);
            p.Add("TStartTime", finalTask.Starttime, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("TEndTime", finalTask.Endtime, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("TWeight", finalTask.Weight, dbType: DbType.Decimal, ParameterDirection.Input);
            p.Add("TStatus", finalTask.Taskstatus, dbType: DbType.Decimal, ParameterDirection.Input);
            p.Add("TFile", finalTask.Taskfile, dbType: DbType.String, ParameterDirection.Input);
            p.Add("TNote", finalTask.Tasknote, dbType: DbType.String, ParameterDirection.Input);


            var result = _dbContext.Connection.Execute("Final_Task_Package.CREATETask", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteTask(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, dbType: DbType.Int32, ParameterDirection.Input);

            var result = _dbContext.Connection.Execute("Final_Task_Package.DELETETask", p, commandType: CommandType.StoredProcedure);
        }

        public List<FinalTask> GetAllTask()
        {
            IEnumerable<FinalTask> result = _dbContext.Connection.Query<FinalTask>("Final_Task_Package.GETALLTasks", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public FinalTask GetTaskById(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, dbType: DbType.Int32, ParameterDirection.Input);
            IEnumerable<FinalTask> result = _dbContext.Connection.Query<FinalTask>("Final_Task_Package.GetTaskByID", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void UpdateTask(FinalTask finalTask)
        {
            var p = new DynamicParameters();
            p.Add("IDD", finalTask.Taskid, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("TType", finalTask.Tasktype, dbType: DbType.String, ParameterDirection.Input);
            p.Add("TStartTime", finalTask.Starttime, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("TEndTime", finalTask.Endtime, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("TWeight", finalTask.Weight, dbType: DbType.Decimal, ParameterDirection.Input);
            p.Add("TStatus", finalTask.Taskstatus, dbType: DbType.Decimal, ParameterDirection.Input);
            p.Add("TFile", finalTask.Taskfile, dbType: DbType.String, ParameterDirection.Input);
            p.Add("TNote", finalTask.Tasknote, dbType: DbType.String, ParameterDirection.Input);


            var result = _dbContext.Connection.Execute("Final_Task_Package.UpdateTask", p, commandType: CommandType.StoredProcedure);
        }
    }
}
