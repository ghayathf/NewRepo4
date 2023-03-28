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
    public class TakeAttendanceController : ControllerBase
    {
        private readonly ITakeAttendanceService takeAttendanceService;
        public TakeAttendanceController(ITakeAttendanceService takeAttendanceService)
        {
            this.takeAttendanceService = takeAttendanceService;
        }

        [HttpPost]
        [Route("CreateAbsence")]
        public void CreateAbsence(FinalTakeattendance takeattendance)
        {
            takeAttendanceService.CreateAbsence(takeattendance);
        }
        [HttpPost]
        [Route("CreateAttendance")]
        public void CreateAttendance(FinalTakeattendance takeattendance)
        {
            takeAttendanceService.CreateAttendance(takeattendance);
        }
        [HttpGet]
        [Route("GetAttendanceByDate/{D}")]
        public List<FinalTakeattendance> GetAttendanceByDate(DateTime D)
        {
            return takeAttendanceService.GetAttendanceByDate(D);
        }
        [HttpGet]
        [Route("GetAttendanceByID/{IDD}")]
        public List<FinalTakeattendance> GetAttendanceByID(int IDD)
        {
            return takeAttendanceService.GetAttendanceByID(IDD);
        }
        [HttpGet]
        [Route("RetrieveAttendanceCount/{IDD}")]
        public int RetrieveAttendanceCount(int IDD)
        {
            return takeAttendanceService.RetrieveAttendanceCount(IDD);
        }
        [HttpPut]
        [Route("UpdateAttendance")]
        public void UpdateAttendance(FinalTakeattendance takeattendance)
        {
            takeAttendanceService.UpdateAttendance(takeattendance);
        }
        [HttpGet]
        [Route("GetAbsentTrainees/{SecID}")]
        public List<FinalTrainee> GetAbsentTrainees(int SecID)
        {
            return takeAttendanceService.GetAbsentTrainees(SecID);
        }
    }
}
