using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Core.Repository
{
    public interface IRoleRepository
    {
        Task<List<FinalRole>> GetAllRole();
        FinalRole GetTRoleById(int id);
        void CreateRole(FinalRole finalRole);
        void UpdateRole(FinalRole finalRole);

        void DeleteRole(int id);
    }
}
