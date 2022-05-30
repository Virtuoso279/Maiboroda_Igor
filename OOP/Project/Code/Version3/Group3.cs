using System;
using System.Collections.Generic;

namespace Version3
{
    class Group3
    {
        string faculty;
        string specialty;
        int courseNumber;
        string nameGroup;
        int numberStudents;

        Student3[] group;

        //конструктори
        public Group3(string faculty, string specialty, int courseNumber, string nameGroup, int numberStudents)
        {
            this.faculty = faculty;
            this.specialty = specialty;
            this.courseNumber = courseNumber;
            this.nameGroup = nameGroup;
            this.numberStudents = numberStudents;
            group = new Student3[numberStudents];
            Console.WriteLine($"Група {nameGroup} була створена");
        }
        public Student3 this[int index]
        {
            get { return group[index]; }
            set { group[index] = value; }
        }
        public Group3()
        {
            Console.WriteLine("Пуста група була створена");
        }
        public Group3(Group3 previous)
        {
            this.faculty = previous.faculty;
            this.specialty = previous.specialty;
            this.courseNumber = previous.courseNumber;
            this.nameGroup = previous.nameGroup;
            this.numberStudents = previous.numberStudents;
            group = previous.group;
            Console.WriteLine("Копія групи була створена");
        }

        //властивості
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }
        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }
        public string NameGroup
        {
            get { return nameGroup; }
            set { nameGroup = value; }
        }
        public int CourseNumber
        {
            get { return courseNumber; }
            set
            {
                if (value == 1 || value == 2 || value == 3 || value == 4)
                    courseNumber = value;
                else
                    Console.WriteLine("Число має бути від 1 до 4!");
            }
        }
        public int NumberStudents
        {
            get { return numberStudents; }
            set
            {
                if (value > 0)
                    numberStudents = value;
                else
                    Console.WriteLine("Число має бути більше 0!");
            }
        }

        public void printGroupInform()
        {
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Інформація про групу");
            Console.WriteLine("Факультет: " + faculty);
            Console.WriteLine("Спеціальність: " + specialty);
            Console.WriteLine("Курс: " + courseNumber);
            Console.WriteLine("Назва групи: " + nameGroup);
            Console.WriteLine("Кількість студентів групи: " + numberStudents);
            Console.WriteLine();
        }

        public void printGroupPoints(int numberLabWorks, int numberHomeWorks)
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Журнал оцінок");
            Console.Write("\t\t");
            for (int i = 0; i < numberLabWorks; i++)
            {
                Console.Write("ЛР" + (i+1) + "\t");
            }
            for (int i = 0; i < numberHomeWorks; i++)
            {
                Console.Write("ДЗ" + (i+1) + "\t");
            }
            Console.WriteLine("Ак.\tПр.\tДБ\tСум");
            for (int i = 0; i < numberStudents; i++)
            {
                Console.Write($"{(i + 1)}. " + group[i].fullName + "\t");
                group[i].allpoints.printMarksStudent();
            }
        }

        public void printGroupAttending(int semestr, int numberLessons, Subject3 OOP)
        {
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Облік присутності студентів");
            if (semestr == 1)
            {
                OOP.oneSemester.printAllDates(numberLessons);
                for (int i = 0; i < numberStudents; i++)
                {
                    Console.Write($"{(i + 1)}. " + group[i].fullName + "\t");
                    group[i].allAttendance.printAttendingStudent(semestr);
                }
            }
            else
            {
                OOP.otherSemester.printAllDates(numberLessons);
                for (int i = 0; i < numberStudents; i++)
                {
                    Console.Write($"{(i + 1)}. " + group[i].fullName + "\t");
                    group[i].allAttendance.printAttendingStudent(semestr);
                }
            }
            Console.WriteLine();
        }

        public void changeAttendance(int numberLessons)
        {
            int studentNumber, lessonNumber, value;
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Заміна відвідувань");
            Console.Write("Оберіть студента за номером: ");
            while (!int.TryParse(Console.ReadLine(), out studentNumber) || studentNumber < 1 || studentNumber > 25)
            {
                Console.Write("Ведіть число від 1 до 25: ");
            }
            Console.Write("Номер заняття: ");
            while (!int.TryParse(Console.ReadLine(), out lessonNumber) || lessonNumber < 1 || lessonNumber > numberLessons)
            {
                Console.Write($"Ведіть число від 1 до {numberLessons}: ");
            }
            Console.Write("Присутність (0 або 1): ");
            while (!int.TryParse(Console.ReadLine(), out value) || (value != 1 && value != 0))
            {
                Console.Write("Ведіть 0 або 1: ");
            }
            group[studentNumber - 1].allAttendance.AttendingLessons[lessonNumber - 1] = value;
            group[studentNumber - 1].allAttendance.calculateAttending();
        }

        public void changePoints(int numberLabWorks, int numberHomeWorks)
        {
            int studentNumber, value, workNumber, workArrayNumber;
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Заміна оцінок");
            Console.WriteLine("1 - лабораторна робота, 2 - домашнє завдання, 3 - активність, 4 - проект, 5 - додаткові бали");
            Console.Write("Оберіть студента за номером: ");
            while (!int.TryParse(Console.ReadLine(), out studentNumber) || studentNumber < 1 || studentNumber > 25)
            {
                Console.Write("Ведіть число від 1 до 25: ");
            }
            Console.Write("Оберіть вид робіт: ");
            while (!int.TryParse(Console.ReadLine(), out workNumber) || workNumber < 1 || workNumber > 5)
            {
                Console.Write("Ведіть число від 1 до 5: ");
            }
            Console.Write("Внесість номер ЛР або ДЗ (за необхідності): ");
            while (!int.TryParse(Console.ReadLine(), out workArrayNumber) || workArrayNumber < 1 || (workArrayNumber > numberLabWorks && workArrayNumber > numberHomeWorks))
            {
                Console.Write("Ведіть інше число: ");
            }
            Console.Write("Внесіть оцінку: ");
            while (!int.TryParse(Console.ReadLine(), out value) || value < 1)
            {
                Console.Write("Ведіть число від 1 до 5: ");
            }

            switch (workNumber)
            {
                case 1: group[studentNumber - 1].allpoints.LabWorks[workArrayNumber - 1] = value; break;
                case 2: group[studentNumber - 1].allpoints.HomeWorks[workArrayNumber - 1] = value; break;
                case 3: group[studentNumber - 1].allpoints.Activity = value; break;
                case 4: group[studentNumber - 1].allpoints.Project = value; break;
                case 5: group[studentNumber - 1].allpoints.ExtraPoints = value; break;
            }
            group[studentNumber - 1].allpoints.calculateSumPoints();
        }

        public void generatingGroup(Random element)
        {
            int maxLabMark, maxHomeWorkMark, maxProjectMark, maxActivity, maxExtraPoints;
            Console.Write("Введіть максимальний бал за лабораторну роботу: ");
            while (!int.TryParse(Console.ReadLine(), out maxLabMark) || maxLabMark < 0)
            {
                Console.Write("Ведіть число більше 0: ");
            }
            Console.Write("Введіть максимальний бал за домашню роботу: ");
            while (!int.TryParse(Console.ReadLine(), out maxHomeWorkMark) || maxHomeWorkMark < 0)
            {
                Console.Write("Ведіть число більше 0: ");
            }
            Console.Write("Введіть максимальний бал за проект: ");
            while (!int.TryParse(Console.ReadLine(), out maxProjectMark) || maxProjectMark < 0)
            {
                Console.Write("Ведіть число більше 0: ");
            }
            Console.Write("Введіть максимальний бал за активність на лекціях: ");
            while (!int.TryParse(Console.ReadLine(), out maxActivity) || maxActivity < 0)
            {
                Console.Write("Ведіть число більше 0: ");
            }
            Console.Write("Введіть максимальний бал за додаткову роботу: ");
            while (!int.TryParse(Console.ReadLine(), out maxExtraPoints) || maxExtraPoints < 0)
            {
                Console.Write("Ведіть число більше 0: ");
            }

            for (int i = 0; i < 25; i++)
            {
                group[i].allAttendance.randomAttending(element);
                group[i].allpoints.randomMarks(element, maxLabMark, maxHomeWorkMark, maxProjectMark, maxActivity, maxExtraPoints);
            }
        }
    }
}
