using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Repository
{
    public interface ITrainerRepository
    {
        List<FinalTrainer> GetAllTrainers();
        FinalTrainer GetTrainerByID(int id);
        void CreateTrainer(FinalTrainer trainer);
        void UpdateTrainer(FinalTrainer trainer);
        void DeleteTrainer(int id);
    }
}
