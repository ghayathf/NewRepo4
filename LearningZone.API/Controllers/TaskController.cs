using LearningZone.Core.Data;
using LearningZone.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        [Route("GetAllTasks")]
       public async Task< List<FinalTask>> GetAllTask()
        {
            return await _taskService.GetAllTask();
        }

        [HttpGet]
        [Route("GetTaskById/{id}")]
        public FinalTask GetTaskById(int id)
        {
            return _taskService.GetTaskById(id);
        }
        [HttpPost]
        [Route("CreateNewTask")]
        public void CreateTask(FinalTask finalTask)
        {
            _taskService.CreateTask(finalTask);
        }
        [HttpPut]
        [Route("UpdateTask")]
        public void UpdateTask(FinalTask finalTask)
        {
            _taskService.UpdateTask(finalTask);
        }
        [HttpDelete]
        [Route("DeleteTask")]
       public void DeleteTask(int id)
        {
            _taskService.DeleteTask(id);
        }
    }
}
