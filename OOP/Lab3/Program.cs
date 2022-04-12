using System;
using System.IO; //библиотека для работы с файлами

namespace Lab3
{
    class Program
    {  
        static void Main()
        {
            Console.WriteLine("Lab 3. Variant 5. IPZ-11 Maiboroda Igor");
            Console.WriteLine("============================================");
            Console.WriteLine("Task 1, 2");
            //об'єкти класів, ініціалізація полів через відкритий метод
            University KNU = new University();
            KNU.CreateUniversity("KNU", "Kiev", 14, 281, 32000, 1);
            Faculty FIT = new Faculty();
            FIT.CreateFaculty("FIT", 7, 9, 7500);

            Console.WriteLine("============================================");
            Console.WriteLine("Task 3");
            //об'єкти класів, ініціалізація полів через конструктор з параметрами
            University LNU = new University("LNU", "Lviv", 19, 182, 12000, 5);
            Faculty Financial = new Faculty("Financial", 12, 7, 6400);                        
            KNU.PrintValuesU();            
            LNU.PrintValuesU();            
            FIT.PrintValuesF();            
            Financial.PrintValuesF();

            Console.WriteLine("============================================");
            Console.WriteLine("Task 4");
            KNU.NumberSpecialties = -15;
            LNU.Rating = 2;
            KNU.NumberStudents = 24600;
            FIT.NumberSpecialtiesFaculty = 253;
            Financial.NumberStudentsFaculty = 0;            
            KNU.PrintValuesU();            
            LNU.PrintValuesU();            
            FIT.PrintValuesF();            
            Financial.PrintValuesF();

            Console.WriteLine("============================================");
            Console.WriteLine("Task 5");
            string nameUniversity, address, nameFaculty;
            int numberFaculties, numberSpecialties, numberStudents, rating, numberDepartments, numberSpecialtiesFaculty, numberStudentsFaculty;
            
            //створюємо об'єкт з введеними значеннями полів класу (університет)
            Console.WriteLine("Let's create university");
            Console.Write("Enter name of university: ");
            nameUniversity = Console.ReadLine();
            Console.Write("Enter address of university: ");
            address = Console.ReadLine();
            Console.Write("Enter number of faculties of university: ");
            while (!int.TryParse(Console.ReadLine(), out numberFaculties) || numberFaculties < 1)
            {
                Console.Write("Input other value: ");
            }
            Console.Write("Enter number of specialties of university: ");
            while (!int.TryParse(Console.ReadLine(), out numberSpecialties) || numberSpecialties < 1)
            {
                Console.Write("Input other value: ");
            }
            Console.Write("Enter number of students of university: ");
            while (!int.TryParse(Console.ReadLine(), out numberStudents) || numberStudents < 1)
            {
                Console.Write("Input other value: ");
            }
            Console.Write("Enter rating of university: ");
            while (!int.TryParse(Console.ReadLine(), out rating) || rating < 1)
            {
                Console.Write("Input other value: ");
            }

            //створюємо об'єкт з введеними значеннями полів класу (факультет)
            Console.WriteLine("Let's create faculty");
            Console.Write("Enter name of faculty: ");
            nameFaculty = Console.ReadLine();
            Console.Write("Enter number of departments of faculty: ");
            while (!int.TryParse(Console.ReadLine(), out numberDepartments) || numberDepartments < 1)
            {
                Console.Write("Input other value: ");
            }
            Console.Write("Enter number of specialties of faculty: ");
            while (!int.TryParse(Console.ReadLine(), out numberSpecialtiesFaculty) || numberSpecialtiesFaculty < 1)
            {
                Console.Write("Input other value: ");
            }
            Console.Write("Enter number of students of faculty: ");
            while (!int.TryParse(Console.ReadLine(), out numberStudentsFaculty) || numberStudentsFaculty < 1)
            {
                Console.Write("Input other value: ");
            }

            //створимо об'єкти класів і виводимо значення полів на консоль
            University MyUniver = new University();
            MyUniver.CreateUniversity(nameUniversity, address, numberFaculties, numberSpecialties, numberStudents, rating);
            Faculty MyFacult = new Faculty();
            MyFacult.CreateFaculty(nameFaculty, numberDepartments, numberSpecialtiesFaculty, numberStudentsFaculty);
            MyUniver.PrintValuesU();
            MyFacult.PrintValuesF();

            //запис значень в файл
            StreamWriter myFile = new StreamWriter("info.txt");
            myFile.WriteLine("Task 5");
            myFile.WriteLine($"University: {nameUniversity}. Address: {address}. Number of faculties: {numberFaculties}. Number of specialties: {numberSpecialties}. Number of students: {numberStudents}. Rating of university: {rating}");
            myFile.WriteLine($"Faculty: {nameFaculty}. Number of departments on faculty: {numberDepartments}. Number of specialties on faculty: {numberSpecialtiesFaculty}. Number of students on faculty: {numberStudentsFaculty}");
            
            Console.WriteLine("============================================");
            Console.WriteLine("Task 6");

            //створимо ще 2 університета і порахуємо рейтинг yсіх 5 університетів
            University KPI = new University();
            University SumDU = new University();
            Random point = new Random();
            KNU.setRating(point); KPI.setRating(point); LNU.setRating(point);
            SumDU.setRating(point); MyUniver.setRating(point);
            //створюємо масив із сум балів рейтингу всіх університетів
            int []array = { KNU.sumPoints, KPI.sumPoints, LNU.sumPoints, SumDU.sumPoints, MyUniver.sumPoints };
            Array.Sort(array);            
            int place; //змінюємо місця в рейтингу серед університетів
            place = Array.BinarySearch(array, KNU.sumPoints) - 5;
            KNU.Rating = Math.Abs(place);
            Console.WriteLine($"Rating of KNU: {KNU.Rating}; sum of points = {KNU.sumPoints}");
            place = Array.BinarySearch(array, LNU.sumPoints) - 5;
            LNU.Rating = Math.Abs(place);            
            Console.WriteLine($"Rating of LNU: {LNU.Rating}; sum of points = {LNU.sumPoints}");
            place = Array.BinarySearch(array, KPI.sumPoints) - 5;
            KPI.Rating = Math.Abs(place);            
            Console.WriteLine($"Rating of KPI: {KPI.Rating}; sum of points = {KPI.sumPoints}");
            place = Array.BinarySearch(array, SumDU.sumPoints) - 5;
            SumDU.Rating = Math.Abs(place);            
            Console.WriteLine($"Rating of SumDU: {SumDU.Rating}; sum of points = {SumDU.sumPoints}");
            place = Array.BinarySearch(array, MyUniver.sumPoints) - 5;
            MyUniver.Rating = Math.Abs(place);            
            Console.WriteLine($"Rating of MyUniver: {MyUniver.Rating}; sum of points = {MyUniver.sumPoints}");

            //розрахунок розміру річного фінансування університету
            int value = 0;            
            Console.WriteLine("Annual funding of university");
            Console.Write("Input number of students of KPI: ");
            while (!int.TryParse(Console.ReadLine(), out value) || value < 1)
            {
                Console.Write("Input number: ");
            }
            KPI.NumberStudents = value;
            Console.Write("Input number of students of SumDU: ");
            while (!int.TryParse(Console.ReadLine(), out value) || value < 1)
            {
                Console.Write("Input number: ");
            }
            SumDU.NumberStudents = value;
            //виклик функції для розрахунку
            KNU.calculateMoney(point); KPI.calculateMoney(point); LNU.calculateMoney(point);
            SumDU.calculateMoney(point); MyUniver.calculateMoney(point);
            Console.WriteLine($"Annual funding of KNU:\t\t${KNU.sumFunding}");
            Console.WriteLine($"Annual funding of KPI:\t\t${KPI.sumFunding}");
            Console.WriteLine($"Annual funding of LNU:\t\t${LNU.sumFunding}");
            Console.WriteLine($"Annual funding of SumDU:\t${SumDU.sumFunding}");
            Console.WriteLine($"Annual funding of MyUniver:\t${MyUniver.sumFunding}");

            //робота с файлом через метод в класі Faculty
            //створюємо об'єкт з введеними значеннями полів класу (факультет КПІ)
            Console.WriteLine("Let's create faculty of KPI");
            Console.Write("Enter name of faculty: ");
            nameFaculty = Console.ReadLine();
            Console.Write("Enter number of departments of faculty: ");
            while (!int.TryParse(Console.ReadLine(), out numberDepartments) || numberDepartments < 1)
            {
                Console.Write("Input other value: ");
            }
            Console.Write("Enter number of specialties of faculty: ");
            while (!int.TryParse(Console.ReadLine(), out numberSpecialtiesFaculty) || numberSpecialtiesFaculty < 1)
            {
                Console.Write("Input other value: ");
            }
            Console.Write("Enter number of students of faculty: ");
            while (!int.TryParse(Console.ReadLine(), out numberStudentsFaculty) || numberStudentsFaculty < 1)
            {
                Console.Write("Input other value: ");
            }
            Faculty facultKPI = new Faculty();
            facultKPI.CreateFaculty(nameFaculty, numberDepartments, numberSpecialtiesFaculty, numberStudentsFaculty);
            //створюємо об'єкт з введеними значеннями полів класу (факультет СумДУ)
            Console.WriteLine("Let's create faculty of SumDU");
            Console.Write("Enter name of faculty: ");
            nameFaculty = Console.ReadLine();
            Console.Write("Enter number of departments of faculty: ");
            while (!int.TryParse(Console.ReadLine(), out numberDepartments) || numberDepartments < 1)
            {
                Console.Write("Input other value: ");
            }
            Console.Write("Enter number of specialties of faculty: ");
            while (!int.TryParse(Console.ReadLine(), out numberSpecialtiesFaculty) || numberSpecialtiesFaculty < 1)
            {
                Console.Write("Input other value: ");
            }
            Console.Write("Enter number of students of faculty: ");
            while (!int.TryParse(Console.ReadLine(), out numberStudentsFaculty) || numberStudentsFaculty < 1)
            {
                Console.Write("Input other value: ");
            }
            Faculty facultSumDU = new Faculty();
            facultSumDU.CreateFaculty(nameFaculty, numberDepartments, numberSpecialtiesFaculty, numberStudentsFaculty);
            myFile.WriteLine("Task 6");
            FIT.workingWithFile(myFile);
            Financial.workingWithFile(myFile);
            MyFacult.workingWithFile(myFile);
            facultKPI.workingWithFile(myFile);
            facultSumDU.workingWithFile(myFile);
            myFile.Close();

            //зміна кількості кафедр та студентів залежно від кількості спеціальностей факультету
            Console.WriteLine("Let's change number of specialties of faculty");
            Console.Write("Input number of specialties to add (FIT): ");
            while (!int.TryParse(Console.ReadLine(), out value) || value < 1)
            {
                Console.Write("Input other number: ");
            }
            FIT.changeSpecialties(value);
            FIT.PrintValuesF();

            Console.WriteLine("============================================");
            Console.WriteLine("Task 7");
            //створимо об'єкт класу startupIncubator
            Faculty.StartupIncubator Incubator = new Faculty.StartupIncubator();
            Incubator.numberProjects = 10;
            Incubator.numberStudentIncubator = 14;
            Incubator.investment = 50000;
            Incubator.findBestProject(point);
            Incubator.bestStudent(point);

            Console.WriteLine("============================================");
            Console.WriteLine("Task 8, 9");

            Console.WriteLine("Task 2 from lab 2");
            Console.Write("Input size of array: ");
            while (!int.TryParse(Console.ReadLine(), out StartupProject.size) || (StartupProject.size <= 0))
            {
                Console.Write("Input number of elements: ");
            }            
            StartupProject.SecondTask(point);

            Console.WriteLine("Task 6 from lab 2");
            Console.Write("Input number of strings of matrix: ");
            while (!int.TryParse(Console.ReadLine(), out StartupProject.str) || (StartupProject.str <= 0))
            {
                Console.Write("Input number of strings: ");
            }
            Console.Write("Input number of columns of matrix: ");
            while (!int.TryParse(Console.ReadLine(), out StartupProject.colum) || (StartupProject.colum <= 0))
            {
                Console.Write("Input number of columns: ");
            }
            StartupProject.SixthTask();

            Console.WriteLine("Task 9 from lab 2");
            Console.Write("Input string with '()' '{}' '[]': ");
            StartupProject.sentence = Console.ReadLine();
            StartupProject.NinthTask();
        }
    }
}
