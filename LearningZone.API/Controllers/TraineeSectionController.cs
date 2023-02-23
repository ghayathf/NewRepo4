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
    public class TraineeSectionController : ControllerBase
    {
        private readonly ITraineeSectionService traineeSectionService;
        public TraineeSectionController(ITraineeSectionService traineeSectionService)
        {
            this.traineeSectionService = traineeSectionService;
        }
        [HttpPost]
        [Route("CreateTraineeSection")]
        public void CREATETraineeSection(FinalTraineesection traineesection)
        {
            traineeSectionService.CREATETraineeSection(traineesection);

        }
        [HttpDelete]
        [Route("DeleteTraineeSection/{id}")]
        public void DELETETraineeSection(int id)
        {
            traineeSectionService.DELETETraineeSection(id);
        }
        [HttpGet]
        [Route("GetAllTraineeSections")]
        public async Task<List<FinalTraineesection>> GETALLTraineeSections()
        {
            return await traineeSectionService.GETALLTraineeSections();
        }
        [HttpGet]
        [Route("GetTraineeSectionByID/{id}")]
        public FinalTraineesection GetTraineeSectionByID(int id)
        {
            return traineeSectionService.GetTraineeSectionByID(id);
        }
        [HttpPut]
        [Route("UpdateTraineeSection")]
        public void UpdateTraineeSection(FinalTraineesection traineesection)
        {
            traineeSectionService.UpdateTraineeSection(traineesection);
        }

    }
}
