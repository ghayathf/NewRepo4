using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using LearningZone.Core.Service;
using LearningZone.Infra.Repository;
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
        [HttpGet]
        [Route("GetSecTrainees/{secId}")]
        public List<SectionTrainees> GetSectionTrainees(int secId)
        {
            return traineeService.GetSectionTrainees(secId);
        }
        [HttpPost]
        [Route("InsertTrainee")]
        public void InsertAttendance(FinalTrainee trainee)
        {
            traineeService.InsertTrainee(trainee);
        }  
        [HttpGet]
        [Route("GetAllTraineeUser")]
        public List<TraineeUser> GetAllTraineeUsers()
        {
            return traineeService.GetAllTraineeUsers();
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

        [HttpGet]
        [Route("GetAllAccepted")]
        public List<AcceptedTrainee> GetAllAccepted()
        {
            return traineeService.GetAllAccepted();

        }
    }
}
