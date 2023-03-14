using Dapper;
using LearningZone.Core.Common;
using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Infra.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbContext dbContext;
        public UserRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CREATEUser(FinalUser user)
        {
            var p = new DynamicParameters();
            p.Add("UName", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("UPassword", user.Userpassword, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("UEmail", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PhoneNum", user.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("FName", user.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LName", user.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("UROLE_ID", user.Role_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_User_Package.CREATEUser", p, commandType: CommandType.StoredProcedure);
        }
        //(UName IN Final_User.UserName%TYPE,UPassword IN Final_User.UserPassword%TYPE,UEmail IN Final_User.Email%TYPE,PhoneNum IN Final_User.PhoneNumber%TYPE,FName IN Final_User.FirstName%TYPE,LName IN Final_User.LastName%TYPE,UROLE_ID IN Final_User.ROLE_ID%TYPE);
        public void DELETEUser(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_User_Package.DELETEUser", p, commandType: CommandType.StoredProcedure);
        }

        public async Task<List<FinalUser>> GETALLUsers()
        {
            var p = new DynamicParameters();
            var result = await dbContext.Connection.QueryAsync<FinalUser, FinalComment,FinalReply,FinalTestimonial,
            FinalUser>("Final_User_Package.GETALLUsers",
            (user, comment, reply, testimonial) =>
            {
                user.FinalComments.Add(comment);
                user.FinalReplies.Add(reply);
                user.FinalTestimonials.Add(testimonial); 
                return user;
            },
            splitOn: "Userid,Commentid,Replyid,TESTIMONIALID"
            ,
            param: null,
            commandType: CommandType.StoredProcedure
            );


            var results = result.GroupBy(p => p.Userid).Select(g =>
            {
                var groupedPost = g.First();
                groupedPost.FinalComments = g.Select(p => p.FinalComments.Single()).ToList();
                groupedPost.FinalReplies = g.Select(p => p.FinalReplies.Single()).ToList();
                groupedPost.FinalTestimonials = g.Select(p => p.FinalTestimonials.Single()).ToList();
                return groupedPost;
            });
            return results.ToList();
        }

        public FinalUser GetUserByID(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
             IEnumerable<FinalUser> result = dbContext.Connection.Query<FinalUser>("Final_User_Package.GetUserByID",
                p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public void UpdateUser(FinalUser user)
        {
            var p = new DynamicParameters();
            p.Add("IDD", user.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("UName", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("UPassword", user.Userpassword, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("UEmail", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PhoneNum", user.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("FName", user.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LName", user.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("UROLE_ID", user.Role_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Final_User_Package.UpdateUser", p, commandType: CommandType.StoredProcedure);
        }
    }
}
