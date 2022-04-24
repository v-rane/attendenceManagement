using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagement
{
    public class AttendancePerSubject
    {
        /*
        * @className -AttendancePerSubject
        * @objective - getter setters for AttendancePerSubject
        */
        public string SubjectName { get; set; }
        public decimal AvgAttendence { get; set; }

        public AttendancePerSubject() { }
        public AttendancePerSubject(string subjectName, decimal avgAttendance)
        {
            SubjectName = subjectName;
            AvgAttendence = avgAttendance;
        }
    }
}
