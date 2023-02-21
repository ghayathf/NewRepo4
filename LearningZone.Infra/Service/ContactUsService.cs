using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class ContactUsService : IContactUsService
    {
        private readonly IContactUsRepository contactUsRepository;

        public ContactUsService(IContactUsRepository contactUsRepository)
        {
            this.contactUsRepository = contactUsRepository;
        }

        public void CreateContactUs(FinalContactu contact)
        {
            contactUsRepository.CreateContactUs(contact);
        }

        public void DeleteContactUs(int id)
        {
            contactUsRepository.DeleteContactUs(id);
        }

        public List<FinalContactu> GetAllContactUs()
        {
            return contactUsRepository.GetAllContactUs();
        }

        public FinalContactu GetContactUsByID(int id)
        {
            return contactUsRepository.GetContactUsByID(id);
        }

        public void UpdateContactUs(FinalContactu contact)
        {
            contactUsRepository.UpdateContactUs(contact);
        }
    }
}
