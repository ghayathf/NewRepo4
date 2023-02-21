using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Service
{
    public interface ICertificateService
    {
        List<FinalCertificate> GetAllCertificate();
        FinalCertificate GetTCertificateById(int id);
        void CreateCertificate(FinalCertificate finalCertificate);
        void UpdateCertificate(FinalCertificate finalCertificate);

        void DeleteCertificate(int id);
    }
}
