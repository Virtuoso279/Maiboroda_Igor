using System;

namespace Lab5
{
    class InsuranceCompany : Enterprise
    {
        private string typeService;
        private int numberCustomers;
        private int localRating;

        //конструктори
        public InsuranceCompany(string name, string location, string sphere, int numberEmployes, int income, string typeService, int numberCustomers, int localRating) : base(name, location, sphere, numberEmployes, income)
        {
            this.typeService = typeService;
            this.numberCustomers = numberCustomers;
            this.localRating = localRating;
            Console.WriteLine("Insurance Company with parameters was created!");
        }
        public InsuranceCompany() { Console.WriteLine("Insurance Company without parameters was created!"); }
        public InsuranceCompany(InsuranceCompany previous)
        {
            this.typeService = previous.typeService;
            this.numberCustomers = previous.numberCustomers;
            this.localRating = previous.localRating;
            Console.WriteLine("Insurance Company copy was created!");
        }

        //властивості, аксесори
        public int NumberCustomers
        {
            get { return numberCustomers; }
            set { numberCustomers = value; }
        }
        public string TypeService
        {
            get { return typeService; }
            set { typeService = value; }
        }
        public int LocalRating
        {
            get { return localRating; }
            set { localRating = value; }
        }

        //метод виводу значень на консоль
        public void printValuesI()
        {
            Console.WriteLine("=== Insurance Company ===");
            Console.WriteLine($"Name: {name}\nLocation: {location}\nSphere: {sphere}\nNumberEmployes: {numberEmployes}\nIncome: {income}\nTypeService: {typeService}\nNumberCustomers: {numberCustomers}\nRating: {localRating}");
        }

        //прибуток компанії
        public override void changeIncome(Random element)
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
        public override void changeIncome(Random element, int part)
        {
            Console.WriteLine($"Calculating income of {name}");
            int costProduction;
            Console.WriteLine($"Part of production = {part}%");
            Console.Write("Input the total cost of production: ");
            while (!int.TryParse(Console.ReadLine(), out costProduction) || costProduction <= 0)
            {
                Console.WriteLine("Input other value: ");
            }
            income = part * costProduction / 100;
            Console.WriteLine($"Income of {name} = {income}");
        }
        public override void changeIncome(Random element, int part, int costProduction)
        {
            Console.WriteLine($"Calculating income of {name}");
            Console.WriteLine($"Part of production = {part}%");
            Console.WriteLine($"The total cost of production: {costProduction}");
            income = part * costProduction / 100;
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
        public static bool operator >(InsuranceCompany obj1, InsuranceCompany obj2)
        {
            if (obj1.income > obj2.income)
                return true;
            else
                return false;
        }
        public static bool operator <(InsuranceCompany obj1, InsuranceCompany obj2)
        {
            if (obj1.income < obj2.income)
                return true;
            else
                return false;
        }

        //перевантаження унарних операторів
        public static InsuranceCompany operator ++(InsuranceCompany elem)
        {
            elem.numberCustomers += 1000;
            elem.localRating += 1000;
            return elem;
        }
    }
}
