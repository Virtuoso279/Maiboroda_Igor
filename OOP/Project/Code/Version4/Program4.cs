using System;
using System.Collections.Generic;

namespace Version4
{
    class Program4
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Майборода Ігор Сергійович ІПЗ-11");
            Console.WriteLine("Проект №46. Версія 4");
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
            Subject4 OOP = new Subject4("Вступ до ООП", "Бичков О. С.", numberLessons);
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
            string[] fullnames = { "Акуліч Д.", "Боєчко В.", "Булава Г.", "Гавриленко", "Дармороз", "Діжурко І.", "Зганяйко", "Ковальчук", "Корсун М.", "Кузнецова", "Литвинчук", "Майборода", "Манойлова", "Мартинкова", "Павлюченко", "Радін Н.", "Романова", "Рябиця М.", "Самойленко", "Саніна В.", "Сирота А.", "Травіна А.", "Тухар Р.", "Шкітак Н.", "Шимон Ю." };
            Console.WriteLine();
            Group4 IPZ11 = new Group4("ФІТ", "ІПЗ", 1, "ІПЗ-11", 25);
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

            Points4[] marks = new Points4[25];
            Attendance4[] attending = new Attendance4[25];
            for (int i = 0; i < 25; i++)
            {
                marks[i] = new Points4(numberLabWorks, numberHomeWorks);
                attending[i] = new Attendance4(numberLessons);
                IPZ11[i] = new Student4(marks[i], attending[i], fullnames[i]);
            }

            IPZ11.generatingGroup(element);
            Console.ReadKey();
            IPZ11.printGroupAttending(semester, numberLessons, OOP);
            Console.ReadKey();
            IPZ11.printGroupPoints(numberLabWorks, numberHomeWorks);

            //=============================заміна інформації==========================================
            int studentNumb, studentNumb2; choosing = 1;            
            Console.WriteLine();
            Console.WriteLine(new string('=', 100));
            Console.WriteLine(new string(' ', 30) + " Заміна даних");
            while (choosing != 0)
            {
                Console.WriteLine("Меню");
                Console.WriteLine("1. Робота з обліком присутності.");
                Console.WriteLine("2. Робота з журналом оцінок.");
                Console.WriteLine("3. Отримати відомості про студента до іспиту.");
                Console.WriteLine("4. Отримати відомості про студента після іспиту.");
                Console.WriteLine("5. Робота з операторами.");
                Console.WriteLine("6. Перегляд обліку присутності та журналу оцінок.");
                Console.Write("Введіть номер завдання (0 щоб зупинити): ");
                while (!int.TryParse(Console.ReadLine(), out choosing) || (choosing < 0 && choosing > 6))
                {
                    Console.Write("Ведіть від 1 до 6 (0 щоб зупинити): ");
                }
                switch (choosing)
                {
                    case 1: IPZ11.changeAttendance(numberLessons); break;
                    case 2: IPZ11.changePoints(numberLabWorks, numberHomeWorks); break;
                    case 3:
                        {
                            Console.Write("Оберіть номер студента: ");
                            while (!int.TryParse(Console.ReadLine(), out studentNumb) || studentNumb < 1 || studentNumb > 25)
                            {
                                Console.Write("Ведіть число від 1 до 25: ");
                            }
                            IPZ11[studentNumb - 1].informBeforeExam(IPZ11); break;
                        }
                    case 4:
                        {
                            Console.Write("Оберіть номер студента: ");
                            while (!int.TryParse(Console.ReadLine(), out studentNumb) || studentNumb < 1 || studentNumb > 25)
                            {
                                Console.Write("Ведіть число від 1 до 25: ");
                            }
                            IPZ11[studentNumb - 1].ExamPoints = element.Next(0, 41);
                            IPZ11[studentNumb - 1].informAfterExam(IPZ11); break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Порівняння двох студентів за успішністю");
                            Console.Write("Оберіть 1-ого студента: ");
                            while (!int.TryParse(Console.ReadLine(), out studentNumb) || studentNumb < 1 || studentNumb > 25)
                            {
                                Console.Write("Ведіть число від 1 до 25: ");
                            }
                            Console.Write("Оберіть 2-ого студента: ");
                            while (!int.TryParse(Console.ReadLine(), out studentNumb2) || studentNumb2 < 1 || studentNumb2 > 25)
                            {
                                Console.Write("Ведіть число від 1 до 25: ");
                            }
                            bool best = IPZ11[studentNumb - 1] > IPZ11[studentNumb2 - 1];
                            if (best)
                                Console.WriteLine($"{IPZ11[studentNumb - 1].fullName} більш успішний студент, ніж {IPZ11[studentNumb2 - 1].fullName}");
                            else
                                Console.WriteLine($"{IPZ11[studentNumb2 - 1].fullName} більш успішний студент, ніж {IPZ11[studentNumb - 1].fullName}");                            
                            Console.WriteLine("Збільшуємо поточний бал у першого студента на 5 і зменшуємо у другого на 5");
                            ++IPZ11[studentNumb - 1]; --IPZ11[studentNumb2 - 1];
                            IPZ11[studentNumb - 1].informBeforeExam(IPZ11);
                            IPZ11[studentNumb2 - 1].informBeforeExam(IPZ11);
                            break;
                        }
                    case 6:
                        {
                            Console.ReadKey();
                            IPZ11.printGroupAttending(semester, numberLessons, OOP);
                            Console.ReadKey();
                            IPZ11.printGroupPoints(numberLabWorks, numberHomeWorks); break;
                        }
                }                
            }        
        }       
    }
}
