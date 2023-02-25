using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Core.Service
{
    public interface ICommentService
    {
        Task<List<FinalComment>> GetAllComments();
        FinalComment GetCommentById(int id);
        void CreateComment(FinalComment finalComment);
        void UpdateComment(FinalComment finalComment);
        void DeleteComment(int id);
    }
}
