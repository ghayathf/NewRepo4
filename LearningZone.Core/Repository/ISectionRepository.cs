using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Repository
{
    public interface ISectionRepository
    {
        List<FinalSection> GetAllSections();
        FinalSection GetSectionByID(int id);
        void CreateSection(FinalSection section);
        void UpdateSection(FinalSection section);
        void DeleteSection(int id);
    }
}
