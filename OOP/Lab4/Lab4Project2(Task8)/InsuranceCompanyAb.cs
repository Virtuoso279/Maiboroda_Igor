using System;

namespace Lab4abstract
{
    class InsuranceCompanyAb : EnterpriseAb
    {
        private string typeService;
        private int numberCustomers;
        private int localRating;

        //конструктор з параметрами
        public InsuranceCompanyAb(string name, string location, string sphere, int numberEmployes, int income, string typeService, int numberCustomers, int localRating) : base(name, location, sphere, numberEmployes, income)
        {
            this.typeService = typeService;
            this.numberCustomers = numberCustomers;
            this.localRating = localRating;
            Console.WriteLine("Insurance Company was created!");
        }

        //властивості, аксесори
        public int NumberCustomers
        {
            get { return numberCustomers; }
            set { numberCustomers = value; }
        }
        public int LocalRating
        {
            get { return localRating; }
            set { localRating = value; }
        }

        //метод виводу значень на консоль
        public override void printValues()
        {
            Console.WriteLine("=== Insurance Company ===");
            Console.WriteLine($"Name: {name}\nLocation: {location}\nSphere: {sphere}\nNumberEmployes: {numberEmployes}\nIncome: {income}");
            Console.WriteLine($"TypeService: {typeService}\nNumberCustomers: {numberCustomers}\nRating: {localRating}");
        }
    }
}
