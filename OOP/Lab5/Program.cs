using System;

namespace Lab5
{
    class Program
    {
        static void Main()
        {
            Random element = new Random();
            Console.WriteLine("Lab 5 (Variant 5) Maiboroda Igor IPZ-11/2");
            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Task 1-2");
            Enterprise company1 = new Enterprise("company", "Ukraine", "commerce", 2150, 850000);
            Enterprise company2 = new Enterprise();
            Enterprise company3 = new Enterprise(company1);
            University univer1 = new University("KNU", "Kiev", "education", 3500, 24300, 20, 24100);
            University univer2 = new University();
            University univer3 = new University(univer1);            
            company2.printValuesE();
            company3.printValuesE();
            univer1.printValuesU();
            univer2.printValuesU();
            univer3.printValuesU();

            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Task 3");
            Console.WriteLine("Let's change income of factory");
            Factory Tesla = new Factory("Tesla", "USA", "manufacturing", 40000, 58000000, "cars", 254000, 112);
            Tesla.changeIncome(element, 45, 200000);
            Tesla.printValuesF();
            Console.WriteLine("Let's change income of 1 university");            
            univer1.changeIncome(element);
            univer1.printValuesU();
            
            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Task 4");
            Console.WriteLine("Let's change number of employees of insurance company");
            InsuranceCompany AXA = new InsuranceCompany("AXA", "France", "insurance", 150000, 860000000, "investments", 45000, 2);
            AXA.changeNumberEmpl(element, 850200);
            AXA.printValuesI();
            Console.WriteLine("Let's change number of employees of 3 university");            
            univer3.changeNumberEmpl(element, 450600, 650);
            univer3.printValuesU();

            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Task 5");
            Console.WriteLine("Let's verload of binary operators");
            bool result = univer1 > univer2;
            Console.WriteLine($"Is the income of 1 university more than 3 university {result}");
            Factory SpaceX = new Factory("SpaceX", "USA", "manufacturing", 22050, 650000, "spaceship", 132200, 250);
            result = Tesla > SpaceX;
            Console.WriteLine($"Is the income of Tesla more than SpaceX {result}");

            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Task 6");
            Console.WriteLine("Let's verload of unary operators");
            ++Tesla; Tesla.printValuesF();
            ++univer1; univer1.printValuesU();
            ++univer2; univer2.printValuesU();

            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Task 7");
            Enterprise universities = new Enterprise("universities");
            universities[0] = new University { Name = "KPI", Location = "Kiev", Sphere = "education" };
            universities[1] = new University { Name = "LNU", Location = "Lviv", Sphere = "education" };
            universities[2] = new University { Name = "SumDU", Location = "Sumy", Sphere = "education" };
            universities[0].NumberEmployes = 14600;
            universities[0].Income = 420300;
            universities[0].NumberScientificWork = 15;
            universities[0].ContractStudents = 12300;
            universities[0].printValuesU();
            universities[1].printValuesU();
            universities[2].printValuesU();
        }
    }
}