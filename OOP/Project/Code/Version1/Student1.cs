using System;
using System.Collections.Generic;

namespace Version1
{
    class Student1
    {
        string fullName;
        int currentPoints;
        int examPoints;

        public Points1 allpoints;
        public Attendance1 allAttendance;

        //конструктори
        public Student1(Points1 objectPoints, Attendance1 objectAttendance, string fullName)
        {
            allpoints = objectPoints;
            allAttendance = objectAttendance;
            this.fullName = fullName;
        }

        public void informBeforeExam()
        {

        }

        public void informAfterExam()
        {

        }

        public void forecastResultExam()
        {

        }

    }
}
