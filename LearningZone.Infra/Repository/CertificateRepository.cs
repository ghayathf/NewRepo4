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
    public class CertificateRepository : ICertificateRepository
    {
        private readonly IDbContext _dbContext;
        public CertificateRepository(IDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }
        public void CreateCertificate(FinalCertificate finalCertificate)
        {
            var p = new DynamicParameters();
            p.Add("typee_cre", finalCertificate.Certificatetype, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("tsid", finalCertificate.TSId, dbType: DbType.Int32, ParameterDirection.Input);
           


            var result = _dbContext.Connection.Execute("Final_Certificate_Package.CreateCertificate", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteCertificate(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, dbType: DbType.Int32, ParameterDirection.Input);

            var result = _dbContext.Connection.Execute("Final_Certificate_Package.DELETECertificate", p, commandType: CommandType.StoredProcedure);
            //DELETECertificate
        }

        public List<FinalCertificate> GetAllCertificate()
        {
            IEnumerable<FinalCertificate> result = _dbContext.Connection.Query<FinalCertificate>("Final_Certificate_Package.GettAllCertificate", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public FinalCertificate GetTCertificateById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, ParameterDirection.Input);
            IEnumerable<FinalCertificate> result = _dbContext.Connection.Query<FinalCertificate>("Final_Certificate_Package.GetCertificateByID", commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void UpdateCertificate(FinalCertificate finalCertificate)
        {
            var p = new DynamicParameters();
            p.Add("IDD", finalCertificate.Certificateid, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("typee_cre", finalCertificate.Certificatetype, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("tsid", finalCertificate.TSId, dbType: DbType.Int32, ParameterDirection.Input);



            var result = _dbContext.Connection.Execute("Final_Certificate_Package.UPDATECertificate", p, commandType: CommandType.StoredProcedure);
        }
    }
}
