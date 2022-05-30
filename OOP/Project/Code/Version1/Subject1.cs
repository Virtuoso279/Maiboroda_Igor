using System;
using System.Collections.Generic;

namespace Version1
{
    class Subject1
    {
        string nameSubject;
        string fullNamelecturer;
        int numberLessons;

        firstSemester1 oneSemester;
        secondSemester1 otherSemester;

        //конструктори
        public Subject1(string nameSubject, string fullNamelecturer, int numberLessons)
        {
            this.nameSubject = nameSubject;
            this.fullNamelecturer = fullNamelecturer;
            this.numberLessons = numberLessons;
            oneSemester = new firstSemester1(numberLessons);
            otherSemester = new secondSemester1(numberLessons);
        }

        public void printSubject()
        {

        }

        public void chooseSemestr()
        {

        }

    }

    class firstSemester1
    {
        int[] september;
        int[] october;
        int[] november;
        int[] december;

        public firstSemester1(int numberLessons)
        {
            september = new int[numberLessons / 4];
            october = new int[numberLessons / 4];
            november = new int[numberLessons / 4];
            december = new int[(numberLessons - 3 * (numberLessons / 4))];
        }

        public void generateRandomDates()
        {

        }

        public void changeDates()
        {

        }

        public void printDates()
        {

        }
    }

    class secondSemester1
    {
        int[] january;
        int[] february;
        int[] march;
        int[] april;
        int[] may;

        public secondSemester1(int numberLessons)
        {
            january = new int[numberLessons / 5];
            february = new int[numberLessons / 5];
            march = new int[numberLessons / 5];
            april = new int[numberLessons / 5];
            may = new int[(numberLessons - 4 * (numberLessons / 5))];
        }


        public void generateRandomDates()
        {

        }

        public void changeDates()
        {

        }

        public void printDates()
        {

        }
    }

}
