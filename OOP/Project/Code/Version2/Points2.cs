using System;
using System.Collections.Generic;

namespace Version2
{
    class Points2
    {
        int[] labWorks;
        int numberLabWorks;
        int[] homeWorks;
        int numberHomeWorks;
        int project;
        int activity;
        int exam;
        int extraPoints;

        //конструктори
        public Points2(int[] labWorks, int numberLabWorks, int[] homeWorks, int numberHomeWorks, int project, int activity, int exam, int extraPoints)
        {
            this.labWorks = labWorks;
            this.numberLabWorks = numberLabWorks;
            this.homeWorks = homeWorks;
            this.numberHomeWorks = numberHomeWorks;
            this.project = project;
            this.activity = activity;
            this.exam = exam;
            this.extraPoints = extraPoints;
        }
        public Points2()
        {
            Console.WriteLine("Пустий журнал оцінок створений");
        }
        public Points2(int numberLabWorks, int numberHomeWorks)
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
        public int Exam
        {
            get { return exam; }
            set
            {
                if (value >= 0 && value <= 40)
                    exam = value;
                else
                    Console.WriteLine("Число має бути більше 0 та менше 40!");
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


        public void randomMarks(Random element)
        {
            
        }

        public void printMarksStudent()
        {
            
        }              

        public void changePointsStudent()
        {

        }
    }
}
