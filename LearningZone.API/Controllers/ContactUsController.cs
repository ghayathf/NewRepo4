using LearningZone.Core.Data;
using LearningZone.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningZone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private readonly IContactUsService contactUsService;
        public ContactUsController(IContactUsService contactUsService)
        {
            this.contactUsService = contactUsService;
        }

        [HttpPost]
        [Route("CreateContactUs")]
        public void CreateContactUs(FinalContactu contact)
        {
            contactUsService.CreateContactUs(contact);
        }
        [HttpDelete]
        [Route("DeleteContactUs/{id}")]
        public void DeleteContactUs(int id)
        {
            contactUsService.DeleteContactUs(id);
        }
        [HttpGet]
        [Route("GetContactUsByID/{id}")]
        public FinalContactu GetContactUsByID(int id)
        {
            return contactUsService.GetContactUsByID(id);
        }
        [HttpGet]
        [Route("GetAllContactUs")]
        public List<FinalContactu> GetAllContactUs()
        {
            return contactUsService.GetAllContactUs();
        }
        [HttpPut]
        [Route("UpdateContactUs")]
        public void UpdateContactUs(FinalContactu contact)
        {
            contactUsService.UpdateContactUs(contact);
        }
    }
}
