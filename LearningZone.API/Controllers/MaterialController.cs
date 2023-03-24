using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using LearningZone.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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
        public void DeleteMaterial(int id)
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
        public List<FinalMaterial> GatAllMaterials()
        {
            return materialService.GETALLMaterials();
        }
        [HttpPut]
        [Route("UpdateMaterial")]
        public void UpdateMaterial(FinalMaterial material)
        {
            materialService.UpdateMaterial(material);
        }
        [HttpPost]
        [Route("SearchMaterials")]
        public List<FinalMaterial> SearchMaterials([FromBody]SearchMaterial material)
        {
            return materialService.SearchMaterials(material);
        }


        [Route("UploadMaterial")]
        [HttpPost]
        public FinalMaterial UploadMaterial()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullpath = Path.Combine("C:\\LearningHub_Angular\\src\\assets\\HomeAssets\\Materials", fileName);

            using (var stream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            FinalMaterial item = new FinalMaterial();
            item.Filepath = fileName;

            return item;
        }
    }
}
