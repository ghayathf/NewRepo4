using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class MaterialService : IMaterialService
    {
        private readonly IMaterialRepository materialRepository;

        public MaterialService(IMaterialRepository materialRepository)
        {
            this.materialRepository = materialRepository;
        }
        public void CREATEMaterial(FinalMaterial material)
        {
            materialRepository.CREATEMaterial(material);
        }

        public void DELETEMaterial(int IDD)
        {
            materialRepository.DELETEMaterial(IDD);
        }

        public List<FinalMaterial> GETALLMaterials()
        {
           return materialRepository.GETALLMaterials();
        }

        public FinalMaterial GetMaterialByID(int IDD)
        {
           return materialRepository.GetMaterialByID(IDD);
        }

        public void UpdateMaterial(FinalMaterial material)
        {
            materialRepository.UpdateMaterial(material);
        }
    }
}
