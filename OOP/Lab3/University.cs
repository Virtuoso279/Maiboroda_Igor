using System;
using System.IO; //библиотека для работы с файлами

namespace Lab3
{
    public partial class University
    {
        private string nameUniversity;
        private string address;
        private int numberFaculties;
        private int numberSpecialties;
        private int numberStudents;
        private int rating;    

        public University() //конструктор без параметрів
        {
            Console.WriteLine("University has been created!");
        }       

        //конструктор з параметрами
        public University(string nameUniversity, string address, int numberFaculties, int numberSpecialties, int numberStudents, int rating)
        {
            Console.WriteLine("University has been created!");
            this.nameUniversity = nameUniversity;
            this.address = address;
            this.numberFaculties = numberFaculties;
            this.numberSpecialties = numberSpecialties;
            this.numberStudents = numberStudents;
            this.rating = rating;
        }

        //метод виводу значень полів екземпляру
        public void PrintValuesU()
        {
            Console.WriteLine($"University: {nameUniversity}\nAddress: {address}\nNumber of faculties: {numberFaculties}\nNumber of specialties: {numberSpecialties}\nNumber of students: {numberStudents}\nRating of university: {rating}");
        }

        //властивості для зміни значень полів екземпляру за допомгою аксесорів
        public int NumberSpecialties
        {
            get { return numberSpecialties; }
            set
            {
                if (value > 0) numberSpecialties = value;
                else numberSpecialties = 1;
            }
        }
        public int NumberStudents
        {
            get { return numberStudents; }
            set
            {
                if (value > 0) numberStudents = value;
                else numberStudents = 1;
            }
        }
        public int Rating
        {
            get { return rating; }
            set
            {
                if (value > 0) rating = value;
                else rating = 1;
            }
        }

        //відкритий метод для запонення полів
        public void CreateUniversity(string nameUniversity, string address, int numberFaculties, int numberSpecialties, int numberStudents, int rating)
        {
            this.nameUniversity = nameUniversity;
            this.address = address;
            this.numberFaculties = numberFaculties;
            this.numberSpecialties = numberSpecialties;
            this.numberStudents = numberStudents;
            this.rating = rating;
        }

        //розрахунок рейтингу університету        
        public int sumPoints;        
        public void setRating(Random point)
        {   
           sumPoints = point.Next(0, 200) + point.Next(0, 200) + point.Next(0, 200);
        }     
    }

    public partial class University
    {
        //розрахунок річного фінансування університету        
        public int sumFunding = 0;
        public void calculateMoney(Random point)
        {
            for (int i = 0; i < numberStudents; i++)
            {
                sumFunding += point.Next(2000, 6000);
            }
        }
    }
}

