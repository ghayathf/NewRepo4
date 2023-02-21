using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Service
{
    public interface IRoleService
    {
        List<FinalRole> GetAllRole();
        FinalRole GetTRoleById(int id);
        void CreateRole(FinalRole finalRole);
        void UpdateRole(FinalRole finalRole);

        void DeleteRole(int id);
    }
}
