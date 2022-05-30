using System;
using System.Collections.Generic;

namespace Version2
{
    class Student2
    {
        string fullName;
        int currentPoints;
        int examPoints;

        public Points2 allpoints;
        public Attendance2 allAttendance;

        //конструктори
        public Student2(Points2 objectPoints, Attendance2 objectAttendance, string fullName)
        {
            allpoints = objectPoints;
            allAttendance = objectAttendance;
            this.fullName = fullName;
        }        
        public Student2()
        {
            Console.WriteLine("Окремий студент без інформації був створений");
        }
        public Student2(string fullName, int currentPoints, int examPoints)
        {
            this.fullName = fullName;
            this.currentPoints = currentPoints;
            this.examPoints = examPoints;
            Console.WriteLine("Окремий студент був створений");
        }
        public Student2(Student2 previous)
        {
            this.fullName = previous.fullName;
            this.currentPoints = previous.currentPoints;
            this.examPoints = previous.examPoints;
            Console.WriteLine("Копія окремого студента створена");
        }

        //властивості
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public int СurrentPoints
        {
            get { return currentPoints; }
            set
            {
                if (value >= 0)
                    currentPoints = value;
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

        public void forecastResultExam()
        {

        }
    }
}
