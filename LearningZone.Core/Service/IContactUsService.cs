using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Service
{
    public interface IContactUsService
    {
        List<FinalContactu> GetAllContactUs();
        FinalContactu GetContactUsByID(int id);
        void CreateContactUs(FinalContactu contact);
        void UpdateContactUs(FinalContactu contact);
        void DeleteContactUs(int id);
    }
}
