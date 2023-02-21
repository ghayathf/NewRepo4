using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Repository
{
    public interface ITaskRepository
    {
        List<FinalTask> GetAllTask();
        FinalTask GetTaskById(int id);
        void CreateTask(FinalTask finalTask);
        void UpdateTask(FinalTask finalTask);
        void DeleteTask(int id);
    }
}
