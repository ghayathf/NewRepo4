using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class HomeService : IHomeService
    {
        private readonly IHomeRepository _homeRepository;

        public HomeService(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }

        public void CreateHomeInformation(FinalHomepage finalHomepage)
        {
            _homeRepository.CreateHomeInformation(finalHomepage);
        }

        public void DeleteHomeInformation(int id)
        {
            _homeRepository.DeleteHomeInformation(id);
        }

        public List<FinalHomepage> GetAllHomeInformation()
        {
            return _homeRepository.GetAllHomeInformation();
        }

        public FinalHomepage GetHomeInformationById(int id)
        {
            return _homeRepository.GetHomeInformationById(id);
        }

        public void UpdateHomeInformation(FinalHomepage finalHomepage)
        {
            _homeRepository.UpdateHomeInformation(finalHomepage);
        }
    }
}
