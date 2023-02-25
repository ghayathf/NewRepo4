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
    public class AdminController : ControllerBase
    {
        private readonly IAdminService adminService;
        public AdminController(IAdminService adminService)
        {
            this.adminService = adminService;
        }

        [HttpPost]
        [Route("CreateAdmin")]
        public void CreateAdmin(FinalAdmin admin)
        {
            adminService.CreateAdmin(admin);
        }
        [HttpDelete]
        [Route("DeleteAdmin/{id}")]
        public void DeleteAdmin(int id)
        {
            adminService.DeleteAdmin(id);
        }
        [HttpGet]
        [Route("GetAdminByID/{id}")]
        public FinalAdmin GetAdminByID(int id)
        {
            return adminService.GetAdminByID(id);
        }
        [HttpGet]
        [Route("GetAllAdmins")]
        public List<FinalAdmin> GetAllAdmins()
        {
            return adminService.GetAllAdmins();
        }
        [HttpPut]
        [Route("UpdateAdmin")]
        public void UpdateAdmin(FinalAdmin admin)
        {
            adminService.UpdateAdmin(admin);
        }
        [HttpPut]
        [Route("HandleRegistration")]
        public void HandleRegistration(FinalTrainee trainee)
        {
            adminService.HandleRegistration(trainee);
        }
    }
}
