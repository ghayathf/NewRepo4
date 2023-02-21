using Dapper;
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
    public class HomeRepository : IHomeRepository
    {
        private readonly DbContext _dbContext;
        public HomeRepository(DbContext _dbContext)
        {
            this._dbContext = _dbContext;

        }
        public List<FinalHomepage> GetAllHomeInformation()
        {
            IEnumerable<FinalHomepage> result = _dbContext.Connection.Query<FinalHomepage>("Final_HomePage_Package.GetAllHomeInfo",commandType:CommandType.StoredProcedure);
            return result.ToList();
        }

        public FinalHomepage GetHomeInformationById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, ParameterDirection.Input);
            IEnumerable<FinalHomepage> result = _dbContext.Connection.Query<FinalHomepage>("Final_HomePage_Package.GetHomeInfoById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    }
}
