using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Repository
{
    public interface IReplyRepository
    {
        List<FinalReply> GetAllCourses();
        FinalReply GetCourseById(int id);
        void CreateCourse(FinalReply finalReply);
        void UpdateCourse(FinalReply finalReply);
        void DeleteCourse(int id);
    }
}
