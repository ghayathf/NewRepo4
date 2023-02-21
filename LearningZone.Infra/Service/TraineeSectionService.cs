using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
   public class TraineeSectionService:ITraineeSectionService
    {
        private readonly ITraineeSectionRepository traineeSectionRepository;

        public TraineeSectionService(ITraineeSectionRepository traineeSectionRepository)
        {
            this.traineeSectionRepository = traineeSectionRepository;
        }

        public void CREATETraineeSection(FinalTraineesection traineesection)
        {
            traineeSectionRepository.CREATETraineeSection(traineesection);
        }

        public void DELETETraineeSection(int id)
        {
            traineeSectionRepository.DELETETraineeSection(id);
        }

        public List<FinalTraineesection> GETALLTraineeSections()
        {
            return traineeSectionRepository.GETALLTraineeSections();
        }

        public FinalTraineesection GetTraineeSectionByID(int id)
        {
            return traineeSectionRepository.GetTraineeSectionByID(id);
        }

        public void UpdateTraineeSection(FinalTraineesection traineesection)
        {
            traineeSectionRepository.UpdateTraineeSection(traineesection);
        }
    }
}
