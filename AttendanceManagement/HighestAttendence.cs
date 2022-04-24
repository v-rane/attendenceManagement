using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagement
{
    public class MaxAttendanceStudent
    {
        /*
        * @className -MaxAttendanceStudent
        * @objective - getter setters for MaxAttendanceStudent
        */
        public string StudentName { get; set; }
        public int MaxAttendance { get; set; }

        public MaxAttendanceStudent() { }
        public MaxAttendanceStudent(string studentName ,int maxAttendance)
        {
            this.StudentName = studentName;
            this.MaxAttendance = maxAttendance;
        }
    }
}
