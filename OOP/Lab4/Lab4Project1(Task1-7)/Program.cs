using System;

namespace Lab4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Lab 4 (Variant 5) Maiboroda Igor IPZ-11/2");
            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Task 1-2");
            Enterprise object1 = new Enterprise("company", "Ukraine", "commerce", 2150, 850000);

            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Task 3");
            Factory Tesla = new Factory("Tesla", "USA", "manufacturing", 40000, 58000000, "cars", 254000, 112);
            InsuranceCompany AXA = new InsuranceCompany("AXA", "France", "insurance", 150000, 860000000, "investments", 45000, 2);
            OilGasCompany PetroChina = new OilGasCompany("PetroChina", "China", "processing", 506000, 297000000, 29, 1540, 890000, 10200000);

            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Task 4-5");
            object1.printValuesE();
            object1.Location = "Poland"; object1.NumberEmployes = 50; object1.Income = 1110;
            Console.WriteLine("Values was changed");
            object1.printValuesE();
            Tesla.printValuesF();
            Tesla.ProductionVolume = 10; Tesla.TypeProduct = "medicines";
            Console.WriteLine("Values was changed");
            Tesla.printValuesF();
            AXA.printValuesI();
            AXA.NumberCustomers = 250; AXA.LocalRating = 10;
            Console.WriteLine("Values was changed");
            AXA.printValuesI();
            PetroChina.printValuesO();
            PetroChina.NumberFields = 0; PetroChina.OilVolume = 100500;
            Console.WriteLine("Values was changed");
            PetroChina.printValuesO();

            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Task 6");
            Random element = new Random();
            Tesla.changeIncome(element);
            AXA.changeNumberEmpl(element);

            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Task 7. Interface");

            object1.swap();
            PetroChina.setNegativeO();
            AXA.reduceValues();
            Tesla.changeTypeProduct(element);
        }
    }
}
