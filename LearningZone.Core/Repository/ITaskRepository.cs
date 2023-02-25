using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Core.Repository
{
    public interface ITaskRepository
    {
       Task<List<FinalTask>> GetAllTask();
        FinalTask GetTaskById(int id);
        void CreateTask(FinalTask finalTask);
        void UpdateTask(FinalTask finalTask);
        void DeleteTask(int id);
    }
}
