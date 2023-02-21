using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class AboutusService : IAboutusService
    {
        private readonly IAboutusRepository aboutusRepository;
        public AboutusService(IAboutusRepository aboutusRepository)
        {
            this.aboutusRepository = aboutusRepository;
        }

        public void CreateAbout(FinalAboutu finalAboutu)
        {
            aboutusRepository.CreateAbout(finalAboutu);
        }

        public void DeleteAbout(int id)
        {
            aboutusRepository.DeleteAbout(id);
        }

        public FinalAboutu GetAboutById(int id)
        {
            return aboutusRepository.GetAboutById(id);
        }

        public List<FinalAboutu> GetAllAbouts()
        {
            return aboutusRepository.GetAllAbouts();
        }

        public void UpdateAbout(FinalAboutu finalAboutu)
        {
            aboutusRepository.UpdateAbout(finalAboutu);
        }
    }
}
