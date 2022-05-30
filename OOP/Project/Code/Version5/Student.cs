using System;
using System.Collections.Generic;

namespace Project
{
    class Student
    {
        public string fullName;
        int totalPoints;
        int examPoints;

        public Points allpoints;
        public Attendance allAttendance;

        //конструктори
        public Student(Points objectPoints, Attendance objectAttendance, string fullName)
        {
            allpoints = objectPoints;
            allAttendance = objectAttendance;
            this.fullName = fullName;
        }
        public Student()
        {
            Console.WriteLine("Окремий студент без інформації був створений");
        }
        public Student(string fullName, int totalPoints, int examPoints)
        {
            this.fullName = fullName;
            this.totalPoints = totalPoints;
            this.examPoints = examPoints;
            Console.WriteLine("Окремий студент був створений");
        }
        public Student(Student previous)
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

        public void informBeforeExam(Group IPZ11)
        {
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Інформація про студента");
            Console.WriteLine("ПІБ: " + fullName);
            Console.WriteLine("Факультет: " + IPZ11.Faculty);
            Console.WriteLine("Спеціальність: " + IPZ11.Specialty);
            Console.WriteLine("Курс: " + IPZ11.CourseNumber);
            Console.WriteLine("Назва групи: " + IPZ11.NameGroup);
            Console.WriteLine("Поточні бали (без іспиту): " + allpoints.SumPoints);
            Console.WriteLine($"Кількість відвіданих занять: {allAttendance.SumAttendance} із {allAttendance.NumberLessons}");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Прогноз результатів іспиту");
            if (allpoints.SumPoints < 36)
            {
                Console.WriteLine("Студент недопущений до іспиту!");
            }
            else
            {
                int rate = ((allpoints.SumPoints * 100) / 60);
                if (allAttendance.SumAttendance < allAttendance.NumberLessons / 2)
                    rate -= 5;
                else
                    rate += 5;
                Console.WriteLine($"Ймовірність скласти іспит у студента = {rate} %");
                Console.WriteLine($"Студент може набрати на іспиті = {(rate * 40 / 100)} балів");
            }
        }

        public void informAfterExam(Group IPZ11)
        {
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Інформація про студента");
            Console.WriteLine("ПІБ: " + fullName);
            Console.WriteLine("Факультет: " + IPZ11.Faculty);
            Console.WriteLine("Спеціальність: " + IPZ11.Specialty);
            Console.WriteLine("Курс: " + IPZ11.CourseNumber);
            Console.WriteLine("Назва групи: " + IPZ11.NameGroup);
            Console.WriteLine("Поточні бали (без іспиту): " + allpoints.SumPoints);
            Console.WriteLine($"Кількість відвіданих занять: {allAttendance.SumAttendance} із {allAttendance.NumberLessons}");
            if (allpoints.SumPoints < 36)
            {
                Console.WriteLine("Студент недопущений до іспиту!");
            }
            else
            {
                if (examPoints < 24)
                {
                    Console.WriteLine("Студент не склав іспит! Необхідно перескладати!");
                }
                else
                {
                    Console.WriteLine("Бали за іспит: " + examPoints);
                    totalPoints = allpoints.SumPoints + examPoints;
                    Console.WriteLine("Загальні бали (з іспитом): " + totalPoints);
                }
            }
        }

        //бінарні та унарні оператори
        public static bool operator >(Student obj1, Student obj2)
        {
            if (obj1.allpoints.SumPoints > obj2.allpoints.SumPoints)
                return true;
            else
                return false;
        }

        public static bool operator <(Student obj1, Student obj2)
        {
            if (obj1.allpoints.SumPoints < obj2.allpoints.SumPoints)
                return true;
            else
                return false;
        }

        public static Student operator ++(Student obj1)
        {
            obj1.allpoints.SumPoints += 5;
            return obj1;
        }

        public static Student operator --(Student obj1)
        {
            obj1.allpoints.SumPoints -= 5;
            return obj1;
        }
    }
}
