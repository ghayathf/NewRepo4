using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Service
{
    public interface IReplyService
    {
        List<FinalReply> GetAllCourses();
        FinalReply GetCourseById(int id);
        void CreateCourse(FinalReply finalReply);
        void UpdateCourse(FinalReply finalReply);
        void DeleteCourse(int id);
    }
}
