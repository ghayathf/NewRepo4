using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Repository
{
    public interface ITakeAttendanceRepository
    {
        List<FinalTakeattendance> GetAttendanceByID(int IDD);
        List<FinalTakeattendance> GetAttendanceByDate(DateTime D);
        void CreateAttendance(FinalTakeattendance takeattendance);
        void CreateAbsence(FinalTakeattendance takeattendance);
        void UpdateAttendance(FinalTakeattendance takeattendance);
        int RetrieveAttendanceCount(int IDD);
        List<FinalTrainee> GetAbsentTrainees(int SecID);
    }
}
