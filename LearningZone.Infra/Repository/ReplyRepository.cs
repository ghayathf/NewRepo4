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
    public class ReplyRepository : IReplyRepository
    {
        private readonly IDbContext dbContext;
        public ReplyRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateCourse(FinalReply finalReply)
        {
            var p = new DynamicParameters();
            p.Add("RMessage", finalReply.Replymessage, DbType.String, direction: ParameterDirection.Input);
            p.Add("RDatePublished", finalReply.Datepublished, DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("RUser_ID", finalReply.User_Id, DbType.Int32, direction: ParameterDirection.Input);
            p.Add("RComment_ID", finalReply.Comment_Id, DbType.Int32, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Final_Reply_Package.CREATEReply", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteCourse(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, DbType.String, direction: ParameterDirection.Input);
            dbContext.Connection.Execute("Final_Reply_Package.DELETEReply", p, commandType: CommandType.StoredProcedure);
        }

        public List<FinalReply> GetAllCourses()
        {
            IEnumerable<FinalReply> replies = dbContext.Connection.Query<FinalReply>("Final_Reply_Package.GETALLReplies"
                , commandType: CommandType.StoredProcedure);
            return replies.ToList();
        }

        public FinalReply GetCourseById(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, DbType.String, direction: ParameterDirection.Input);
            IEnumerable<FinalReply> replies = dbContext.Connection.Query<FinalReply>("Final_Reply_Package.GetReplyByID", p
                , commandType: CommandType.StoredProcedure);
            return replies.FirstOrDefault();
        }

        public void UpdateCourse(FinalReply finalReply)
        {
            var p = new DynamicParameters();
            p.Add("IDD", finalReply.Replyid, DbType.Int32, direction: ParameterDirection.Input);
            p.Add("RMessage", finalReply.Replymessage, DbType.String, direction: ParameterDirection.Input);
            p.Add("RDatePublished", finalReply.Datepublished, DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("RUser_ID", finalReply.User_Id, DbType.Int32, direction: ParameterDirection.Input);
            p.Add("RComment_ID", finalReply.Comment_Id, DbType.Int32, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Final_Reply_Package.UpdateReply", p, commandType: CommandType.StoredProcedure);
        }
    }
}
