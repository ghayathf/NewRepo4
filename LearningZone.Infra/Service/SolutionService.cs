using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class SolutionService : ISolutionService
    {
        private readonly ISolutionRepository solutionRepository;

        public SolutionService(ISolutionRepository solutionRepository)
        {
            this.solutionRepository = solutionRepository;
        }

        public void CreateSolution(FinalSolution solution)
        {
            solutionRepository.CreateSolution(solution);
        }

        public void DeleteSolution(int id)
        {
            solutionRepository.DeleteSolution(id);
        }

        public List<FinalSolution> GetAllSolutions()
        {
            return solutionRepository.GetAllSolutions();
        }

        public FinalSolution GetSolutionByID(int id)
        {
            return solutionRepository.GetSolutionByID(id);
        }

        public void UpdateSolution(FinalSolution solution)
        {
            solutionRepository.UpdateSolution(solution);
        }
    }
}
