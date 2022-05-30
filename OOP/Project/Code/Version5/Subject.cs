using System;
using System.Collections.Generic;

namespace Project
{
    class Subject
    {
        string nameSubject;
        string fullNamelecturer;
        int numberLessons;

        public firstSemester oneSemester;
        public secondSemester otherSemester;

        //конструктори
        public Subject(string nameSubject, string fullNamelecturer, int numberLessons)
        {
            this.nameSubject = nameSubject;
            this.fullNamelecturer = fullNamelecturer;
            this.numberLessons = numberLessons;
            oneSemester = new firstSemester(numberLessons);
            otherSemester = new secondSemester(numberLessons);
        }
        public Subject()
        {
            Console.WriteLine("Предмет без інфомації був створений");
        }
        public Subject(Subject previous)
        {
            this.nameSubject = previous.nameSubject;
            this.fullNamelecturer = previous.fullNamelecturer;
            oneSemester = new firstSemester(numberLessons);
            otherSemester = new secondSemester(numberLessons);
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
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Інформація про дисципліну");
            Console.WriteLine("Предмет: " + nameSubject);
            Console.WriteLine("Лектор: " + fullNamelecturer);
            Console.WriteLine("Кількість занять в семестрі: " + numberLessons);
        }
    }

    class firstSemester
    {
        int[] september;
        int[] october;
        int[] november;
        int[] december;

        //конструктори
        public firstSemester(int numberLessons)
        {
            september = new int[numberLessons / 4];
            october = new int[numberLessons / 4];
            november = new int[numberLessons / 4];
            december = new int[(numberLessons - 3 * (numberLessons / 4))];
        }

        public void generateRandomDates(int numberLessons, Random element)
        {
            for (int i = 0; i < (numberLessons / 4); i++)
            {
                september[i] = new int();
                september[i] = element.Next(1, 30);
                october[i] = new int();
                october[i] = element.Next(1, 31);
                november[i] = new int();
                november[i] = element.Next(1, 30);
            }
            for (int i = 0; i < (numberLessons - 3 * (numberLessons / 4)); i++)
            {
                december[i] = new int();
                december[i] = element.Next(1, 31);
            }
            Array.Sort(september); Array.Sort(october);
            Array.Sort(november); Array.Sort(december);
        }

        public void changeDates()
        {
            Console.WriteLine(new string('-', 70));
            int month, lesson, newDate, choosing = 1;
            while (choosing == 1)
            {
                Console.Write("Введіть номер місяця: ");
                while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 4)
                {
                    Console.Write("Ведіть від 1 до 4: ");
                }
                Console.Write("Введіть номер заняття: ");
                while (!int.TryParse(Console.ReadLine(), out lesson) || lesson < 1 || lesson > 30)
                {
                    Console.Write("Ведіть інше: ");
                }
                Console.Write("Введіть нову дату: ");
                while (!int.TryParse(Console.ReadLine(), out newDate) || newDate < 1 || newDate > 30)
                {
                    Console.Write("Ведіть від 1 до 30: ");
                }
                switch (month)
                {
                    case 1: september[lesson - 1] = newDate; Array.Sort(september); break;
                    case 2: october[lesson - 1] = newDate; Array.Sort(october); break;
                    case 3: november[lesson - 1] = newDate; Array.Sort(november); break;
                    case 4: december[lesson - 1] = newDate; Array.Sort(december); break;
                }

                Console.Write("Завершити зміни? (Так = 0, Ні = 1): ");
                while (!int.TryParse(Console.ReadLine(), out choosing) || (choosing != 1 && choosing != 0))
                {
                    Console.Write("Ведіть 0 або 1: ");
                }
                Console.WriteLine();
            }
        }

        public void printDates(int numberLessons)
        {
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Перший семестр");
            Console.Write("Вересень: ");
            for (int i = 0; i < (numberLessons / 4); i++)
            {
                Console.Write(september[i] + " ");
            }
            Console.Write("\nЖовтень: ");
            for (int i = 0; i < (numberLessons / 4); i++)
            {
                Console.Write(october[i] + " ");
            }
            Console.Write("\nЛистопад: ");
            for (int i = 0; i < (numberLessons / 4); i++)
            {
                Console.Write(november[i] + " ");
            }
            Console.Write("\nГрудень: ");
            for (int i = 0; i < (numberLessons - 3 * (numberLessons / 4)); i++)
            {
                Console.Write(december[i] + " ");
            }
            Console.WriteLine();
        }

