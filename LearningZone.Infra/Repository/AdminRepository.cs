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
    public class AdminRepository: IAdminRepository
    {
        public readonly IDbContext dbContext;
        public AdminRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<FinalAdmin> GetAllAdmins()
        {
            IEnumerable<FinalAdmin> result = dbContext.Connection.Query<FinalAdmin>("Final_Admin_PACKAGE.GETALLAdmins",
               commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public void CreateAdmin(FinalAdmin admin)
        {
            var p = new DynamicParameters();
            p.Add("UserID", admin.Adminid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Final_Admin_PACKAGE.InsertAdmin", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteAdmin(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_Admin_PACKAGE.DELETEAdmin", p, commandType: CommandType.StoredProcedure);
        }

        public FinalAdmin GetAdminByID(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<FinalAdmin> result = dbContext.Connection.Query<FinalAdmin>("Final_Admin_PACKAGE.GetAdminByID",
                p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public void UpdateAdmin(FinalAdmin admin)
        {
            var p = new DynamicParameters();
            p.Add("IDD", admin.Adminid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("UserID", admin.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Final_Admin_PACKAGE.UpdateAdmin", p, commandType: CommandType.StoredProcedure);
        }
    }
 }
