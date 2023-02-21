using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository commentRepository;
        public CommentService(ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }

        public void CreateComment(FinalComment finalComment)
        {
            commentRepository.CreateComment(finalComment);
        }

        public void DeleteComment(int id)
        {
            commentRepository.DeleteComment(id);
        }

        public List<FinalComment> GetAllComments()
        {
            return commentRepository.GetAllComments();
        }

        public FinalComment GetCommentById(int id)
        {
            return commentRepository.GetCommentById(id);
        }

        public void UpdateComment(FinalComment finalComment)
        {
            commentRepository.UpdateComment(finalComment);
        }
    }
}
