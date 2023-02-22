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
    public class AttendaceRepository : IAttendanceRepository
    {
        private readonly IDbContext dbContext;
        public AttendaceRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void DELETEAttendance(int IDD)
        {
            var p = new DynamicParameters();
            p.Add("IDD", IDD, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_Attendance_PACKAGE.DELETEAttendance", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public List<FinalAttendance> GETALLAttendance()
        {
            IEnumerable<FinalAttendance> result = dbContext.Connection.Query<FinalAttendance>("Final_Attendance_PACKAGE.GETALLAttendance", commandType: System.Data.CommandType.StoredProcedure);
            return result.ToList();
        }

        public FinalAttendance GetAttendanceByID(int IDD)
        {
            var p = new DynamicParameters();
            p.Add("IDD", IDD, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            IEnumerable<FinalAttendance> result = dbContext.Connection.Query<FinalAttendance>("Final_Attendance_PACKAGE.GetAttendanceByID", p, commandType: System.Data.CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void InsertAttendance(FinalAttendance attendance)
        {
            var p = new DynamicParameters();
            p.Add("Status", attendance.Attendancestatus, DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Final_Attendance_PACKAGE.InsertAttendance", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public void UpdateAttendance(FinalAttendance attendance)
        {
            var p = new DynamicParameters();
            p.Add("IDD", attendance.Attendanceid, DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Status", attendance.Attendancestatus, DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_Attendance_PACKAGE.UpdateAttendance", p, commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}
