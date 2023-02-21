using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using LearningZone.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class AttendaceService : IAttendeceService
    {
        private readonly IAttendanceRepository attendaceRepository;

        public AttendaceService(IAttendanceRepository attendaceRepository)
        {
            this.attendaceRepository = attendaceRepository;
        }
        public void DELETEAttendance(int IDD)
        {
            attendaceRepository.DELETEAttendance(IDD);
        }

        public List<FinalAttendance> GETALLAttendance()
        {
            return attendaceRepository.GETALLAttendance();
        }

        public FinalAttendance GetAttendanceByID(int IDD)
        {
            return attendaceRepository.GetAttendanceByID(IDD);
        }

        public void InsertAttendance(FinalAttendance attendance)
        {
            attendaceRepository.InsertAttendance(attendance);
        }

        public void UpdateAttendance(FinalAttendance attendance)
        {
            attendaceRepository.UpdateAttendance(attendance);
        }
    }
}
