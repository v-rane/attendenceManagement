using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagement
{
    public class MaxAttendenceSubWise
    {
        /*
        * @className -MaxAttendenceSubWise
        * @objective - getter setters for MaxAttendenceSubWise
        */
        public string StudentName { get; set; }
        public int Attendence { get; set; }
        public string Subject { get; set; }
        public MaxAttendenceSubWise() { }
        public MaxAttendenceSubWise(string studentName, int attendence, string subject)
        {
           this.StudentName = studentName;
           this.Attendence = attendence;
           this.Subject = subject;
        }
    }
}
