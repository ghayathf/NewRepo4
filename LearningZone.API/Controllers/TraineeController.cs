using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using LearningZone.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningZone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineeController : ControllerBase
    {
        private readonly ITraineeService traineeService;
        public TraineeController(ITraineeService traineeService)
        {
            this.traineeService = traineeService;
        }
        [HttpPost]
        [Route("InsertTrainee")]
        public void InsertAttendance(FinalTrainee trainee)
        {
            traineeService.InsertTrainee(trainee);
        }
        [HttpDelete]
        [Route("DeleteTrainee/{id}")]
        public void DeleteTrainee(int id)
        {
            traineeService.DELETETrainee(id);
        }
        [HttpGet]
        [Route("GetTraineeById/{id}")]
        public FinalTrainee GetTraineeById(int id)
        {
            return traineeService.GetTraineeByID(id);
        }
        [HttpGet]
        [Route("gatAllTrainees")]
        public async Task<List<FinalTrainee>> GETALLTrainees()
        {
            return await traineeService.GETALLTrainees();
        }
        [HttpPut]
        [Route("UpdateTrainee")]
        public void UpdateAttendace(FinalTrainee trainee)
        {
            traineeService.UpdateTrainee(trainee);
        }
        [HttpPost]
        [Route("SerchTrainees")]
        public List<SearchTrainee> SerchTrainees(SearchTrainee trainee)
        {
            return traineeService.SerchTrainees(trainee);
        }
    }
}
