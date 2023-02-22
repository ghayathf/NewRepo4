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
    public class MaterialRepository : IMaterialRepository
    {
        private readonly IDbContext dbContext;
        public MaterialRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CREATEMaterial(FinalMaterial material)
        {
            var p = new DynamicParameters();
            p.Add("DateUp", material.Dateuploaded, DbType.Date, direction: ParameterDirection.Input);
            p.Add("MName", material.Materialname, DbType.String, direction: ParameterDirection.Input);
            p.Add("SecID", material.SectionId, DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_Material_Package.CREATEMaterial", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public void DELETEMaterial(int IDD)
        {
            var p = new DynamicParameters();
            p.Add("IDD", IDD, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_Material_Package.DELETEMaterial", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public List<FinalMaterial> GETALLMaterials()
        {
            IEnumerable<FinalMaterial> result = dbContext.Connection.Query<FinalMaterial>("Final_Material_Package.GETALLMaterials", commandType: System.Data.CommandType.StoredProcedure);
            return result.ToList();
        }

        public FinalMaterial GetMaterialByID(int IDD)
        {
            var p = new DynamicParameters();
            p.Add("IDD", IDD, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            IEnumerable<FinalMaterial> result = dbContext.Connection.Query<FinalMaterial>("Final_Material_Package.GetMaterialByID", p, commandType: System.Data.CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void UpdateMaterial(FinalMaterial material)
        {
            var p = new DynamicParameters();
            p.Add("IDD", material.Materialid, DbType.Int32, direction: ParameterDirection.Input);
            p.Add("DateUp", material.Dateuploaded, DbType.Date, direction: ParameterDirection.Input);
            p.Add("MName", material.Materialname, DbType.String, direction: ParameterDirection.Input);
            p.Add("SecID", material.SectionId, DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_Material_Package.UpdateMaterial", p, commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}
