using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Lab1
{
    class Program
    {
        static void FirstTask() //перше завдання
        {
            double r;
            Console.WriteLine("Завдання 1.");
            Console.WriteLine("ПIБ: Майборода Iгор Сергiйович\nВiк: 18 рокiв\nГрупа, курс: IПЗ-11, 1-ий курс\nE-mail: crazyfoxmen3@gmail.com");
            Console.Write("Введiть радiус сфери: ");
            while (!Double.TryParse(Console.ReadLine(), out r))  //перевірка на правильність вводу
            {
                Console.Write("Введiть додатнi числа с плаваючою точкою: ");                
            }
            if (r < 0)
            {
                Console.WriteLine("Радiус не має бути вiд'ємним!");
            } else
            {
                double V = (4 * Math.PI * Math.Pow(r, 3)) / 3;
                Console.WriteLine("Площа поверхнi сфери: " + V);
            }            
        }
        static void SecondTask() //друге завдання
        {
            double a, b;
            Console.WriteLine("Завдання 2.");            
            Console.Write("Введiть а: ");
            while (!Double.TryParse(Console.ReadLine(), out a))  //перевірка на правильність вводу
            {
                Console.Write("Введiть числа с плаваючою точкою: ");
            }            
            Console.Write("Введiть b: ");
            while (!Double.TryParse(Console.ReadLine(), out b))  //перевірка на правильність вводу
            {
                Console.Write("Введiть числа с плаваючою точкою: ");
            }
            if ((a > 0 && b > 0) || (a < 0 && b < 0))
            {
                double x = ((a + b) * Math.Pow(Math.E, (a - b)) * Math.Log(a * b)) / (Math.Pow(Math.Sin(a), 2) - Math.Pow(Math.Cos(b), 2));
                Console.WriteLine("х = " + x);
            } else
            {
                Console.WriteLine("Введенi числа не вiдповiдають умовi!");
            }            
        }
        static void ThirdTask() //третє завдання
        {
            double a, x;
            Console.WriteLine("Завдання 3.");
            Console.Write("Введiть а: ");
            while (!Double.TryParse(Console.ReadLine(), out a))  //перевірка на правильність вводу
            {
                Console.Write("Введiть числа с плаваючою точкою (a): ");
            }            
            Console.Write("Введiть x: ");
            while (!Double.TryParse(Console.ReadLine(), out x))  //перевірка на правильність вводу
            {
                Console.Write("Введiть числа с плаваючою точкою (x): ");
            }            
            double fx;
            if (x < 0 && a < 2 && a > 0) {
                fx = a * x + Math.Abs(a - 1);
                Console.WriteLine("f(x) = " + fx);
            } else if (x > 0 && a < 0) {
                fx = (1 + x) / a;
                Console.WriteLine("f(x) = " + fx);
            } else if (x == 0 && a >= 2) {
                fx = Math.Pow(Math.E, x) - a;
                Console.WriteLine("f(x) = " + fx);
            } else {
                Console.WriteLine("Значення а та х не вiдповiдають умовi");
            }                     
        }
        static void FourthTask() //четверте завдання
        {
            Int32 number;
            Console.WriteLine("Завдання 4.");
            Console.Write("Введiть номер спецiальностi: ");
            while (!Int32.TryParse(Console.ReadLine(), out number))  //перевірка на правильність вводу
            {
                Console.Write("Введiть цiлi числа: ");
            }
            if (number > 120 && number < 127)
            {
                switch (number)
                {
                    case 121: Console.WriteLine("Iнженерiя програмного забезпечення"); break;
                    case 122: Console.WriteLine("Комп'ютернi науки"); break;
                    case 123: Console.WriteLine("Комп'ютерна iнженерiя"); break;
                    case 124: Console.WriteLine("Системний аналiз"); break;
                    case 125: Console.WriteLine("Кiбербезпека"); break;
                    case 126: Console.WriteLine("Iнформацiйнi системи та технологiї"); break;
                }
            } else
            {
                Console.WriteLine("Некоректний номер спецiальностi!");
            }            
        }
        static void FifthTask() //п'яте завдання
        {
            Int32 n; double x;
            Console.WriteLine("Завдання 5.");
            Console.Write("Введiть n: ");
            while (!Int32.TryParse(Console.ReadLine(), out n))  //перевірка на правильність вводу
            {
                Console.Write("Введiть додатнi цiлi числа (n): ");
            }            
            Console.Write("Введiть x: ");
            while (!Double.TryParse(Console.ReadLine(), out x))  //перевірка на правильність вводу
            {
                Console.Write("Введiть додатнi числа с плаваючою точкою (x): ");
            }
            if (n > 0 && x > 0)
            {
                double P = 1;
                for (int i = 1; i <= n; i++)
                {
                    P *= (Math.Pow(-1, (i + 1)) * Math.Pow(x, i)) / Math.Pow(2, (i + 1));
                }
                Console.WriteLine("P = " + P);
            } else {
                Console.WriteLine("Два числа мають бути додатнiми!");
            }            
        }
        static void Main() //головна функція
        {
            int task = 10;
            Console.WriteLine("Лабораторна 1. IПЗ-11 Майборода Iгор");                        
            while (task != 0) 
            {
                Console.Write("Оберiть номер завдання (введiть 0 щоб зупинити програму): ");
                while (!Int32.TryParse(Console.ReadLine(), out task))  //перевірка на правильність вводу
                {
                    Console.Write("Введiть числа вiд 0 до 5: ");
                }                
                switch (task)
                {
                    case 1: FirstTask(); break;
                    case 2: SecondTask(); break;
                    case 3: ThirdTask(); break;
                    case 4: FourthTask(); break;
                    case 5: FifthTask(); break;
                }                               
            }      
        }
    }
}
