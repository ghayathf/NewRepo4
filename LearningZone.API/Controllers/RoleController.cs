using LearningZone.Core.Data;
using LearningZone.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LearningZone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        [HttpGet]
        public List<FinalRole> GetAllRole()
        {
            return _roleService.GetAllRole();
        }
        [HttpGet]
        [Route("GetTRoleById/{id}")]
       public FinalRole GetTRoleById(int id)
        {
            return _roleService.GetTRoleById(id);
        }
        [HttpPost]
        public void CreateRole(FinalRole finalRole)
        {
            _roleService.CreateRole(finalRole);
        }
        [HttpPut]
        public void UpdateRole(FinalRole finalRole)
        {
            _roleService.UpdateRole(finalRole);
        }
        [HttpDelete]
        public void DeleteRole(int id)
        {
            _roleService.DeleteRole(id);
        }
    }
}
