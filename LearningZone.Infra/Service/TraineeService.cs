using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class TraineeService : ITraineeService
    {
        private readonly ITraineeRepository traineeRepository;
        public TraineeService(ITraineeRepository traineeRepository)
        {
            this.traineeRepository = traineeRepository;
        }
        public void DELETETrainee(int IDD)
        {
            traineeRepository.DELETETrainee(IDD);
        }

        public List<FinalTrainee> GETALLTrainees()
        {
           return traineeRepository.GETALLTrainees();
        }

        public FinalTrainee GetTraineeByID(int IDD)
        {
            return traineeRepository.GetTraineeByID(IDD);
        }

        public void InsertTrainee(FinalTrainee trainee)
        {
            traineeRepository.InsertTrainee(trainee);
        }

        public void UpdateTrainee(FinalTrainee trainee)
        {
            traineeRepository.UpdateTrainee(trainee);
        }
    }
}
