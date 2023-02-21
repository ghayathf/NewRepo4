using LearningZone.Core.Data;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleService _roleService;
        public RoleService(IRoleService roleService)
        {
            _roleService = roleService;
        }
        public void CreateRole(FinalRole finalRole)
        {
            _roleService.CreateRole(finalRole);
        }

        public void DeleteRole(int id)
        {
            _roleService.DeleteRole(id);
        }

        public List<FinalRole> GetAllRole()
        {
            return _roleService.GetAllRole();
        }

        public FinalRole GetTRoleById(int id)
        {
            return _roleService.GetTRoleById(id);
        }

        public void UpdateRole(FinalRole finalRole)
        {
            _roleService.UpdateRole(finalRole);
        }
    }
}
