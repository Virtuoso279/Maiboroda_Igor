using System;
using System.IO; //библиотека для работы с файлами

namespace Lab3
{   
    class Faculty
    {
        private string nameFaculty;        
        private int numberDepartments;
        private int numberSpecialtiesFaculty;
        private int numberStudentsFaculty;        
        
        public Faculty() //конструктор без параметрів
        {
            Console.WriteLine("Faculty has been created!");
        }

        //конструктор з параметрами
        public Faculty(string nameFaculty, int numberDepartments, int numberSpecialtiesFaculty, int numberStudentsFaculty)
        {
            Console.WriteLine("Faculty has been created!");
            this.nameFaculty = nameFaculty;
            this.numberDepartments = numberDepartments;
            this.numberSpecialtiesFaculty = numberSpecialtiesFaculty;
            this.numberStudentsFaculty = numberStudentsFaculty;
        }                

        //метод виводу значень полів екземпляру
        public void PrintValuesF()
        {
            Console.WriteLine($"Faculty: {nameFaculty}\nNumber of departments on faculty: {numberDepartments}\nNumber of specialties on faculty: {numberSpecialtiesFaculty}\nNumber of students on faculty: {numberStudentsFaculty}");
        }

        //властивості для зміни значень полів екземпляру за допомгою аксесорів
        public int NumberSpecialtiesFaculty
        {
            get { return numberSpecialtiesFaculty; }
            set
            {                
                if (value > 0) numberSpecialtiesFaculty = value;          
                else numberSpecialtiesFaculty = 1;                
            }
        }
        public int NumberStudentsFaculty
        {
            get { return numberStudentsFaculty; }
            set
            {
                if (value > 0) numberStudentsFaculty = value;
                else numberStudentsFaculty = 1;
            }
        }

        //відкритий метод для запонення полів
        public void CreateFaculty(string nameFaculty, int numberDepartments, int numberSpecialtiesFaculty, int numberStudentsFaculty)
        {
            this.nameFaculty = nameFaculty;
            this.numberDepartments = numberDepartments;
            this.numberSpecialtiesFaculty = numberSpecialtiesFaculty;
            this.numberStudentsFaculty = numberStudentsFaculty;
        }

        //функція для запису тексту до файлу
        public void workingWithFile(StreamWriter myFile)
        {          
            myFile.WriteLine($"Faculty: {nameFaculty}; number of departments on faculty: {numberDepartments}; number of specialties on faculty: {numberSpecialtiesFaculty}; number of students on faculty: {numberStudentsFaculty}");            
        }

        //функція зміни кількості спеціальностей...
        public void changeSpecialties(int value)
        {
            numberSpecialtiesFaculty += value;
            numberDepartments += value;
            numberStudentsFaculty += value * 200;
        }

        public class StartupIncubator 
        {
            public int numberProjects;
            public int numberStudentIncubator;
            public int investment;  
            
            public void findBestProject(Random point)
            {
                int sumPointBestProject = 0, numberBest;
                int[,] arrayPoints = new int[5, 10];
                int[] arrayProjects = new int[10];
                int[] arrayProjectsCopy = new int[10];
                Console.WriteLine("There are 5 experts and 10 projects. Table of points:");
                for (int i = 0; i < 5; i++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        arrayPoints[i, k] = point.Next(1, 10);
                        Console.Write(arrayPoints[i, k] + "\t");
                    }
                    Console.WriteLine();
                }
                //рахуємо суму балів кожного проекту та середнє арифметичне
                Console.WriteLine("Average scores of projects:");
                for (int i = 0; i < 10; i++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        sumPointBestProject += arrayPoints[k, i];
                        if (k == 4) break;
                    }
                    arrayProjects[i] = sumPointBestProject / 5;
                    Console.Write(arrayProjects[i] + " ");
                    sumPointBestProject = 0;
                }
                Console.WriteLine();
                Array.Copy(arrayProjects, arrayProjectsCopy, 10);
                Array.Sort(arrayProjectsCopy);
                numberBest = Array.BinarySearch(arrayProjects, arrayProjectsCopy[0]) + 1;
                sumPointBestProject = arrayProjectsCopy[0];
                Console.WriteLine($"The best project is {numberBest}-th has {sumPointBestProject} points");
            }

            public void bestStudent(Random point)
            {
                Console.WriteLine("Let's find best student");
                Console.WriteLine("Part of working in projects all students:");
                double[] arrayPart = new double[numberStudentIncubator];
                for (int i = 0; i < numberStudentIncubator; i++)
                {
                    arrayPart[i] = Convert.ToDouble(point.Next(1, 100)) / 100;
                    Console.Write(arrayPart[i] + " ");
                    arrayPart[i] *= investment;
                }
                Console.WriteLine();
                Console.WriteLine("Money for every part of students: ");
                foreach (var item in arrayPart)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                Array.Sort(arrayPart);
                Console.WriteLine($"The best student has {arrayPart[numberStudentIncubator - 1]}");
            }
        }

    }
}
