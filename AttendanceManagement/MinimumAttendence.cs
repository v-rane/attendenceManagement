using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagement
{
    public class MinimumAttendence
    {
        /*
         * @className -MinimumAttendence
         * @objective - getter setters for MinimumAttendence
         */
        public string StudentName { get; set; }
        public int MinAttendance { get; set; }

        public MinimumAttendence() { }
        public MinimumAttendence(string studentName, int minAttendance)
        {
            this.StudentName = studentName;
            this.MinAttendance = minAttendance;
        }

    }
}
