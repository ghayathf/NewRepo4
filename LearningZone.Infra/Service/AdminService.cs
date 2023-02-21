using LearningZone.Core.Data;
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

        public void DeleteAdmin(int id)
        {
            adminRepository.DeleteAdmin(id);
        }

        public FinalAdmin GetAdminByID(int id)
        {
            return adminRepository.GetAdminByID(id);
        }

        public List<FinalAdmin> GetAllAdmins()
        {
            return adminRepository.GetAllAdmins();
        }

        public void UpdateAdmin(FinalAdmin admin)
        {
            adminRepository.UpdateAdmin(admin);
        }
    }
}
