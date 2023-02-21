using LearningZone.Core.Data;
using LearningZone.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LearningZone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;

        }
        [HttpGet]
       public List<FinalTask> GetAllTask()
        {
            return _taskService.GetAllTask();
        }

        [HttpGet]
        [Route("GetTaskById/{id}")]
        public FinalTask GetTaskById(int id)
        {
            return _taskService.GetTaskById(id);
        }
        [HttpPost]
        public void CreateTask(FinalTask finalTask)
        {
            _taskService.CreateTask(finalTask);
        }
        [HttpPut]
        public void UpdateTask(FinalTask finalTask)
        {
            _taskService.UpdateTask(finalTask);
        }
        [HttpDelete]
       public void DeleteTask(int id)
        {
            _taskService.DeleteTask(id);
        }
    }
}
