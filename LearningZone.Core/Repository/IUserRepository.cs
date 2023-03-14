using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Core.Repository
{
   public interface IUserRepository
    {
        Task<List<FinalUser>> GETALLUsers();
        FinalUser GetUserByID(int id);
        void CREATEUser(FinalUser user);
        void UpdateUser(FinalUser user);
        void DELETEUser(int id);
        FinalUser Auth(FinalUser login);
    }
}
