using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Service
{
    public interface ITestimonialService
    {
        List<Testimonial> GetAllTestimonial();
            List<Testimonial> GetAllAcceptedTestimonial();
        FinalTestimonial GetTestimonialById(int id);
        void CreateHomeTestimonial(FinalTestimonial finalTestimonial);
        void UpdateTestimonial(FinalTestimonial finalTestimonial);

        void DeleteTestimonial(int id);
    }
}
