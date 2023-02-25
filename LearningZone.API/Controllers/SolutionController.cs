using LearningZone.Core.Data;
using LearningZone.Core.Repository;
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
    public class SolutionController : ControllerBase
    {
        private readonly ISolutionRepository solutionService;
        public SolutionController(ISolutionRepository solutionService)
        {
            this.solutionService = solutionService;
        }

        [HttpPost]
        [Route("CreateSolution")]
        public void CreateSolution(FinalSolution solution)
        {
            solutionService.CreateSolution(solution);
        }
        [HttpDelete]
        [Route("DeleteSolution/{id}")]
        public void DeleteSolution(int id)
        {
            solutionService.DeleteSolution(id);
        }
        [HttpGet]
        [Route("GetSolutionByID/{id}")]
        public FinalSolution GetSolutionByID(int id)
        {
            return solutionService.GetSolutionByID(id);
        }
        [HttpGet]
        [Route("GetAllSolutions")]
        public List<FinalSolution> GetAllSolutions()
        {
            return solutionService.GetAllSolutions();
        }
        [HttpPut]
        [Route("UpdateSolution")]
        public void UpdateSolution(FinalSolution solution)
        {
            solutionService.UpdateSolution(solution);
        }
        [HttpPut]
        [Route("EnterSolutionMark/{id}/{mark}")]
        public void EnterSolutionMark(int id, double mark)
        {
            solutionService.EnterSolutionMark(id, mark);
        }
    }
}
