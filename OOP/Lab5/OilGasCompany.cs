using System;

namespace Lab5
{
    class OilGasCompany : Enterprise
    {
        private int numberStations;
        private int numberFields;
        private int oilVolume;
        private int gasVolume;

        //конструктори
        public OilGasCompany(string name, string location, string sphere, int numberEmployes, int income, int numberStations, int numberFields, int oilVolume, int gasVolume) : base(name, location, sphere, numberEmployes, income)
        {
            this.numberStations = numberStations;
            this.numberFields = numberFields;
            this.oilVolume = oilVolume;
            this.gasVolume = gasVolume;
            Console.WriteLine("Oil and Gas Company with parameters was created!");
        }
        public OilGasCompany() { Console.WriteLine("Oil and Gas Company without parameters was created!"); }
        public OilGasCompany(OilGasCompany previous)
        {
            this.numberStations = previous.numberStations;
            this.numberFields = previous.numberFields;
            this.oilVolume = previous.oilVolume;
            this.gasVolume = previous.gasVolume;
            Console.WriteLine("Oil and Gas Company copy was created!");
        }

        //властивості, аксесори
        public int NumberFields
        {
            get { return numberFields; }
            set { numberFields = value; }
        }
        public int NumberStations
        {
            get { return numberStations; }
            set { numberStations = value; }
        }
        public int OilVolume
        {
            get { return oilVolume; }
            set { oilVolume = value; }
        }
        public int GasVolume
        {
            get { return gasVolume; }
            set { gasVolume = value; }
        }

        //метод виводу значень на консоль
        public void printValuesO()
        {
            Console.WriteLine("=== Oil and Gas Company ===");
            Console.WriteLine($"Name: {name}\nLocation: {location}\nSphere: {sphere}\nNumberEmployes: {numberEmployes}\nIncome: {income}\nNumberStations: {numberStations}\nNumberFields: {numberFields}\nOilVolume: {oilVolume}\nGasVolume: {gasVolume}");
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
        public static bool operator >(OilGasCompany obj1, OilGasCompany obj2)
        {
            if (obj1.income > obj2.income)
                return true;
            else
                return false;
        }
        public static bool operator <(OilGasCompany obj1, OilGasCompany obj2)
        {
            if (obj1.income < obj2.income)
                return true;
            else
                return false;
        }

        //перевантаження унарних операторів
        public static OilGasCompany operator ++(OilGasCompany elem)
        {
            elem.numberStations += 1000;
            elem.numberFields += 1000;
            elem.oilVolume += 1000;
            elem.gasVolume += 1000;
            return elem;
        }
    }
}
