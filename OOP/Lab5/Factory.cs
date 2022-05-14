using System;

namespace Lab5
{
    class Factory : Enterprise
    {
        private string typeProduct;
        private int productionVolume;
        private int numberDepartments;

        //конструктори
        public Factory(string name, string location, string sphere, int numberEmployes, int income, string typeProduct, int productionVolume, int numberDepartments) : base(name, location, sphere, numberEmployes, income)
        {
            this.typeProduct = typeProduct;
            this.productionVolume = productionVolume;
            this.numberDepartments = numberDepartments;
            Console.WriteLine("Factory with parameters was created!");
        }
        public Factory() { Console.WriteLine("Factory without parameters was created!"); }
        public Factory(Factory previous)
        {
            this.typeProduct = previous.typeProduct;
            this.productionVolume = previous.productionVolume;
            this.numberDepartments = previous.numberDepartments;
            Console.WriteLine("Factory copy was created!");
        }

        //властивості, аксесори
        public string TypeProduct
        {
            get { return typeProduct; }
            set { typeProduct = value; }
        }
        public int ProductionVolume
        {
            get { return productionVolume; }
            set { productionVolume = value; }
        }
        public int NumberDepartments
        {
            get { return numberDepartments; }
            set { numberDepartments = value; }
        }

        //метод виводу значень на консоль
        public void printValuesF()
        {
            Console.WriteLine("=== Factory ===");
            Console.WriteLine($"Name: {name}\nLocation: {location}\nSphere: {sphere}\nNumberEmployes: {numberEmployes}\nIncome: {income}\nTypeProduct: {typeProduct}\nProductionVolume: {productionVolume}\nNumberDepartments: {numberDepartments}");
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
        public static bool operator >(Factory obj1, Factory obj2)
        {
            if (obj1.income > obj2.income)
                return true;
            else
                return false;
        }
        public static bool operator <(Factory obj1, Factory obj2)
        {
            if (obj1.income < obj2.income)
                return true;
            else
                return false;
        }

        //перевантаження унарних операторів
        public static Factory operator ++(Factory elem)
        {
            elem.numberDepartments += 1000;
            elem.productionVolume += 1000;
            return elem;
        }
    }
}


