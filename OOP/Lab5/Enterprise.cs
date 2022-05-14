using System;

namespace Lab5
{
    class Enterprise 
    {        
        protected string name;
        protected string location;
        protected string sphere;
        protected int numberEmployes;
        protected int income;

        //конструктори
        public Enterprise(string name, string location, string sphere, int numberEmployes, int income)
        {
            this.name = name;
            this.location = location;
            this.sphere = sphere;
            this.numberEmployes = numberEmployes;
            this.income = income;
            Console.WriteLine("Enterprise with parameters was created!");
        }
        public Enterprise() 
        {            
            Console.WriteLine("Enterprise without parameters was created!"); 
        }
        public Enterprise(Enterprise previous)
        {
            this.name = previous.name;
            this.location = previous.location;
            this.sphere = previous.sphere;
            this.numberEmployes = previous.numberEmployes;
            this.income = previous.income;
            Console.WriteLine("Enterprise copy was created!");
        }

        //властивості, аксесори
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Sphere
        {
            get { return sphere; }
            set { sphere = value; }
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

        //прибуток компаній
        public virtual void changeIncome(Random element) { }
        public virtual void changeIncome(Random element, int part) { }
        public virtual void changeIncome(Random element, int part, int costProduction) { }

        //кількість працівників
        public virtual void changeNumberEmpl(Random element) { }
        public virtual void changeNumberEmpl(Random element, int salaryFund) { }
        public virtual void changeNumberEmpl(Random element, int salaryFund, int salaryEmploye) { }

        //масив об'єктів Університету
        University[] data;
        public Enterprise(string name)
        {
            data = new University[10];
            this.name = name;            
            Console.WriteLine("Enterprise with parameters was created!");
        }
        public University this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
    }
}
