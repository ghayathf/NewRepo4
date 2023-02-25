using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Repository
{
    public interface IMaterialRepository
    {
        List<FinalMaterial> GETALLMaterials();
        FinalMaterial GetMaterialByID(int IDD );
        void CREATEMaterial(FinalMaterial material);
        void UpdateMaterial(FinalMaterial material);
        void DELETEMaterial(int IDD);
        List<FinalMaterial> SearchMaterials(SearchMaterial material);
    }
}
