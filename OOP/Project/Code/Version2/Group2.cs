using System;
using System.Collections.Generic;

namespace Version2
{  

    class Group2
    {
        string faculty;
        string specialty;
        int courseNumber;
        string nameGroup;
        int numberStudents;

        Student2[] group;

        //конструктори
        public Group2(string faculty, string specialty, int courseNumber, string nameGroup, int numberStudents)
        {
            this.faculty = faculty;
            this.specialty = specialty;
            this.courseNumber = courseNumber;
            this.nameGroup = nameGroup;
            this.numberStudents = numberStudents;
            group = new Student2[numberStudents];
            Console.WriteLine($"Група {nameGroup} була створена");
        }
        public Student2 this[int index]
        {
            get { return group[index]; }
            set { group[index] = value; }
        }
        public Group2()
        {
            Console.WriteLine("Пуста група була створена");
        }
        public Group2(Group2 previous)
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

        public void printGroupPoints()
        {

        }

        public void printGroupAttending()
        {

        }
    }
}
