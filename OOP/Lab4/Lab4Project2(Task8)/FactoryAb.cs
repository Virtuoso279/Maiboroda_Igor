using System;

namespace Lab4abstract
{
    class FactoryAb : EnterpriseAb
    {
        private string typeProduct;
        private int productionVolume;
        private int numberDepartments;

        //конструктор з параметрами
        public FactoryAb(string name, string location, string sphere, int numberEmployes, int income, string typeProduct, int productionVolume, int numberDepartments) : base(name, location, sphere, numberEmployes, income)
        {
            this.typeProduct = typeProduct;
            this.productionVolume = productionVolume;
            this.numberDepartments = numberDepartments;
            Console.WriteLine("Factory was created!");
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

        //метод виводу значень на консоль
        public override void printValues()
        {
            Console.WriteLine("=== Factory ===");
            Console.WriteLine($"Name: {name}\nLocation: {location}\nSphere: {sphere}\nNumberEmployes: {numberEmployes}\nIncome: {income}");
            Console.WriteLine($"TypeProduct: {typeProduct}\nProductionVolume: {productionVolume}\nNumberDepartments: {numberDepartments}");
        }
    }
}
