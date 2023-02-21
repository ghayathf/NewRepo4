using LearningZone.Core.Data;
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
    public class TrainerController : ControllerBase
    {
        private readonly ITrainerService trainerService;
        public TrainerController(ITrainerService trainerService)
        {
            this.trainerService = trainerService;
        }

        [HttpPost]
        [Route("CreateTrainer")]
        public void CreateTrainer(FinalTrainer trainer)
        {
            trainerService.CreateTrainer(trainer);
        }
        [HttpDelete]
        [Route("DeleteTrainer/{id}")]
        public void DeleteTrainer(int id)
        {
            trainerService.DeleteTrainer(id);
        }
        [HttpGet]
        [Route("GetTrainerByID/{id}")]
        public FinalTrainer GetTrainerByID(int id)
        {
            return trainerService.GetTrainerByID(id);
        }
        [HttpGet]
        [Route("GetAllTrainers")]
        public List<FinalTrainer> GetAllTrainers()
        {
            return trainerService.GetAllTrainers();
        }
        [HttpPut]
        [Route("UpdateTrainer")]
        public void UpdateTrainer(FinalTrainer trainer)
        {
            trainerService.UpdateTrainer(trainer);
        }
    }
}
