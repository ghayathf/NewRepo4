using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Core.Service
{
    public interface ITraineeService
    {
        Task<List<FinalTrainee>> GETALLTrainees();
        FinalTrainee GetTraineeByID(int IDD);
        void InsertTrainee(FinalTrainee trainee);
        void UpdateTrainee(FinalTrainee trainee);
        void DELETETrainee(int IDD);
    }
}
