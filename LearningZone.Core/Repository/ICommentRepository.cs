using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Core.Repository
{
    public interface ICommentRepository
    {
        Task<List<FinalComment>> GetAllComments();
        FinalComment GetCommentById(int id);
        void CreateComment(FinalComment finalComment);
        void UpdateComment(FinalComment finalComment);
        void DeleteComment(int id);
        List<SecComments> SecComments(int SecId);
    }
}
