using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Service
{
    public interface ITraineeService
    {
        List<FinalTrainee> GETALLTrainees();
        FinalTrainee GetTraineeByID(int IDD);
        void InsertTrainee(FinalTrainee trainee);
        void UpdateTrainee(FinalTrainee trainee);
        void DELETETrainee(int IDD);
    }
}
