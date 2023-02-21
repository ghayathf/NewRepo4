using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Service
{
    public interface IAboutusService
    {
        List<FinalAboutu> GetAllAbouts();
        FinalAboutu GetAboutById(int id);
        void CreateAbout(FinalAboutu finalAboutu);
        void UpdateAbout(FinalAboutu finalAboutu);
        void DeleteAbout(int id);
    }
}
