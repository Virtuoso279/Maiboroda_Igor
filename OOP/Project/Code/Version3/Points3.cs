using System;
using System.Collections.Generic;

namespace Version3
{
    class Points3
    {
        int[] labWorks;
        int numberLabWorks;
        int[] homeWorks;
        int numberHomeWorks;
        int project;
        int activity;        
        int extraPoints;
        int sumPoints;

        //конструктори
        public Points3(int[] labWorks, int numberLabWorks, int[] homeWorks, int numberHomeWorks, int project, int activity, int extraPoints)
        {
            this.labWorks = labWorks;
            this.numberLabWorks = numberLabWorks;
            this.homeWorks = homeWorks;
            this.numberHomeWorks = numberHomeWorks;
            this.project = project;
            this.activity = activity;            
            this.extraPoints = extraPoints;
        }
        public Points3()
        {
            Console.WriteLine("Пустий журнал оцінок створений");
        }
        public Points3(int numberLabWorks, int numberHomeWorks)
        {
            this.numberHomeWorks = numberHomeWorks;
            this.numberLabWorks = numberLabWorks;
            labWorks = new int[numberLabWorks];
            homeWorks = new int[numberHomeWorks];
        }

        //властивості
        public int NumberLabWorks
        {
            get { return numberLabWorks; }
            set
            {
                if (value > 0)
                    numberLabWorks = value;
                else
                    Console.WriteLine("Число має бути більше 0!");
            }
        }
        public int NumberHomeWorks
        {
            get { return numberHomeWorks; }
            set
            {
                if (value > 0)
                    numberHomeWorks = value;
                else
                    Console.WriteLine("Число має бути більше 0!");
            }
        }
        public int Project
        {
            get { return project; }
            set
            {
                if (value >= 0)
                    project = value;
                else
                    Console.WriteLine("Число має бути більше 0!");
            }
        }
        public int Activity
        {
            get { return activity; }
            set
            {
                if (value >= 0)
                    activity = value;
                else
                    Console.WriteLine("Число має бути більше 0!");
            }
        }
        
        public int ExtraPoints
        {
            get { return extraPoints; }
            set
            {
                if (value >= 0)
                    extraPoints = value;
                else
                    Console.WriteLine("Число має бути більше 0!");
            }
        }
        public int SumPoints
        {
            get { return sumPoints; }
            set
            {
                if (value >= 0)
                    sumPoints = value;
                else
                    Console.WriteLine("Число має бути більше 0!");
            }
        }
        public int[] LabWorks
        {
            get { return labWorks; }
            set
            {
                for (int i = 0; i < numberLabWorks; i++)
                {
                    if (value[i] >= 0)
                        labWorks[i] = value[i];
                    else
                        labWorks[i] = 0;
                }
            }
        }
        public int[] HomeWorks
        {
            get { return homeWorks; }
            set
            {
                for (int i = 0; i < numberHomeWorks; i++)
                {
                    if (value[i] >= 0)
                        homeWorks[i] = value[i];
                    else
                        homeWorks[i] = 0;
                }
            }
        }


        public void randomMarks(Random element, int maxLabMark, int maxHomeWorkMark, int maxProjectMark, int maxActivity, int maxExtraPoints)
        {            
            project = element.Next(0, (maxProjectMark+1));
            activity = element.Next(0, (maxActivity+1));
            extraPoints = element.Next(0, (maxExtraPoints+1));
            for (int i = 0; i < numberLabWorks; i++)
            {
                labWorks[i] = new int();
                labWorks[i] = element.Next(0, (maxLabMark+1));                
            }
            for (int i = 0; i < numberHomeWorks; i++)
            {
                homeWorks[i] = new int();
                homeWorks[i] = element.Next(0, (maxHomeWorkMark+1));               
            }
            sumPoints = project + activity + extraPoints;
            for (int i = 0; i < numberLabWorks; i++)
            {
                sumPoints += labWorks[i];
            }
            for (int i = 0; i < numberHomeWorks; i++)
            {                
                sumPoints += homeWorks[i];
            }
        }

        public void printMarksStudent()
        {
            for (int i = 0; i < numberLabWorks; i++)
            {
                Console.Write(labWorks[i] + "\t");
            }
            for (int i = 0; i < numberHomeWorks; i++)
            {
                Console.Write(homeWorks[i] + "\t");
            }
            Console.WriteLine($"{activity}\t{project}\t{extraPoints}\t{sumPoints}");            
        }
        
        public void calculateSumPoints()
        {
            sumPoints = project + activity + extraPoints;
            for (int i = 0; i < numberLabWorks; i++)
            {
                sumPoints += labWorks[i];
            }
            for (int i = 0; i < numberHomeWorks; i++)
            {
                sumPoints += homeWorks[i];
            }
        }
    }
}
