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
    public class TakeAttendanceRepository : ITakeAttendanceRepository
    {
        private readonly IDbContext _dbContext;

        public TakeAttendanceRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateAbsence(FinalTakeattendance takeattendance)
        {
            var p = new DynamicParameters();
            p.Add("attendDate", DateTime.Now, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("ts", takeattendance.Tsid2, dbType: DbType.Int32, ParameterDirection.Input);

            var result = _dbContext.Connection.Execute("Final_TakeAttendance_Package.CreateAbsence", p, commandType: CommandType.StoredProcedure);
        }

        public void CreateAttendance(FinalTakeattendance takeattendance)
        {
            var p = new DynamicParameters();
            p.Add("attendDate", DateTime.Now, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("ts", takeattendance.Tsid2, dbType: DbType.Int32, ParameterDirection.Input);

            var result = _dbContext.Connection.Execute("Final_TakeAttendance_Package.CreateAttendance", p, commandType: CommandType.StoredProcedure);
        }

        public List<FinalTrainee> GetAbsentTrainees()
        {
            IEnumerable<FinalTrainee> result = _dbContext.Connection.Query<FinalTrainee>("Final_TakeAttendance_Package.select_absent_trainees",
               commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<FinalTakeattendance> GetAttendanceByDate(DateTime D)
        {
            var p = new DynamicParameters();
            p.Add("dat", D, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            IEnumerable<FinalTakeattendance> result = _dbContext.Connection.Query<FinalTakeattendance>("Final_TakeAttendance_Package.GetAttendanceByDate",
               p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<FinalTakeattendance> GetAttendanceByID(int IDD)
        {
            var p = new DynamicParameters();
            p.Add("IDD", IDD, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<FinalTakeattendance> result = _dbContext.Connection.Query<FinalTakeattendance>("Final_TakeAttendance_Package.GetAttendanceById",
               p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public int RetrieveAttendanceCount(int IDD)
        {
            var p = new DynamicParameters();
            p.Add("IDD", IDD, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<FinalTakeattendance> result = _dbContext.Connection.Query<FinalTakeattendance>("Final_TakeAttendance_Package.RetrieveAttendanceCount",
               p, commandType: CommandType.StoredProcedure);

            return result.Count();
        }

        public void UpdateAttendance(FinalTakeattendance takeattendance)
        {
            var p = new DynamicParameters();
            p.Add("IDD", takeattendance.Takeattendanceid, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("attendDate", takeattendance.Attendancedate, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("ts", takeattendance.Tsid2, dbType: DbType.Int32, ParameterDirection.Input); 
            p.Add("ATTEND", takeattendance.Attendid, dbType: DbType.Int32, ParameterDirection.Input);

             var result = _dbContext.Connection.Execute("Final_TakeAttendance_Package.UpdateAttendance", p, commandType: CommandType.StoredProcedure);
        }
    }
}
