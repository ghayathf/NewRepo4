﻿using LearningZone.Core.Data;
using LearningZone.Core.DTO;
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
        [Route("GetAllTestimonials")]
        public List<Testimonial> GetAllTestimonial()
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
        [Route("CreateTestimonial")]
        public void CreateHomeTestimonial(FinalTestimonial finalTestimonial)
        {
            _testimonialService.CreateHomeTestimonial(finalTestimonial);
        }
        [HttpPut]
        [Route("UpdateTestimonial")]
        public void UpdateTestimonial(FinalTestimonial finalTestimonial)
        {
            _testimonialService.UpdateTestimonial(finalTestimonial);
        }
        [HttpDelete]
        [Route("DeleteTestimonial/{id}")]
        public void DeleteTestimonial(int id)
        {
            _testimonialService.DeleteTestimonial(id);
        }

        [HttpGet]
        [Route("GetAllAcceptedTestimonial")]
        public List<Testimonial> GetAllAcceptedTestimonial()
        {
            return _testimonialService.GetAllAcceptedTestimonial();
        }
    }
}
