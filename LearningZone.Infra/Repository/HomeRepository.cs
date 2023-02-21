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

        public void CreateHomeInformation(FinalHomepage finalHomepage)
        {
            var p = new DynamicParameters();
            p.Add("Home_Logo", finalHomepage.Logo, dbType: DbType.String, ParameterDirection.Input);
            p.Add("back_ground", finalHomepage.Background, dbType: DbType.String, ParameterDirection.Input);
            p.Add("PAR1", finalHomepage.Paragraph1, dbType: DbType.String, ParameterDirection.Input);
            p.Add("PAR2", finalHomepage.Paragraph2, dbType: DbType.String, ParameterDirection.Input);
            p.Add("PAR3", finalHomepage.Paragraph3, dbType: DbType.String, ParameterDirection.Input);
            p.Add("ADDRESS", finalHomepage.Companyaddress, dbType: DbType.String, ParameterDirection.Input);
            p.Add("EMAIL", finalHomepage.Companyemail, dbType: DbType.String, ParameterDirection.Input);
            p.Add("PHONE", finalHomepage.Companyphonenumber, dbType: DbType.String, ParameterDirection.Input);

            var result = _dbContext.Connection.Execute("Final_HomePage_Package.CREATEHOMEINFO",p,commandType:CommandType.StoredProcedure);
        }

        public void DeleteHomeInformation(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.String, ParameterDirection.Input);

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

        public void UpdateHomeInformation(FinalHomepage finalHomepage)
        {
            var p = new DynamicParameters();
            p.Add("HOME_ID", finalHomepage.Homeid, dbType: DbType.Int32, ParameterDirection.Input);

            p.Add("Home_Logo", finalHomepage.Logo, dbType: DbType.String, ParameterDirection.Input);
            p.Add("back_ground", finalHomepage.Background, dbType: DbType.String, ParameterDirection.Input);
            p.Add("PAR1", finalHomepage.Paragraph1, dbType: DbType.String, ParameterDirection.Input);
            p.Add("PAR2", finalHomepage.Paragraph2, dbType: DbType.String, ParameterDirection.Input);
            p.Add("PAR3", finalHomepage.Paragraph3, dbType: DbType.String, ParameterDirection.Input);
            p.Add("ADDRESS", finalHomepage.Companyaddress, dbType: DbType.String, ParameterDirection.Input);
            p.Add("EMAIL", finalHomepage.Companyemail, dbType: DbType.String, ParameterDirection.Input);
            p.Add("PHONE", finalHomepage.Companyphonenumber, dbType: DbType.String, ParameterDirection.Input);

            var result = _dbContext.Connection.Execute("Final_HomePage_Package.CREATEHOMEINFO", p, commandType: CommandType.StoredProcedure);
        }
    }
}
