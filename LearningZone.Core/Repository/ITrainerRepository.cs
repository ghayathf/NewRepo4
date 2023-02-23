using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Core.Repository
{
    public interface ITrainerRepository
    {
        Task <List<FinalTrainer>> GetAllTrainers();
        FinalTrainer GetTrainerByID(int id);
        void CreateTrainer(FinalTrainer trainer);
        void UpdateTrainer(FinalTrainer trainer);
        void DeleteTrainer(int id);
    }
}
