using System;
using System.Collections.Generic;

namespace Version2
{
    class Subject2
    {
        string nameSubject;
        string fullNamelecturer;
        int numberLessons;

        firstSemester2 oneSemester;
        secondSemester2 otherSemester;

        //конструктори
        public Subject2(string nameSubject, string fullNamelecturer, int numberLessons)
        {
            this.nameSubject = nameSubject;
            this.fullNamelecturer = fullNamelecturer;
            this.numberLessons = numberLessons;
            oneSemester = new firstSemester2(numberLessons);
            otherSemester = new secondSemester2(numberLessons);
        }
        public Subject2()
        {
            Console.WriteLine("Предмет без інфомації був створений");
        }
        public Subject2(Subject2 previous)
        {
            this.nameSubject = previous.nameSubject;
            this.fullNamelecturer = previous.fullNamelecturer;
            oneSemester = new firstSemester2(numberLessons);
            otherSemester = new secondSemester2(numberLessons);
        }

        //властивості
        public string NameSubject
        {
            get { return nameSubject; }
            set { nameSubject = value; }
        }
        public string FullNamelecturer
        {
            get { return fullNamelecturer; }
            set { fullNamelecturer = value; }
        }

        public void printSubject()
        {

        }

        public void chooseSemestr()
        {

        }
    }

    class firstSemester2
    {
        int[] september;
        int[] october;
        int[] november;
        int[] december;        
        
        public firstSemester2(int numberLessons)
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

    class secondSemester2
    {
        int[] january;
        int[] february;
        int[] march;
        int[] april;
        int[] may;        

        public secondSemester2(int numberLessons)
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
