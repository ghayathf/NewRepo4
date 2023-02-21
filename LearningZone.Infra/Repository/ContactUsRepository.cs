using Dapper;
using LearningZone.Core.Common;
using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LearningZone.Infra.Repository
{
    public class ContactUsRepository : IContactUsRepository
    {
        public readonly IDbContext dbContext;
        public ContactUsRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateContactUs(FinalContactu contact)
        {
            var p = new DynamicParameters();
            p.Add("FirstName", contact.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LastName", contact.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Final_ContactUs_Package.InsertContactUs", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteContactUs(int id)
        {
            throw new NotImplementedException();
        }

        public List<FinalContactu> GetAllContactUs()
        {
            throw new NotImplementedException();
        }

        public FinalContactu GetContactUsByID(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateContactUs(FinalContactu contact)
        {
            throw new NotImplementedException();
        }
    }
}
