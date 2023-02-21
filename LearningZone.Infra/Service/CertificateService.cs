using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class CertificateService : ICertificateService
    {
        private readonly ICertificateRepository _certificateRepository;


        public CertificateService(ICertificateRepository _certificateRepository)
        {
            this._certificateRepository = _certificateRepository;
        }

        public void CreateCertificate(FinalCertificate finalCertificate)
        {
           _certificateRepository.CreateCertificate(finalCertificate);
        }

        public void DeleteCertificate(int id)
        {
            _certificateRepository.DeleteCertificate(id);
        }

        public List<FinalCertificate> GetAllCertificate()
        {
            return _certificateRepository.GetAllCertificate();
        }

        public FinalCertificate GetTCertificateById(int id)
        {
            return _certificateRepository.GetTCertificateById(id);
        }

        public void UpdateCertificate(FinalCertificate finalCertificate)
        {
            _certificateRepository.UpdateCertificate(finalCertificate);
        }
    }
}
