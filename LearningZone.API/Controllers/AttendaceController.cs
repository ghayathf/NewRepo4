using LearningZone.Core.Data;
using LearningZone.Core.Service;
using LearningZone.Infra.Service;
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
    public class AttendaceController : ControllerBase
    {
        private readonly IAttendeceService attendaceService;
        public AttendaceController(IAttendeceService attendaceService)
        {
            this.attendaceService = attendaceService;
        }
        [HttpPost]
        [Route("InsertAttendace")]
        public void InsertAttendance(FinalAttendance attendance)
        {
            attendaceService.InsertAttendance(attendance);
        }
        [HttpDelete]
        [Route("DeleteAttendace/{id}")]
        public void DeleteAttendace(int id)
        {
            attendaceService.DELETEAttendance(id);
        }
        [HttpGet]
        [Route("GetAttendaceById/{id}")]
        public FinalAttendance GetAboutById(int id)
        {
            return attendaceService.GetAttendanceByID(id);
        }
        [HttpGet]
        [Route("gatAll")]
        public List<FinalAttendance> GETALLAttendance()
        {
            return attendaceService.GETALLAttendance();
        }
        [HttpPut]
        [Route("UpdateAttendace")]
        public void UpdateAttendace(FinalAttendance attendance)
        {
            attendaceService.UpdateAttendance(attendance);
        }
    }
}
