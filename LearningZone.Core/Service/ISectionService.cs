using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Core.Service
{
    public interface ISectionService
    {
        Task<List<FinalSection>> GetAllSections();
        FinalSection GetSectionByID(int id);
        void CreateSection(FinalSection section);
        void UpdateSection(FinalSection section);
        void DeleteSection(int id);
    }
}
