using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Core.Service
{
  public  interface IUserService
    {
        Task<List<FinalUser>> GETALLUsers();
        FinalUser GetUserByID(int id);
        void CREATEUser(FinalUser user);
        void UpdateUser(FinalUser user);
        void DELETEUser(int id);
        string Auth(FinalUser login);
        List<TrainerInfo> GetTrainerInfoByUserId(int usid);
    }
}
