using LearningZone.Core.Data;
using LearningZone.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LearningZone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService _testimonialService)
        {
            this._testimonialService = _testimonialService;
        }
        [HttpGet]
        public List<FinalTestimonial> GetAllTestimonial()
        {
            return _testimonialService.GetAllTestimonial();
        }
        [HttpGet]
        [Route("GetTestimonialById/{id}")]
        public FinalTestimonial GetTestimonialById(int id)
        {
            return _testimonialService.GetTestimonialById(id);
        }
        [HttpPost]
        public void CreateHomeTestimonial(FinalTestimonial finalTestimonial)
        {
            _testimonialService.CreateHomeTestimonial(finalTestimonial);
        }
        [HttpPut]
        public void UpdateTestimonial(FinalTestimonial finalTestimonial)
        {
            _testimonialService.UpdateTestimonial(finalTestimonial);
        }
        [HttpDelete]

        public void DeleteTestimonial(int id)
        {
            _testimonialService.DeleteTestimonial(id);
        }
    }
}
