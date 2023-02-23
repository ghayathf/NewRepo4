using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Core.Service
{
    public interface ITraineeSectionService
    {
         Task<List<FinalTraineesection>> GETALLTraineeSections();
        FinalTraineesection GetTraineeSectionByID(int id);
        void CREATETraineeSection(FinalTraineesection traineesection);
        void UpdateTraineeSection(FinalTraineesection traineesection);
        void DELETETraineeSection(int id);
    }
}
