﻿using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Core.Service
{
    public interface ICourseService
    {
        Task<List<FinalCourse>> GetAllCourses();
        FinalCourse GetCourseById(int id);
        void CreateCourse(FinalCourse finalCourse);
        void UpdateCourse(FinalCourse finalCourse);
        void DeleteCourse(int id);
    }
}
