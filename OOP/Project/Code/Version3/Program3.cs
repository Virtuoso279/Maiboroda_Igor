using System;
using System.Collections.Generic;

namespace Version3
{
    class Program3
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Майборода Ігор Сергійович ІПЗ-11");
            Console.WriteLine("Проект №46. Версія 3");
            Console.WriteLine("Старт");
            Console.WriteLine(new string('=', 100));
            menu();
            Console.WriteLine();
            Console.WriteLine(new string('=', 100));
            Console.WriteLine("Фініш");
        }

        static void menu()
        {
            //===============================початок================================================
            int numberLessons, semester, choosing;
            Random element = new Random();
            Console.WriteLine(new string(' ', 30) + " Генерація даних");
            Console.Write("Оберіть семестр: ");
            while (!int.TryParse(Console.ReadLine(), out semester) || (semester != 1 && semester != 2))
            {
                Console.Write("Ведіть 1 або 2: ");
            }
            Console.Write("Введіть загальну кількість занять: ");
            while (!int.TryParse(Console.ReadLine(), out numberLessons) || numberLessons <= 0)
            {
                Console.Write("Ведіть число більше 0: ");
            }

            //=============================предмет та дати занять======================================            
            Subject3 OOP = new Subject3("Вступ до ООП", "Бичков О. С.", numberLessons);
            OOP.printSubject();
            if (semester == 1)
            {
                OOP.oneSemester.generateRandomDates(numberLessons, element);
                OOP.oneSemester.printDates(numberLessons);
                Console.Write("\nВас влаштовують створені дати? (Так = 1, Ні = 0): ");
                while (!int.TryParse(Console.ReadLine(), out choosing) || (choosing != 1 && choosing != 0))
                {
                    Console.Write("Ведіть 1 або 0: ");
                }
                if (choosing == 0)
                {
                    OOP.oneSemester.changeDates();
                    OOP.oneSemester.printDates(numberLessons);
                }                    
            }
            else
            {
                OOP.otherSemester.generateRandomDates(numberLessons, element);
                OOP.otherSemester.printDates(numberLessons);
                Console.Write("\nВас влаштовують створені дати? (Так = 1, Ні = 0): ");
                while (!int.TryParse(Console.ReadLine(), out choosing) || (choosing != 1 && choosing != 0))
                {
                    Console.Write("Ведіть 1 або 0: ");
                }
                if (choosing == 0)
                {
                    OOP.otherSemester.changeDates();
                    OOP.otherSemester.printDates(numberLessons);
                }                    
            }
            Console.ReadKey();

            //=============================група студентів, оцінки, присутність======================================
            int numberLabWorks, numberHomeWorks;
            string[] fullnames = { "Акуліч Д.", "Боєчко В.", "Булава Г.", "Гавриленко", "Дармороз", "Діжурко І.", "Зганяйко", "Ковальчук", "Корсун М.", "Кузнецова", "Литвинчук", "Майборода", "Манойлова", "Мартинкова", "Павлюченко", "Радін Н.", "Романова", "Рябиця М.", "Самойленко", "Саніна В.", "Сирота А.", "Травіна А.", "Тухар Р.", "Шкітак Н.", "Шимон Ю."};
            Console.WriteLine();
            Group3 IPZ11 = new Group3("ФІТ", "ІПЗ", 1, "ІПЗ-11", 25);            
            IPZ11.printGroupInform();
            Console.Write("Введіть кількість лабораторних: ");
            while (!int.TryParse(Console.ReadLine(), out numberLabWorks) || numberLabWorks < 0)
            {
                Console.Write("Ведіть число більше 0: ");
            }
            Console.Write("Введіть кількість домашніх завдань: ");
            while (!int.TryParse(Console.ReadLine(), out numberHomeWorks) || numberHomeWorks < 0)
            {
                Console.Write("Ведіть число більше 0: ");
            }

            Points3[] marks = new Points3[25];
            Attendance3[] attending = new Attendance3[25];
            for (int i = 0; i < 25; i++)
            {
                marks[i] = new Points3(numberLabWorks, numberHomeWorks);
                attending[i] = new Attendance3(numberLessons);
                IPZ11[i] = new Student3(marks[i], attending[i], fullnames[i]);
            }

            IPZ11.generatingGroup(element);
            Console.ReadKey();
            IPZ11.printGroupAttending(semester, numberLessons, OOP);
            Console.ReadKey();
            IPZ11.printGroupPoints(numberLabWorks, numberHomeWorks);

            //=============================заміна інформації==========================================            
            Console.WriteLine();
            Console.WriteLine(new string('=', 100));
            Console.WriteLine(new string(' ', 30) + " Заміна даних");            
            while (true)
            {                
                Console.WriteLine("Меню");
                Console.WriteLine("1. Робота з обліком присутності.");
                Console.WriteLine("2. Робота з журналом оцінок.");
                Console.Write("Введіть номер завдання (0 щоб зупинити): ");
                while (!int.TryParse(Console.ReadLine(), out choosing) || (choosing != 1 && choosing != 0 && choosing != 2))
                {
                    Console.Write("Ведіть 1 або 2 (0 щоб зупинити): ");
                }
                if (choosing == 1)
                {
                    IPZ11.changeAttendance(numberLessons);
                }
                else if (choosing == 2)
                {
                    IPZ11.changePoints(numberLabWorks, numberHomeWorks);
                }
                else
                {
                    break;
                }
            }
            Console.ReadKey();
            IPZ11.printGroupAttending(semester, numberLessons, OOP);
            Console.ReadKey();
            IPZ11.printGroupPoints(numberLabWorks, numberHomeWorks);
        }
    }
}
