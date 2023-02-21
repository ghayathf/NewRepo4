using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Repository
{
    public interface ICommentRepository
    {
        List<FinalComment> GetAllComments();
        FinalComment GetCommentById(int id);
        void CreateComment(FinalComment finalComment);
        void UpdateComment(FinalComment finalComment);
        void DeleteComment(int id);
    }
}
