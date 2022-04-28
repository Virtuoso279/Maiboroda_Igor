using System;

namespace Lab4
{
    class Enterprise : IEnterprise
    {
        protected string name;
        protected string location;
        protected string sphere;
        protected int numberEmployes;
        protected int income;

        //конструктор з параметрами
        public Enterprise(string name, string location, string sphere, int numberEmployes, int income)
        {
            this.name = name;
            this.location = location;
            this.sphere = sphere;
            this.numberEmployes = numberEmployes;
            this.income = income;
            Console.WriteLine("Enterprise was created!");
        }

        //властивості, аксесори        
        public string Location 
        {
            get { return location; }
            set { location = value; }
        }

        public int NumberEmployes
        {
            get { return numberEmployes; }
            set { numberEmployes = value; }
        }
        public int Income
        {
            get { return income; }
            set { income = value; }
        }

        //метод виводу значень на консоль
        public void printValuesE()
        {
            Console.WriteLine("=== Enterprise ===");
            Console.WriteLine($"Name: {name}\nLocation: {location}\nSphere: {sphere}\nNumberEmployes: {numberEmployes}\nIncome: {income}");
        }

        public void changeIncome(Random element)
        {            
            Console.WriteLine($"Calculating income of {name}");
            int part, costProduction;
            part = element.Next(0, 100);
            Console.WriteLine($"Part of production = {part}%");
            Console.Write("Input the total cost of production: ");
            while (!int.TryParse(Console.ReadLine(), out costProduction) || costProduction <= 0)
            {
                Console.WriteLine("Input other value: ");
            }
            income = part * costProduction / 100;
            Console.WriteLine($"Income of {name} = {income}");
        }

        public void changeNumberEmpl(Random element)
        {
            Console.WriteLine($"Calculating number of employes of {name}");
            int salaryFund, salaryEmploye;
            salaryFund = element.Next(10000, 1000000);
            Console.WriteLine($"Salary fund of {name} = {salaryFund}");
            Console.Write("Enter average salary of employes: ");
            while (!int.TryParse(Console.ReadLine(), out salaryEmploye) || salaryEmploye <= 0)
            {
                Console.WriteLine("Input other value: ");
            }
            numberEmployes = salaryFund / salaryEmploye;
            Console.WriteLine($"Number of employes of {name} = {numberEmployes}");
        }
        
        public void swap()
        {
            Console.WriteLine("Method to swap name and location");
            string value = name;
            name = location;
            location = value;
            printValuesE();
        }

        public virtual void changeTypeProduct(Random element) { }

        public virtual void reduceValues() { }        

        public virtual void setNegativeO() { }
       
    }
}
