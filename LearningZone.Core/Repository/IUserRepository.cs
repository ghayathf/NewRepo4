using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Repository
{
   public interface IUserRepository
    {
        List<FinalUser> GETALLUsers();
        FinalUser GetUserByID(int id);
        void CREATEUser(FinalUser user);
        void UpdateUser(FinalUser user);
        void DELETEUser(int id);
    }
}
