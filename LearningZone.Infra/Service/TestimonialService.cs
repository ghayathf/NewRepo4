using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class TestimonialService : ITestimonialService
    {
        private readonly ITestimonialRepository testimonialRepository;

        public TestimonialService(ITestimonialRepository testimonialRepository)
        {
            this.testimonialRepository = testimonialRepository;
        }
        public void CreateHomeTestimonial(FinalTestimonial finalTestimonial)
        {
            testimonialRepository.CreateHomeTestimonial(finalTestimonial);
        }

        public void DeleteTestimonial(int id)
        {
            testimonialRepository.DeleteTestimonial(id);
        }

        public List<Testimonial> GetAllTestimonial()
        {
            return testimonialRepository.GetAllTestimonial();
        }

        public FinalTestimonial GetTestimonialById(int id)
        {
            return testimonialRepository.GetTestimonialById(id);
        }

        public void UpdateTestimonial(FinalTestimonial finalTestimonial)
        {
            testimonialRepository.UpdateTestimonial(finalTestimonial);
        }
    }
}
