using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Service
{
    public interface IHomeService
    {
        List<FinalHomepage> GetAllHomeInformation();
        FinalHomepage GetHomeInformationById(int id);
        void CreateHomeInformation(FinalHomepage finalHomepage);
        void UpdateHomeInformation(FinalHomepage finalHomepage);

        void DeleteHomeInformation(int id);
    }
}
