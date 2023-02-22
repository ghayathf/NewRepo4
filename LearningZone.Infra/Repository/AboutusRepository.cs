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
    public class AboutusRepository : IAboutusRepository
    {
        private readonly IDbContext dbContext;
        public AboutusRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateAbout(FinalAboutu finalAboutu)
        {
            var p = new DynamicParameters();
            p.Add("about_image", finalAboutu.Aboutimage, DbType.String, direction: ParameterDirection.Input);
            p.Add("par1", finalAboutu.Paragraph1, DbType.String, direction: ParameterDirection.Input);
            p.Add("par2", finalAboutu.Paragraph2, DbType.String, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Final_AboutUs_Package.CreateAboutUs", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteAbout(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, DbType.Int32, direction: ParameterDirection.Input);
            dbContext.Connection.Execute("Final_AboutUs_Package.DeleteAboutUs", p, commandType: CommandType.StoredProcedure);
        }

        public FinalAboutu GetAboutById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<FinalAboutu> finalAboutus = dbContext.Connection.Query<FinalAboutu>("Final_AboutUs_Package.GetAboutUsInfoById", p
                , commandType: CommandType.StoredProcedure);
            return finalAboutus.FirstOrDefault();
        }

        public List<FinalAboutu> GetAllAbouts()
        {
            IEnumerable<FinalAboutu> finalAboutus = dbContext.Connection.Query<FinalAboutu>("Final_AboutUs_Package.GetAllAboutUsInfo"
                , commandType: CommandType.StoredProcedure);
            return finalAboutus.ToList();
        }

        public void UpdateAbout(FinalAboutu finalAboutu)
        {
            var p = new DynamicParameters();
            p.Add("about_id", finalAboutu.Aboutid, DbType.Int32, direction: ParameterDirection.Input);
            p.Add("about_image", finalAboutu.Aboutimage, DbType.String, direction: ParameterDirection.Input);
            p.Add("par1", finalAboutu.Paragraph1, DbType.String, direction: ParameterDirection.Input);
            p.Add("par2", finalAboutu.Paragraph2, DbType.String, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Final_AboutUs_Package.UpdateAboutUs", p, commandType: CommandType.StoredProcedure);
        }
    }
}
