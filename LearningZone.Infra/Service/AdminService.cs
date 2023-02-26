using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository;
        }

        public void CreateAdmin(FinalAdmin admin)
        {
            adminRepository.CreateAdmin(admin);
        }
        public OptainReport optainReport()
        {
            return adminRepository.optainReport();
        }
        public void DeleteAdmin(int id)
        {
            adminRepository.DeleteAdmin(id);
        }

        public void GenerateCertificate(int type)
        {
            adminRepository.GenerateCertificate(type);
        }

        public FinalAdmin GetAdminByID(int id)
        {
            return adminRepository.GetAdminByID(id);
        }

        public List<FinalAdmin> GetAllAdmins()
        {
            return adminRepository.GetAllAdmins();
        }

        public void HandleRegistration(FinalTrainee trainee)
        {
            adminRepository.HandleRegistration( trainee);
        }

        public void UpdateAdmin(FinalAdmin admin)
        {
            adminRepository.UpdateAdmin(admin);
        }
    }
}
