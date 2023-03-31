using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Core.Repository
{
    public interface ISectionRepository
    {
        Task<List<FinalSection>> GetAllSections();
        FinalSection GetSectionByID(int id);
        void CreateSection(FinalSection section);
        void UpdateSection(FinalSection section);
        void DeleteSection(int id);
        List<SecInfo> GetSecInfos(int SecId);
    }
}
