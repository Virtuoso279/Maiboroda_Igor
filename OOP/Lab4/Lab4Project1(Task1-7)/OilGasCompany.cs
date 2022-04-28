using System;

namespace Lab4
{
    class OilGasCompany : Enterprise
    {
        private int numberStations;
        private int numberFields;
        private int oilVolume;
        private int gasVolume;

        //конструктор з параметрами
        public OilGasCompany(string name, string location, string sphere, int numberEmployes, int income, int numberStations, int numberFields, int oilVolume, int gasVolume) : base(name, location, sphere, numberEmployes, income)
        {
            this.numberStations = numberStations;
            this.numberFields = numberFields;
            this.oilVolume = oilVolume;
            this.gasVolume = gasVolume;
            Console.WriteLine("Oil and Gas Company was created!");
        }

        //властивості, аксесори
        public int NumberFields
        {
            get { return numberFields; }
            set { numberFields = value; }
        }
        public int OilVolume
        {
            get { return oilVolume; }
            set { oilVolume = value; }
        }
        
        //метод виводу значень на консоль
        public void printValuesO()
        {
            Console.WriteLine("=== Oil and Gas Company ===");
            Console.WriteLine($"Name: {name}\nLocation: {location}\nSphere: {sphere}\nNumberEmployes: {numberEmployes}\nIncome: {income}\nNumberStations: {numberStations}\nNumberFields: {numberFields}\nOilVolume: {oilVolume}\nGasVolume: {gasVolume}");
        }

        public override void setNegativeO()
        {
            Console.WriteLine("Method to set values negative");
            numberStations *= (-1);
            numberFields *= (-1);
            oilVolume *= (-1);
            gasVolume *= (-1);
            printValuesO();
        }
    }
}
