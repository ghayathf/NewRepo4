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
    public class MaterialController : ControllerBase
    {
        private readonly IMaterialService materialService;
        public MaterialController(IMaterialService materialService)
        {
            this.materialService = materialService;
        }
        [HttpPost]
        [Route("CreateMaterial")]
        public void CreateMaterial(FinalMaterial material)
        {
            materialService.CREATEMaterial(material);
        }
        [HttpDelete]
        [Route("DeleteMaterial/{id}")]
        public void DeleteAbout(int id)
        {
            materialService.DELETEMaterial(id);
        }
        [HttpGet]
        [Route("GetMaterialById/{id}")]
        public FinalMaterial GetMaterialByID(int id)
        {
            return materialService.GetMaterialByID(id);
        }
        [HttpGet]
        [Route("gatAllMaterials")]
        public List<FinalMaterial> GetAllAbouts()
        {
            return materialService.GETALLMaterials();
        }
        [HttpPut]
        [Route("UpdateMaterial")]
        public void UpdateAbout(FinalMaterial material)
        {
            materialService.UpdateMaterial(material);
        }
    }
}
