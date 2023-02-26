using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Repository
{
    public interface IAdminRepository
    {
        List<FinalAdmin> GetAllAdmins();
        FinalAdmin GetAdminByID(int id);
        void CreateAdmin(FinalAdmin admin);
        void UpdateAdmin(FinalAdmin admin);
        void DeleteAdmin(int id);
        void HandleRegistration(FinalTrainee trainee);
        void GenerateCertificate(int type);
        OptainReport optainReport();
    }
}
