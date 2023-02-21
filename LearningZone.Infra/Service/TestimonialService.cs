using LearningZone.Core.Data;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class TestimonialService : ITestimonialService
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialService(ITestimonialService _testimonialService)
        {
            this._testimonialService = _testimonialService;
        }
        public void CreateHomeTestimonial(FinalTestimonial finalTestimonial)
        {
            _testimonialService.CreateHomeTestimonial(finalTestimonial);
        }

        public void DeleteTestimonial(int id)
        {
            _testimonialService.DeleteTestimonial(id);
        }

        public List<FinalTestimonial> GetAllTestimonial()
        {
            return _testimonialService.GetAllTestimonial();
        }

        public FinalTestimonial GetTestimonialById(int id)
        {
            return _testimonialService.GetTestimonialById(id);
        }

        public void UpdateTestimonial(FinalTestimonial finalTestimonial)
        {
            _testimonialService.UpdateTestimonial(finalTestimonial);
        }
    }
}
