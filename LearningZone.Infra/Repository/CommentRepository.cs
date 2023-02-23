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
    public class CommentRepository : ICommentRepository
    {
        private readonly IDbContext dbContext;
        public CommentRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateComment(FinalComment finalComment)
        {
            var p = new DynamicParameters();
            p.Add("ComMessage", finalComment.Commentmessage, DbType.String, direction: ParameterDirection.Input);
            p.Add("DatePub", finalComment.Datepublished, DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("UID", finalComment.User_Id, DbType.Int32, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Final_Comment_Package.CREATEComment", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteComment(int id)
        {
            var p = new DynamicParameters();
            p.Add("UID", id, DbType.Int32, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Final_Comment_Package.DELETEComment", p, commandType: CommandType.StoredProcedure);
        }

        public async Task<List<FinalComment>> GetAllComments()
        {
            var p = new DynamicParameters();
            var result = await dbContext.Connection.QueryAsync<FinalComment, FinalReply,
            FinalComment>("Final_Comment_Package.GETALLComments",
            (comment, reply) =>
            {
                comment.FinalReplies.Add(reply);
                return comment;
            },
            splitOn: "CommentId , ReplyId"
            ,
            param: null,
            commandType: CommandType.StoredProcedure
            );


            var results = result.GroupBy(p => p.Commentid).Select(g =>
            {
                var groupedPost = g.First();
                groupedPost.FinalReplies = g.Select(p => p.FinalReplies.Single()).ToList();
                return groupedPost;
            });
            return results.ToList();
        }

        public FinalComment GetCommentById(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDD", id, DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<FinalComment> comments = dbContext.Connection.Query<FinalComment>("Final_Comment_Package.GetCommentByID",p
                , commandType: CommandType.StoredProcedure);
            return comments.FirstOrDefault();
        }

        public void UpdateComment(FinalComment finalComment)
        {
            var p = new DynamicParameters();
            p.Add("IDD", finalComment.Datepublished, DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ComMessage", finalComment.Commentmessage, DbType.String, direction: ParameterDirection.Input);
            p.Add("DatePub", finalComment.Datepublished, DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("UID", finalComment.User_Id, DbType.Int32, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Final_Comment_Package.UpdateComment", p, commandType: CommandType.StoredProcedure);
        }
    }
}
