using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Infra.Service
{
    public class SectionService : ISectionService
    {
        private readonly ISectionRepository sectionRepository;

        public SectionService(ISectionRepository sectionRepository)
        {
            this.sectionRepository = sectionRepository;
        }
        public void CreateSection(FinalSection section)
        {
            sectionRepository.CreateSection(section);
        }

        public void DeleteSection(int id)
        {
            sectionRepository.DeleteSection(id);
        }

        public async Task<List<FinalSection>> GetAllSections()
        {
            return await sectionRepository.GetAllSections();
        }

        public FinalSection GetSectionByID(int id)
        {
            return sectionRepository.GetSectionByID(id);
        }

        public void UpdateSection(FinalSection section)
        {
            sectionRepository.UpdateSection(section);
        }
    }
}
