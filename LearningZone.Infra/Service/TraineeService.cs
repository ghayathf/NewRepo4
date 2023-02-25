using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public async Task< List<FinalTrainee>> GETALLTrainees()
        {
           return await traineeRepository.GETALLTrainees();
        }

        public FinalTrainee GetTraineeByID(int IDD)
        {
            return traineeRepository.GetTraineeByID(IDD);
        }

        public void InsertTrainee(FinalTrainee trainee)
        {
            traineeRepository.InsertTrainee(trainee);
        }

        public List<SearchTrainee> SerchTrainees(SearchTrainee trainee)
        {
           return traineeRepository.SerchTrainees(trainee);
        }

        public void UpdateTrainee(FinalTrainee trainee)
        {
            traineeRepository.UpdateTrainee(trainee);
        }
    }
}
