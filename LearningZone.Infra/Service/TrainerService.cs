using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class TrainerService: ITrainerService
    {
        private readonly ITrainerRepository trainerRepository;

        public TrainerService(ITrainerRepository trainerRepository)
        {
            this.trainerRepository = trainerRepository;
        }

        public void CreateTrainer(FinalTrainer trainer)
        {
            trainerRepository.CreateTrainer(trainer);
        }

        public void DeleteTrainer(int id)
        {
            trainerRepository.DeleteTrainer(id);
        }

        public List<FinalTrainer> GetAllTrainers()
        {
            return trainerRepository.GetAllTrainers();
        }

        public FinalTrainer GetTrainerByID(int id)
        {
           return trainerRepository.GetTrainerByID(id);
        }

        public void UpdateTrainer(FinalTrainer trainer)
        {
            trainerRepository.UpdateTrainer(trainer);
        }
    }
}
