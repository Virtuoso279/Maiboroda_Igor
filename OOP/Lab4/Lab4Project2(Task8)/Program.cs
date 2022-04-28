using System;

namespace Lab4abstract
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Lab 4 (Variant 5) Maiboroda Igor IPZ-11/2");
            Console.WriteLine("Task 8. Abstract class");
            Console.WriteLine("=================================================================");
            Console.WriteLine("Let's create instances of concrete classes!");            
            FactoryAb Tesla = new FactoryAb("Tesla", "USA", "manufacturing", 40000, 58000000, "cars", 254000, 112);
            InsuranceCompanyAb AXA = new InsuranceCompanyAb("AXA", "France", "insurance", 150000, 860000000, "investments", 45000, 2);
            OilGasCompanyAb PetroChina = new OilGasCompanyAb("PetroChina", "China", "processing", 506000, 297000000, 29, 1540, 890000, 10200000);

            Console.WriteLine("=================================================================");
            Console.WriteLine("Let's show values of fields of classes");            
            Tesla.printValues();            
            AXA.printValues();            
            PetroChina.printValues();           

            Console.WriteLine("=================================================================");
            Console.WriteLine("Use public methods in abstract class");
            Random element = new Random();
            Tesla.changeIncome(element);
            AXA.changeNumberEmpl(element);
            PetroChina.changeIncome(element);
        }
    }
}
