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
    public class RoleRepository : IRoleRepository
    {
        private readonly IDbContext _dbContext;

        public RoleRepository(IDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }
        public void CreateRole(FinalRole finalRole)
        {
            var p = new DynamicParameters();
            p.Add("NAMEE", finalRole.Rolename, dbType: DbType.String, ParameterDirection.Input);
         

            var result = _dbContext.Connection.Execute("Final_Role_PACKAGE.InsertROLE", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteRole(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, dbType: DbType.Int32, ParameterDirection.Input);

            var result = _dbContext.Connection.Execute("Final_Role_PACKAGE.DELETE_ROLE", p, commandType: CommandType.StoredProcedure);
        }

        public List<FinalRole> GetAllRole()
        {
            IEnumerable<FinalRole> result = _dbContext.Connection.Query<FinalRole>("Final_Role_PACKAGE.GET_ALL_ROLES_INFO", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public FinalRole GetTRoleById(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, dbType: DbType.Int32, ParameterDirection.Input);
            IEnumerable<FinalRole> result = _dbContext.Connection.Query<FinalRole>("Final_Role_PACKAGE.GetRoleByID", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void UpdateRole(FinalRole finalRole)
        {
            var p = new DynamicParameters();
            p.Add("IDD", finalRole.Roleid, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("NAMEE", finalRole.Rolename, dbType: DbType.String, ParameterDirection.Input);



            var result = _dbContext.Connection.Execute("Final_Role_PACKAGE.InsertROLE", p, commandType: CommandType.StoredProcedure);
        }
    }
}
