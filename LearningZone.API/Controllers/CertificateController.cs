using LearningZone.Core.Data;
using LearningZone.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LearningZone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateController : ControllerBase
    {
        private readonly ICertificateService _certificateService;

        public CertificateController(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }
        [HttpGet]
        public List<FinalCertificate> GetAllCertificate()
        {
           return _certificateService.GetAllCertificate();
        }
        [HttpGet]
        [Route("GetTCertificateById/{id}")]
        public FinalCertificate GetTCertificateById(int id)
        {
            return _certificateService.GetTCertificateById(id);
        }
        [HttpPost]
       public void CreateCertificate(FinalCertificate finalCertificate)
        {
            _certificateService.CreateCertificate(finalCertificate);
        }
        [HttpPut]
        public void UpdateCertificate(FinalCertificate finalCertificate)
        {
            _certificateService.UpdateCertificate(finalCertificate);
        }
        [HttpDelete]
        public void DeleteCertificate(int id)
        {
            _certificateService.DeleteCertificate(id);
        }
    }
}
