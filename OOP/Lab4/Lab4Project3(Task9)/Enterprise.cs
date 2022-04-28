using System;
using System.Collections;

namespace Lab4interf
{
    class Enterprise : IComparable, IComparer, IEnumerable
    {
        protected string name;        
        protected string sphere;
        protected int numberEmployes;
        protected int income;
        protected int rating;        

        //конструктор з параметрами
        public Enterprise(string name, string sphere, int numberEmployes, int income, int rating)
        {
            this.name = name;            
            this.sphere = sphere;
            this.numberEmployes = numberEmployes;
            this.income = income;
            this.rating = rating;            
        }
        public Enterprise() { }

        //властивості з аксесорами
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
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
            Console.WriteLine($"Name: {name}\nSphere: {sphere}\nNumberEmployes: {numberEmployes}\nIncome: {income}\nRating: {rating}");
        }       

        //методи, які реалізують інтерфейси
        public int CompareTo(int number)
        {
            return number;
        }

        public int Compare(int value1, int value2)
        {
            return value1.CompareTo(value2);
        }

        public void GetEnumerator(Enterprise[] elem, int numb)
        {
            Enterprise temp = new Enterprise();
            for (int i = 0; i < numb-1; i++)
            {
                for (int k = i+1; k < numb; k++)
                {
                    if (elem[i].Rating > elem[k].Rating)
                    {
                        temp = elem[i];
                        elem[i] = elem[k];
                        elem[k] = temp;
                    }
                }
            }
        }
    }
}

