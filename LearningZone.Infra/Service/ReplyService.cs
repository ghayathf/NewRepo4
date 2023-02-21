using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class ReplyService : IReplyService
    {
        private readonly IReplyRepository replyRepository;
        public ReplyService(IReplyRepository replyRepository)
        {
            this.replyRepository = replyRepository;
        }

        public void CreateCourse(FinalReply finalReply)
        {
            replyRepository.CreateCourse(finalReply);
        }

        public void DeleteCourse(int id)
        {
            replyRepository.DeleteCourse(id);
        }

        public List<FinalReply> GetAllCourses()
        {
            return replyRepository.GetAllCourses();
        }

        public FinalReply GetCourseById(int id)
        {
            return replyRepository.GetCourseById(id);
        }

        public void UpdateCourse(FinalReply finalReply)
        {
            replyRepository.UpdateCourse(finalReply);
        }
    }
}
