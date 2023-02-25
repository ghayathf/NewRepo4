using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using Microsoft.AspNetCore.Cors.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Infra.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }
        public void CreateCourse(FinalCourse finalCourse)
        {
            courseRepository.CreateCourse(finalCourse);
        }

        public void DeleteCourse(int id)
        {
            courseRepository.DeleteCourse(id);
        }

        public Task<List<FinalCourse>> GetAllCourses()
        {
            return courseRepository.GetAllCourses();
        }

        public FinalCourse GetCourseById(int id)
        {
            return courseRepository.GetCourseById(id);
        }

        public void UpdateCourse(FinalCourse finalCourse)
        {
            courseRepository.UpdateCourse(finalCourse);
        }
    }
}
