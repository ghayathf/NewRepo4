using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Service
{
    public interface ICourseService
    {
        List<FinalCourse> GetAllCourses();
        FinalCourse GetCourseById(int id);
        void CreateCourse(FinalCourse finalCourse);
        void UpdateCourse(FinalCourse finalCourse);
        void DeleteCourse(int id);
    }
}
