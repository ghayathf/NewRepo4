using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.Repository
{
    public interface IAttendanceRepository
    {
        List<FinalAttendance> GETALLAttendance();
        FinalAttendance GetAttendanceByID(int IDD);
        void InsertAttendance(FinalAttendance attendance);
        void UpdateAttendance(FinalAttendance attendance);
        void DELETEAttendance(int IDD);
    }
}