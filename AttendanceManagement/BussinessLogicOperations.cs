using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagement
{
    public class BussinessLogicOperations
    {
        public List<AttendancePerSubject> getAttendancePerSubjects(List<StudentData> list) 
        {
            /*
             * @methodName- getAttendancePerSubjects
             * @objective -to find avarage attendance per subject
             * @para - List<StudentData>
             * @return - List<AttendancePerSubject>
            */
            //dic creating with key as subject name and  taking values as object of AttendancePerSubject
            Dictionary<string, AttendancePerSubject> dic = new Dictionary<string, AttendancePerSubject>();
            //list created for storing result
            List<AttendancePerSubject> resultList = new List<AttendancePerSubject>();
            foreach (StudentData student in list)
            {
                //temp variable for storing average of attendence
                decimal avgOfsubjectAttendance = 0;
                if (dic.ContainsKey(student.SubjectName))
                {
                    //logic :- dic has same subjectName then => (existing avg + student's attendence )/2
                    avgOfsubjectAttendance = (dic[student.SubjectName].AvgAttendence + student.Attendance)/2; 
                    dic[student.SubjectName].AvgAttendence = avgOfsubjectAttendance;
                   
                }
                else
                {
                    //if dic does not  subjectName then => create object of AttendancePerSubject and add values in it
                    AttendancePerSubject attendancePerSubject = new AttendancePerSubject();
                    dic.Add(student.SubjectName, attendancePerSubject);
                    attendancePerSubject.SubjectName = student.SubjectName;
                    attendancePerSubject.AvgAttendence = student.Attendance;
                }
            }
            //iterating dic and adding values in resultList
            foreach(var str  in dic.Values)
            {
                resultList.Add(str);
            }
            return resultList;
        }
        //*********************************************************************************************************************************************************

        public MaxAttendanceStudent getMaxAttendanceStudents(List<StudentData> list)
        {
            /*
            * @methodName- getMaxAttendanceStudents
            * @objective - To find name of students who has maximum attendance across all subject
            * @para - List<StudentData>
            * @return - MaxAttendanceStudent
            */
            //dic created which has key as student name and value as object type of MaxAttendanceStudent
            Dictionary<string, MaxAttendanceStudent> dic = new Dictionary<string, MaxAttendanceStudent>();
            foreach (StudentData student in list)
            {
                if (dic.ContainsKey(student.StudentName))
                {
                    //logic :- if dic has studentName then  => add in existing MaxAttendance student's attendence
                    dic[student.StudentName].MaxAttendance += student.Attendance;
                }
                else
                {
                    //if dic does not contains student name then create object of MaxAttendanceStudent and add values in it 
                    dic.Add(student.StudentName,new MaxAttendanceStudent());
                    dic[student.StudentName].StudentName = student.StudentName;
                    dic[student.StudentName].MaxAttendance = student.Attendance;
                }
            }
            MaxAttendanceStudent maxAttendanceStudent = new MaxAttendanceStudent();
            //adding min possible value of int in maxAttendence
            maxAttendanceStudent.MaxAttendance = int.MinValue;
            //created object of MaxAttendanceStudent to assigning values from dic  to it by iterating dic 
            foreach (MaxAttendanceStudent str in dic.Values)
            {
                //if existing attendence of dic is greater than MaxAttendance then assign it in object of maxAttendanceStudent
                if (str.MaxAttendance> maxAttendanceStudent.MaxAttendance)
                {
                   maxAttendanceStudent.MaxAttendance = str.MaxAttendance;
                   maxAttendanceStudent.StudentName=str.StudentName;
                }
            }
            //object is returning because we need single entity type 
            return maxAttendanceStudent;
        }
        //************************************************************************************************************************************
        public List<MaxAttendenceSubWise> getMaxAttendenceSubWise(List<StudentData> list)
        {
            /*
            * @methodName- getMaxAttendenceSubWise
            * @objective - To find name of students who has minimum attendance across all subject
            * @para - List<StudentData>
            * @return - MaxAttendenceSubWise
            */

            //dic created which has key as student name and value as object type of MaxAttendenceSubWise
            Dictionary<string, MaxAttendenceSubWise> dic = new Dictionary<string,  MaxAttendenceSubWise>();
            MaxAttendenceSubWise maxAttendenceSubWise = new MaxAttendenceSubWise();
            //resList is created for storing result
            List<MaxAttendenceSubWise> resList = new List<MaxAttendenceSubWise>();
            foreach (StudentData student in list)
            {
                if (dic.ContainsKey(student.SubjectName))
                {
                //if dic has subjectName then compare attendence of  that Student to the student's attendence coming from list
                    if (dic[student.SubjectName].Attendence < student.Attendance)
                    {
                        dic[student.SubjectName].StudentName = student.StudentName;
                        dic[student.SubjectName].Subject = student.SubjectName;
                        dic[student.SubjectName].Attendence = student.Attendance;
                    }
                }
                else
                {
                    //if dic does not contains subject name then add values in it
                    dic.Add(student.SubjectName, new MaxAttendenceSubWise());
                    dic[student.SubjectName].StudentName = student.StudentName;
                    dic[student.SubjectName].Subject = student.SubjectName;
                    dic[student.SubjectName].Attendence = student.Attendance;
                 
                }
            }
            //iterating dic and adding values in resList 
            foreach (var data in dic.Values)
            {
                resList.Add(data);
            }
            //list is returing because we are returning list of objects
            return resList;
        }
        //*********************************************************************************************************
        public MinimumAttendence getMinAttendenceStudents(List<StudentData> list)
        {
            /*
            * @methodName- getMinAttendanceStudents
            * @objective - To find name of students who has minimum attendance across all subject
            * @para - List<StudentData>
            * @return - MinAttendance
            */

            //dic created which has key as student name and value as object type of MinAttendanceStudent
            Dictionary<string, MinimumAttendence> dic = new Dictionary<string, MinimumAttendence>();
            foreach (StudentData student in list)
            {
                //if dic has studentName then add student's attendence in it
                if (dic.ContainsKey(student.StudentName))
                {
                    dic[student.StudentName].MinAttendance += student.Attendance;
                }
                else
                {
                    //if dic does not contains student's name then create object of MinimumAttendence and assign values in it
                    dic.Add(student.StudentName, new MinimumAttendence());
                    dic[student.StudentName].StudentName=student.StudentName;
                    dic[student.StudentName].MinAttendance = student.Attendance;
                }               
            }
            MinimumAttendence minimumAttendence = new MinimumAttendence();
            //object of MinimumAttendence is created and highest possible value of int is added
            minimumAttendence.MinAttendance = int.MaxValue;
            foreach(MinimumAttendence str in dic.Values)
            {
                //if existing attendence of dic is smaller than MinAttendance then assign it in object of minAttendanceStudent
                if (str.MinAttendance< minimumAttendence.MinAttendance)
                {
                    minimumAttendence.StudentName = str.StudentName;
                    minimumAttendence.MinAttendance = str.MinAttendance;
                }
            }        
            return minimumAttendence;
        }

        //****************************************************************************************************************************************************
        public List<OverallAttendenceSubWise> getOverallAttendenceSubWise(List<StudentData> list)
        {
            /*
           * @methodName- getOverallAttendenceSubWise
           * @objective -To list students name in order of their overall attendance across all subjects
           * @para - List<StudentData>
           * @return - List<OverallAttendenceSubWise
           */

            //dic created which has key as student name and value as object type of MinAttendanceStudent
            Dictionary<string,OverallAttendenceSubWise > dic = new Dictionary<string,OverallAttendenceSubWise >();
            //resulList is created for storing result
            List<OverallAttendenceSubWise> resultList = new List<OverallAttendenceSubWise> ();
            foreach(StudentData student in list)
            {
                //if dic has existing studentName then add attendence of it with student's attendence from list  
                if (dic.ContainsKey(student.StudentName))
                {
                     dic[student.StudentName].StudentName  = student.StudentName;
                     dic[student.StudentName].TotalAttendence += student.Attendance;          
                }
                else
                {
                    //if dic does not contains name then create object of OverallAttendenceSubWise and add values in it
                    dic.Add(student.StudentName, new OverallAttendenceSubWise());
                    dic[student.StudentName].StudentName = student.StudentName;
                    dic[student.StudentName].TotalAttendence = student.Attendance;
                }
            }
            //iterating dic and add its values in resultlist
            foreach(OverallAttendenceSubWise key in dic.Values)
            {
                resultList.Add(key);
            }
            //sorting resultList 
            resultList.Sort((pair1, pair2) => pair2.TotalAttendence.CompareTo(pair1.TotalAttendence));
            return resultList;
        }

    }
}
