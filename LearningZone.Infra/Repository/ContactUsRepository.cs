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
    public class ContactUsRepository : IContactUsRepository
    {
        private readonly IDbContext dbContext;
        public ContactUsRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateContactUs(FinalContactu contact)
        {
            var p = new DynamicParameters();
            p.Add("FName", contact.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LName", contact.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Email_", contact.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PhoneNumber_", contact.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("message_", contact.Message, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_ContactUs_Package.InsertContactUs", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteContactUs(int id)
        {
            var p = new DynamicParameters();
            p.Add("ContactUsID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_ContactUs_Package.DeleteContactUs", p, commandType: CommandType.StoredProcedure);
        }

        public List<FinalContactu> GetAllContactUs()
        {
            IEnumerable<FinalContactu> result = dbContext.Connection.Query<FinalContactu>("Final_ContactUs_Package.GetAllContactUs",
               commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public FinalContactu GetContactUsByID(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<FinalContactu> result = dbContext.Connection.Query<FinalContactu>("Final_ContactUs_Package.GetContactUsByID",
                p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public void UpdateContactUs(FinalContactu contact)
        {
            var p = new DynamicParameters();
            p.Add("ContactUsID", contact.Contactid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("First_Name", contact.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Last_Name", contact.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Email_", contact.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phoneNum", contact.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Final_ContactUs_Package.UpdateContactUs", p, commandType: CommandType.StoredProcedure);
        }
    }
}
