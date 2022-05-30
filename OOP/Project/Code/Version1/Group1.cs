using System;
using System.Collections.Generic;

namespace Version1
{
    class Group1
    {
        string faculty;
        string specialty;
        int courseNumber;
        string nameGroup;
        int numberStudents;

        Student1[] group;

        //конструктори
        public Group1(string faculty, string specialty, int courseNumber, string nameGroup, int numberStudents)
        {
            this.faculty = faculty;
            this.specialty = specialty;
            this.courseNumber = courseNumber;
            this.nameGroup = nameGroup;
            this.numberStudents = numberStudents;
            group = new Student1[numberStudents];
            Console.WriteLine($"Група {nameGroup} була створена");
        }
        public Student1 this[int index]
        {
            get { return group[index]; }
            set { group[index] = value; }
        }
        
                

        public void printGroupPoints()
        {

        }

        public void printGroupAttending()
        {

        }


    }
}
