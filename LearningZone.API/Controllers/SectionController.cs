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
    public class SectionController : ControllerBase
    {
        private readonly ISectionService sectionService;
        public SectionController(ISectionService sectionService)
        {
            this.sectionService = sectionService;
        }
        [HttpGet]
        [Route("GetTSInfos/{SecId}/{traineeId}")]
        public List<TSInfo> GetTSInfos(int SecId, int traineeId)
        {
            return sectionService.GetTSInfos(SecId, traineeId);
        }
        [HttpGet]
        [Route("GetSecInfo/{SecId}")]
        public List<SecInfo> GetSecInfos(int SecId)
        {
            return sectionService.GetSecInfos(SecId);
        }
        [HttpPost]
        [Route("CreateSection")]
        public void CreateSection(FinalSection section)
        {
            sectionService.CreateSection(section);
        }
        [HttpDelete]
        [Route("DeleteSection/{id}")]
        public void DeleteSection(int id)
        {
            sectionService.DeleteSection(id);
        }
        [HttpGet]
        [Route("GetSectionByID/{id}")]
        public FinalSection GetSectionByID(int id)
        {
            return sectionService.GetSectionByID(id);
        }
        [HttpGet]
        [Route("GetAllSections")]
        public async Task<List<FinalSection>> GetAllSections()
        {
            return await sectionService.GetAllSections();
        }
        [HttpPut]
        [Route("UpdateSection")]
        public void UpdateSection(FinalSection section)
        {
            sectionService.UpdateSection(section);
        }
    }
}
