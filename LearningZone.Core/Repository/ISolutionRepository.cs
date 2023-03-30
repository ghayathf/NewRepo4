using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace LearningZone.Core.Repository
{
    public interface ISolutionRepository
    {
        List<FinalSolution> GetAllSolutions();
        FinalSolution GetSolutionByID(int id);
        void CreateSolution(FinalSolution solution);
        void UpdateSolution(FinalSolution solution);
        void DeleteSolution(int id);
        void EnterSolutionMark(int id, double mark);
        List<TaskSols> GetTaskSols(int TID);
    }
}
