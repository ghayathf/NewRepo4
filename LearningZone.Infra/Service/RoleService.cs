using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Infra.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository roleRepository;
        public RoleService(IRoleRepository roleService)
        {
           roleRepository = roleService;
        }
        public void CreateRole(FinalRole finalRole)
        {
            roleRepository.CreateRole(finalRole);
        }

        public void DeleteRole(int id)
        {
            roleRepository.DeleteRole(id);
        }

        public Task<List<FinalRole>> GetAllRole()
        {
            return roleRepository.GetAllRole();
        }

        public FinalRole GetTRoleById(int id)
        {
            return roleRepository.GetTRoleById(id);
        }

        public void UpdateRole(FinalRole finalRole)
        {
            roleRepository.UpdateRole(finalRole);
        }
    }
}
