using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Service
{
    public interface ISolutionService
    {
        List<FinalSolution> GetAllSolutions();
        FinalSolution GetSolutionByID(int id);
        void CreateSolution(FinalSolution solution);
        void UpdateSolution(FinalSolution solution);
        void DeleteSolution(int id);
    }
}
