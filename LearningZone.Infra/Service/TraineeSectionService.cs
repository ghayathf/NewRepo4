using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<List<FinalTraineesection>> GETALLTraineeSections()
        {
            return await traineeSectionRepository.GETALLTraineeSections();
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
