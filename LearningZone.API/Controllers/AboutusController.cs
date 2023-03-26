using LearningZone.Core.Data;
using LearningZone.Core.Service;
using LearningZone.Infra.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

namespace LearningZone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutusController : ControllerBase
    {
        private readonly IAboutusService aboutusService;
        public AboutusController(IAboutusService aboutusService)
        {
            this.aboutusService = aboutusService;
        }
        [HttpPost]
        [Route("CreateAbout")]
        public void CreateAbout(FinalAboutu finalAboutu)
        {
            aboutusService.CreateAbout(finalAboutu);
        }
        [HttpDelete]
        [Route("DeleteAbout/{id}")]
        public void DeleteAbout(int id)
        {
            aboutusService.DeleteAbout(id);
        }
        [HttpGet]
        [Route("GetAboutById/{id}")]
        public FinalAboutu GetAboutById(int id)
        {
            return aboutusService.GetAboutById(id);
        }
        [HttpGet]
        [Route("gatAllAbouts")]
        public List<FinalAboutu> GetAllAbouts()
        {
            return aboutusService.GetAllAbouts();
        }
        [HttpPut]
        [Route("UpdateAbout")]
        public void UpdateAbout(FinalAboutu finalAboutu)
        {
            aboutusService.UpdateAbout(finalAboutu);
        }
        [Route("UploadImage")]
        [HttpPost]
        public FinalAboutu UploadImage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullpath = Path.Combine("C:\\LearningHub_Angular\\src\\assets\\HomeAssets\\images", fileName);

            using (var stream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            FinalAboutu item = new FinalAboutu();
            item.Aboutimage = fileName;
            return item;
        }
    }
}
