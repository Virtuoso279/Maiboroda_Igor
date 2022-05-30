using System;
using System.Collections.Generic;

namespace Version3
{
    class Student3
    {
        public string fullName;
        int totalPoints;
        int examPoints;

        public Points3 allpoints;
        public Attendance3 allAttendance;

        //конструктори
        public Student3(Points3 objectPoints, Attendance3 objectAttendance, string fullName)
        {
            allpoints = objectPoints;
            allAttendance = objectAttendance;
            this.fullName = fullName;
        }
        public Student3()
        {
            Console.WriteLine("Окремий студент без інформації був створений");
        }
        public Student3(string fullName, int totalPoints, int examPoints)
        {
            this.fullName = fullName;
            this.totalPoints = totalPoints;
            this.examPoints = examPoints;
            Console.WriteLine("Окремий студент був створений");
        }
        public Student3(Student3 previous)
        {
            this.fullName = previous.fullName;
            this.totalPoints = previous.totalPoints;
            this.examPoints = previous.examPoints;
            Console.WriteLine("Копія окремого студента створена");
        }

        //властивості
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public int TotalPoints
        {
            get { return totalPoints; }
            set
            {
                if (value >= 0)
                    totalPoints = value;
                else
                    Console.WriteLine("Число має бути більше 0!");
            }
        }
        public int ExamPoints
        {
            get { return examPoints; }
            set
            {
                if (value > 0)
                    examPoints = value;
                else
                    Console.WriteLine("Число має бути більше 0!");
            }
        }

        public void informBeforeExam()
        {

        }

        public void informAfterExam()
        {

        }                
    }
}
