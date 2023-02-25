using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Core.Repository
{
   public interface ITraineeRepository
    {
        Task <List<FinalTrainee>> GETALLTrainees();
        FinalTrainee GetTraineeByID(int IDD);
        void InsertTrainee(FinalTrainee trainee);
        void UpdateTrainee(FinalTrainee trainee);
        void DELETETrainee(int IDD) ;
        List<SearchTrainee> SerchTrainees(SearchTrainee trainee);
    }
}
//string Address , string Major ,string University ,string TraineeField , int RegisterStatus  ,int  User_ID 
//int IDD ,string Address_ , string Major_ ,string University_,string Trainee_Field ,int  Register_Status  , int UserID 