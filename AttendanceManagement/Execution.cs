using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagement
{
     public class Execution
    {
        /*
         * @className - Execution
         * @objective - to do orcastation of program by calling several methods  
         */
        static void Main(string[] args)
        {
            //creating objects of studentdata and adding objects in it
            StudentData studentData1 = new StudentData(101,"Ravi","English",24);
            StudentData studentData2 = new StudentData(101,"Ravi","Maths",20);
            StudentData studentData3 = new StudentData(101,"Ravi","Physics",23);
            StudentData studentData4 = new StudentData(101,"Ravi","Chem",24);
            StudentData studentData5 = new StudentData(102,"Rakesh","English",21);
            StudentData studentData6 = new StudentData(102,"Rakesh","Maths",23);
            StudentData studentData7 = new StudentData(102,"Rakesh","Physics",20);
            StudentData studentData8 = new StudentData(102,"Rakesh","Chem",24);
            StudentData studentData9 = new StudentData(103,"Akash","English",22);
            StudentData studentData10 = new StudentData(103,"Akash","Maths",19);
            StudentData studentData11 = new StudentData(103,"Akash","English",22);
            StudentData studentData12 = new StudentData(103,"Akash","Physics",20);
            StudentData studentData13 = new StudentData(103,"Akash","Chem",21);
            StudentData studentData14 = new StudentData(104,"Vikram","Maths",22);
            StudentData studentData15 = new StudentData(104,"Vikram","Physics",20);
            StudentData studentData16 = new StudentData(104,"Vikram","Chem",25);

            //creating list of studentData type and adding objects in it
            List<StudentData> studentList = new List<StudentData>();
            studentList.Add(studentData1);
            studentList.Add(studentData2);
            studentList.Add(studentData3);
            studentList.Add(studentData4);
            studentList.Add(studentData5);
            studentList.Add(studentData6);
            studentList.Add(studentData7);
            studentList.Add(studentData8);
            studentList.Add(studentData9);
            studentList.Add(studentData10);
            studentList.Add(studentData11);
            studentList.Add(studentData12);
            studentList.Add(studentData13);
            studentList.Add(studentData14);
            studentList.Add(studentData15);
            studentList.Add(studentData16);
            
            //creating objects of BussinessLogicOperations and calling methods by using it
            BussinessLogicOperations bussinessLogicOperations  = new BussinessLogicOperations();
            //problem 1:-
            Console.WriteLine("To find avarage attendance per subject");
            List<AttendancePerSubject> resultList = bussinessLogicOperations.getAttendancePerSubjects(studentList);
            foreach (AttendancePerSubject value in resultList)
            {
                Console.WriteLine(value.SubjectName + "," + value.AvgAttendence);
            }
            Console.WriteLine("************************************************************************************************************");

            //problem 2:-
            Console.WriteLine(" name of students who has maximum attendance across all subject");
            MaxAttendanceStudent obj = bussinessLogicOperations.getMaxAttendanceStudents(studentList);
            Console.WriteLine(obj.StudentName + " , " + obj.MaxAttendance);
            Console.WriteLine("****************************************************************************************************************");

            //problem 3:-
            Console.WriteLine(" To find name of students who has highest attendence in each subject");
            List<MaxAttendenceSubWise> resList =bussinessLogicOperations.getMaxAttendenceSubWise(studentList);
            foreach(MaxAttendenceSubWise value in resList)
            {
                Console.WriteLine(value.StudentName +"  , "+ value.Subject + "  , " + value.Attendence);
            }
            Console.WriteLine("******************************************************************************************************************");

            //problem 4:-
            Console.WriteLine(" To find name of students who has minimum attendance across all subject");
            MinimumAttendence result = bussinessLogicOperations.getMinAttendenceStudents(studentList);
            Console.WriteLine(result.StudentName +" ," + result.MinAttendance);
            Console.WriteLine("****************************************************************************************************************");

            //problem 5:-
            Console.WriteLine(" To list students name in order of their overall attendance across all subjects");
            List<OverallAttendenceSubWise> resList1 = bussinessLogicOperations.getOverallAttendenceSubWise(studentList);
            foreach (OverallAttendenceSubWise value in resList1)
            {
                Console.WriteLine(value.StudentName +"  ,"+value.TotalAttendence);
            }

        }
    }
}
