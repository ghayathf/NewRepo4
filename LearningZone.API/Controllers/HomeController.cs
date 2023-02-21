using LearningZone.Core.Data;
using LearningZone.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;

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
        
        public void CreateHomeInformation(FinalHomepage finalHomepage)
        {
            _homeService.CreateHomeInformation(finalHomepage);
        }
        [HttpPut]
        public void UpdateHomeInformation(FinalHomepage finalHomepage)
        {
            _homeService.UpdateHomeInformation(finalHomepage);
        }

        [HttpDelete]
        public void DeleteHomeInformation(int id)
        {
            _homeService.DeleteHomeInformation(id);
        }
    }
}
