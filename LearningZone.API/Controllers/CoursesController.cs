using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using LearningZone.Core.Service;
using LearningZone.Infra.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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
        [HttpGet]
        [Route("CoursesAvgs")]
        public List<Averages> Avgs()
        {
            return courseService.Avgs();
        }
        [HttpPost]
        [Route("SearchCourse")]
        public List<SearchCourse> SearchCourse(SearchCourse searchCourse)
        {
            return courseService.SearcheStudenCourse(searchCourse);
        }
        [Route("UploadImage")]
        [HttpPost]
        public FinalCourse UploadImage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullpath = Path.Combine("C:\\LearningHub_Angular\\src\\assets\\HomeAssets\\images", fileName);

            using(var stream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            FinalCourse item = new FinalCourse();
            item.Courseimage = fileName;
            return item;
        }
    }
}
