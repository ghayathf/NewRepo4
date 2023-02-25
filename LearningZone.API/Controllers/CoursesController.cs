using LearningZone.Core.Data;
using LearningZone.Core.Service;
using LearningZone.Infra.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningZone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService courseService;
        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;
        }
        [HttpPost]
        [Route("CreateCourse")]
        public void CreateCourse(FinalCourse finalCourse)
        {
            courseService.CreateCourse(finalCourse);
        }
        [HttpDelete]
        [Route("DeleteCourse/{id}")]
        public void DeleteCourse(int id)
        {
            courseService.DeleteCourse(id);
        }
        [HttpGet]
        [Route("GetAllCourses")]
        public Task<List<FinalCourse>> GetAllCourses()
        {
            return courseService.GetAllCourses();
        }
        [HttpGet]
        [Route("GetCourseById/{id}")]
        public FinalCourse GetCourseById(int id)
        {
            return courseService.GetCourseById(id);
        }
        [HttpPut]
        [Route("UpdateCourse")]
        public void UpdateCourse(FinalCourse finalCourse)
        {
            courseService.UpdateCourse(finalCourse);
        }
    }
}
