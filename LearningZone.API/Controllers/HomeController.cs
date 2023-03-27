using LearningZone.Core.Data;
using LearningZone.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.IO;

namespace LearningZone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet]
        [Route("GetAllHomeInformatio")]
        public List<FinalHomepage> GetAllHomeInformation()
        {
            return _homeService.GetAllHomeInformation();
        }

        [HttpGet]
        [Route("GetHomeInformationById/{id}")]
        public FinalHomepage GetHomeInformationById(int id)
        {
            return _homeService.GetHomeInformationById(id);
        }
        [HttpPost]
        [Route("CreateHomePage")]
        public void CreateHomeInformation(FinalHomepage finalHomepage)
        {
            _homeService.CreateHomeInformation(finalHomepage);
        }
        [HttpPut]
        [Route("UpdateHomePage")]
        public void UpdateHomeInformation(FinalHomepage finalHomepage)
        {
            _homeService.UpdateHomeInformation(finalHomepage);
        }

        [HttpDelete]
        [Route("DeleteHomePage/{id}")]
        public void DeleteHomeInformation(int id)
        {
            _homeService.DeleteHomeInformation(id);
        }
        [Route("UploadImage")]
        [HttpPost]
        public FinalHomepage UploadImage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullpath = Path.Combine("C:\\LearningHub_Angular\\src\\assets\\HomeAssets\\images", fileName);

            using (var stream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            FinalHomepage item = new FinalHomepage();
            item.Logo = fileName;
            return item;
        }
    }
}
