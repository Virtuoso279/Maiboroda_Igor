using System;

namespace Lab5
{
    class University : Enterprise
    {
        private int numberScientificWork;
        private int contractStudents;

        //конструктори
        public University(string name, string location, string sphere, int numberEmployes, int income, int numberScientificWork, int contractStudents) : base(name, location, sphere, numberEmployes, income)
        {
            this.numberScientificWork = numberScientificWork;
            this.contractStudents = contractStudents;
            Console.WriteLine("University with parameters was created!");
        }
        public University() { Console.WriteLine("University without parameters was created!"); }
        public University(University previous)
        {
            this.name = previous.name;
            this.location = previous.location;
            this.sphere = previous.sphere;
            this.numberEmployes = previous.numberEmployes;
            this.income = previous.income;
            this.numberScientificWork = previous.numberScientificWork;
            this.contractStudents = previous.contractStudents;
            Console.WriteLine("University copy was created!");
        }

        //властивості, аксесори
        public int NumberScientificWork
        {
            get { return numberScientificWork; }
            set { numberScientificWork = value; }
        }
        public int ContractStudents
        {
            get { return contractStudents; }
            set { contractStudents = value; }
        }

        //метод виводу значень на консоль
        public void printValuesU()
        {
            Console.WriteLine("=== University ===");
            Console.WriteLine($"Name: {name}\nLocation: {location}\nSphere: {sphere}\nNumberEmployes: {numberEmployes}\nIncome: {income}\nNumber Scientific Works: {numberScientificWork}\nNumber of Contract Students: {contractStudents}");
        }

        //прибуток компанії
        public override void changeIncome(Random element)
        {
            Console.WriteLine($"Calculating income of {name}");            
            Console.WriteLine($"The number of contract students = {contractStudents}");
            for (int i = 0; i < contractStudents; i++)
            {
                income += element.Next(1000, 3000);
            }            
            Console.WriteLine($"Income of {name} = {income}");
        }
                
        //кількість працівників
        public override void changeNumberEmpl(Random element)
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
        public override void changeNumberEmpl(Random element, int salaryFund)
        {
            Console.WriteLine($"Calculating number of employes of {name}");
            int salaryEmploye;
            Console.WriteLine($"Salary fund of {name} = {salaryFund}");
            Console.Write("Enter average salary of employes: ");
            while (!int.TryParse(Console.ReadLine(), out salaryEmploye) || salaryEmploye <= 0)
            {
                Console.WriteLine("Input other value: ");
            }
            numberEmployes = salaryFund / salaryEmploye;
            Console.WriteLine($"Number of employes of {name} = {numberEmployes}");
        }
        public override void changeNumberEmpl(Random element, int salaryFund, int salaryEmploye)
        {
            Console.WriteLine($"Calculating number of employes of {name}");
            Console.WriteLine($"Salary fund of {name} = {salaryFund}");
            Console.WriteLine($"Average salary of employes: {salaryEmploye}");
            numberEmployes = salaryFund / salaryEmploye;
            Console.WriteLine($"Number of employes of {name} = {numberEmployes}");
        }

        //перевантаження бінарних операторів
        public static bool operator >(University obj1, University obj2)
        {
            if (obj1.income > obj2.income)
                return true;
            else
                return false;
        }
        public static bool operator <(University obj1, University obj2)
        {
            if (obj1.income < obj2.income)
                return true;
            else
                return false;
        }

        //перевантаження унарних операторів
        public static University operator ++(University elem)
        {
            elem.numberScientificWork += 1000;
            elem.contractStudents += 1000;            
            return elem;
        }
    }
}
