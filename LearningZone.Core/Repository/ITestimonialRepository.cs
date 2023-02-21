using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Repository
{
    public interface ITestimonialRepository
    {
        List<FinalTestimonial> GetAllTestimonial();
        FinalTestimonial GetTestimonialById(int id);
        void CreateHomeTestimonial(FinalTestimonial finalTestimonial);
        void UpdateTestimonial(FinalTestimonial finalTestimonial);

        void DeleteTestimonial(int id);
    }
}
