using System;

namespace Lab4
{
    class Factory : Enterprise
    {
        private string typeProduct;
        private int productionVolume;
        private int numberDepartments;

        //конструктор з параметрами
        public Factory(string name, string location, string sphere, int numberEmployes, int income, string typeProduct, int productionVolume, int numberDepartments) : base(name, location, sphere, numberEmployes, income)
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
        public void printValuesF()
        {
            Console.WriteLine("=== Factory ===");
            Console.WriteLine($"Name: {name}\nLocation: {location}\nSphere: {sphere}\nNumberEmployes: {numberEmployes}\nIncome: {income}\nTypeProduct: {typeProduct}\nProductionVolume: {productionVolume}\nNumberDepartments: {numberDepartments}");
        }

        public override void changeTypeProduct(Random element)
        {
            Console.WriteLine("Method to change type of production on random number");
            typeProduct = Convert.ToString(element.Next(-1000, 1000));
            printValuesF();
        }
    }
}