        public void printAllDates(int numberLessons)
        {
            Console.WriteLine("\t\t\tВересень\t\tЖовтень\t\t\tЛистопад\t\tГрудень");
            Console.Write("\t\t   ");
            for (int i = 0; i < (numberLessons / 4); i++)
            {
                Console.Write(september[i] + " ");
            }
            Console.Write("\t   ");
            for (int i = 0; i < (numberLessons / 4); i++)
            {
                Console.Write(october[i] + " ");
            }
            Console.Write("\t   ");
            for (int i = 0; i < (numberLessons / 4); i++)
            {
                Console.Write(november[i] + " ");
            }
            Console.Write("\t   ");
            for (int i = 0; i < (numberLessons - 3 * (numberLessons / 4)); i++)
            {
                Console.Write(december[i] + " ");
            }
            Console.WriteLine();
        }
    }

    class secondSemester
    {
        int[] january;
        int[] february;
        int[] march;
        int[] april;
        int[] may;

        //конструктори
        public secondSemester(int numberLessons)
        {
            january = new int[numberLessons / 5];
            february = new int[numberLessons / 5];
            march = new int[numberLessons / 5];
            april = new int[numberLessons / 5];
            may = new int[(numberLessons - 4 * (numberLessons / 5))];
        }


        public void generateRandomDates(int numberLessons, Random element)
        {
            for (int i = 0; i < (numberLessons / 5); i++)
            {
                january[i] = new int();
                january[i] = element.Next(1, 31);
                february[i] = new int();
                february[i] = element.Next(1, 28);
                march[i] = new int();
                march[i] = element.Next(1, 31);
                april[i] = new int();
                april[i] = element.Next(1, 30);
            }
            for (int i = 0; i < (numberLessons - 4 * (numberLessons / 5)); i++)
            {
                may[i] = new int();
                may[i] = element.Next(1, 31);
            }
            Array.Sort(january); Array.Sort(february);
            Array.Sort(march); Array.Sort(april); Array.Sort(may);
        }

        public void changeDates()
        {
            Console.WriteLine(new string('-', 70));
            int month, lesson, newDate, choosing = 1;
            while (choosing == 1)
            {
                Console.Write("Введіть номер місяця: ");
                while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 5)
                {
                    Console.Write("Ведіть від 1 до 5: ");
                }
                Console.Write("Введіть номер заняття: ");
                while (!int.TryParse(Console.ReadLine(), out lesson) || lesson < 1 || lesson > 30)
                {
                    Console.Write("Ведіть інше: ");
                }
                Console.Write("Введіть нову дату: ");
                while (!int.TryParse(Console.ReadLine(), out newDate) || newDate < 1 || newDate > 30)
                {
                    Console.Write("Ведіть від 1 до 30: ");
                }
                switch (month)
                {
                    case 1: january[lesson - 1] = newDate; Array.Sort(january); break;
                    case 2: february[lesson - 1] = newDate; Array.Sort(february); break;
                    case 3: march[lesson - 1] = newDate; Array.Sort(march); break;
                    case 4: april[lesson - 1] = newDate; Array.Sort(april); break;
                    case 5: may[lesson - 1] = newDate; Array.Sort(may); break;
                }

                Console.Write("Завершити зміни? (Так = 0, Ні = 1): ");
                while (!int.TryParse(Console.ReadLine(), out choosing) || (choosing != 1 && choosing != 0))
                {
                    Console.Write("Ведіть 0 або 1: ");
                }
                Console.WriteLine();
            }
        }

        public void printDates(int numberLessons)
        {
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Другий семестр");
            Console.Write("Січень: ");
            for (int i = 0; i < (numberLessons / 5); i++)
            {
                Console.Write(january[i] + " ");
            }
            Console.Write("\nЛютий: ");
            for (int i = 0; i < (numberLessons / 5); i++)
            {
                Console.Write(february[i] + " ");
            }
            Console.Write("\nБерезень: ");
            for (int i = 0; i < (numberLessons / 5); i++)
            {
                Console.Write(march[i] + " ");
            }
            Console.Write("\nКвітень: ");
            for (int i = 0; i < (numberLessons / 5); i++)
            {
                Console.Write(april[i] + " ");
            }
            Console.Write("\nТравень: ");
            for (int i = 0; i < (numberLessons - 4 * (numberLessons / 5)); i++)
            {
                Console.Write(may[i] + " ");
            }
            Console.WriteLine();
        }

        public void printAllDates(int numberLessons)
        {
            Console.WriteLine("\t\t\tСічень\t\t\tЛютий\t\t\tБерезень\t\t\tКвітень\t\t      Травень");
            Console.Write("\t\t   ");
            for (int i = 0; i < (numberLessons / 5); i++)
            {
                Console.Write(january[i] + " ");
            }
            Console.Write("\t");
            for (int i = 0; i < (numberLessons / 5); i++)
            {
                Console.Write(february[i] + " ");
            }
            Console.Write("\t");
            for (int i = 0; i < (numberLessons / 5); i++)
            {
                Console.Write(march[i] + " ");
            }
            Console.Write("\t    ");
            for (int i = 0; i < (numberLessons / 5); i++)
            {
                Console.Write(april[i] + " ");
            }
            Console.Write("\t");
            for (int i = 0; i < (numberLessons - 4 * (numberLessons / 5)); i++)
            {
                Console.Write(may[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
