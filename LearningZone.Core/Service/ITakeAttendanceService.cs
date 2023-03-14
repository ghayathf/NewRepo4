using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Service
{
    public interface ITakeAttendanceService
    {
        List<FinalTakeattendance> GetAttendanceByID(int IDD);
        List<FinalTakeattendance> GetAttendanceByDate(DateTime D);
        void CreateAttendance(FinalTakeattendance takeattendance);
        void CreateAbsence(FinalTakeattendance takeattendance);
        void UpdateAttendance(FinalTakeattendance takeattendance);
        int RetrieveAttendanceCount(int IDD);
        List<FinalTrainee> GetAbsentTrainees();
    }
}
