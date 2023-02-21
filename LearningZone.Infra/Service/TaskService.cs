﻿using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public void CreateTask(FinalTask finalTask)
        {
            _taskRepository.CreateTask(finalTask);
        }

        public void DeleteTask(int id)
        {
            _taskRepository.DeleteTask(id);
        }

        public List<FinalTask> GetAllTask()
        {
            return _taskRepository.GetAllTask();
        }

        public FinalTask GetTaskById(int id)
        {
            return _taskRepository.GetTaskById(id);
        }

        public void UpdateTask(FinalTask finalTask)
        {
            _taskRepository.UpdateTask(finalTask);
        }
    }
}
