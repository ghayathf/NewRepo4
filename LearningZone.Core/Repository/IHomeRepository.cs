using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Repository
{
    public interface IHomeRepository
    {
        List<FinalHomepage> GetAllHomeInformation();
        FinalHomepage GetHomeInformationById(int id);
    }
}
