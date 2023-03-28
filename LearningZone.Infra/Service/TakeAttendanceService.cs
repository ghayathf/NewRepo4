using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class TakeAttendanceService : ITakeAttendanceService
    {
        private readonly ITakeAttendanceRepository takeAttendanceRepository;

        public TakeAttendanceService(ITakeAttendanceRepository takeAttendanceRepository)
        {
            this.takeAttendanceRepository = takeAttendanceRepository;
        }

        public void CreateAbsence(FinalTakeattendance takeattendance)
        {
            takeAttendanceRepository.CreateAbsence(takeattendance);
        }

        public void CreateAttendance(FinalTakeattendance takeattendance)
        {
            takeAttendanceRepository.CreateAttendance(takeattendance);
        }

        public List<FinalTrainee> GetAbsentTrainees(int SecID)
        {
            return takeAttendanceRepository.GetAbsentTrainees(SecID);
        }

        public List<FinalTakeattendance> GetAttendanceByDate(DateTime D)
        {
            return takeAttendanceRepository.GetAttendanceByDate(D);
        }

        public List<FinalTakeattendance> GetAttendanceByID(int IDD)
        {
            return takeAttendanceRepository.GetAttendanceByID(IDD);
        }

        public int RetrieveAttendanceCount(int IDD)
        {
            return takeAttendanceRepository.RetrieveAttendanceCount(IDD);
        }

        public void UpdateAttendance(FinalTakeattendance takeattendance)
        {
            takeAttendanceRepository.UpdateAttendance(takeattendance);
        }
    }
}
