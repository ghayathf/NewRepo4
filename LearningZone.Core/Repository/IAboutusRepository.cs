using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Core.Repository
{
    public interface IAboutusRepository
    {
        List<FinalAboutu> GetAllAbouts();
        FinalAboutu GetAboutById(int id);
        void CreateAbout(FinalAboutu finalAboutu);
        void UpdateAbout(FinalAboutu finalAboutu);
        void DeleteAbout(int id);
    }
}
