using System;

namespace Lab4interf
{
    interface IComparable
    {
        int CompareTo(int number);
    }

    interface IComparer
    {
        int Compare(int value1, int value2);
    }

    interface IEnumerable
    {
        void GetEnumerator(Enterprise[] elem, int numb);
    }

    class Program
    {
        static void Main()
        {
            int number = 1;
            Random element = new Random();
            Console.WriteLine("Lab 4 (Variant 5) Maiboroda Igor IPZ-11/2");
            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Task 9");            
            Console.Write("Enter number of instances of class: ");
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.Write("Enter other value: ");
            }
            Enterprise[] company = new Enterprise[number];
            for (int i = 0; i < number; i++)
            {
                company[i] = new Enterprise(("company" + i),  ("city" + i), element.Next(1, 50000), element.Next(10000, 100000), 0);                
                Console.Write($"Input rating of {i} company: ");
                company[i].Rating = Convert.ToInt32(Console.ReadLine());
                company[i].printValuesE();
            }

            //interface IComparable
            int index1, index2;
            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Using interface IComparable");
            Console.Write("Input indexes of elements of array to compare them: ");
            while (!int.TryParse(Console.ReadLine(), out index1) || index1 < 0 || index1 >= number)
            {
                Console.Write("Enter other value: ");
            }
            while (!int.TryParse(Console.ReadLine(), out index2) || index2 < 0 || index2 >= number)
            {
                Console.Write("Enter other value: ");
            }
            //перевірка значень
            if (company[index1].NumberEmployes.CompareTo(company[index2].NumberEmployes) > 0)
            {
                Console.WriteLine($"{company[index1].Name} has more employes than {company[index2].Name}");
            }
            else if (company[index1].NumberEmployes.CompareTo(company[index2].NumberEmployes) < 0)
            {
                Console.WriteLine($"{company[index2].Name} has more employes than {company[index1].Name}");
            }
            else
            {
                Console.WriteLine("The numbers of employes are the same");
            }

            //interface IComparer
            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Using interface IComparer");
            Console.WriteLine("Let's compare the number of employes and income of enterprise");
            Console.Write("Input index of element of array: ");
            while (!int.TryParse(Console.ReadLine(), out index1) || index1 < 0 || index1 >= number)
            {
                Console.Write("Enter other value: ");
            }
            //перевірка значень
            if (company[index1].Compare(company[index1].NumberEmployes, company[index1].Income) > 0)
            {
                Console.WriteLine($"{company[index1].Name} has more employes than income");
            }
            else if (company[index1].Compare(company[index1].NumberEmployes, company[index1].Income) < 0)
            {
                Console.WriteLine($"{company[index2].Name} has more income than employes");
            }
            else
            {
                Console.WriteLine("The numbers of employes and income are the same");
            }

            //interface IEnumerable
            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Using interface IEnumerable: sorting by rating");
            company[0].GetEnumerator(company, number);
            for (int i = 0; i < number; i++)
            {                
                company[i].printValuesE();
            }
        }
    }
}
