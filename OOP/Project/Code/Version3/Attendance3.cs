using System;
using System.Collections.Generic;

namespace Version3
{
    class Attendance3
    {
        int[] attendingLessons;
        int numberLessons;
        int sumAttendance;

        //конструктори
        public Attendance3(int numberLessons)
        {
            this.numberLessons = numberLessons;
            attendingLessons = new int[numberLessons];
        }
        public Attendance3()
        {
            Console.WriteLine("Пустий облік відвідування створений");
        }
        public Attendance3(int numberLessons, int[] attendingLessons)
        {
            this.numberLessons = numberLessons;
            this.attendingLessons = attendingLessons;
        }

        //властивості
        public int NumberLessons
        {
            get { return numberLessons; }
            set
            {
                if (value > 0)
                    numberLessons = value;
                else
                    Console.WriteLine("Кількість занять має бути більше 0!");
            }
        }
        public int[] AttendingLessons
        {
            get { return attendingLessons; }
            set
            {
                for (int i = 0; i < numberLessons; i++)
                {
                    if (value[i] == 0 || value[i] == 1)
                        attendingLessons[i] = value[i];
                    else
                        attendingLessons[i] = 0;
                }
            }
        }

        public void randomAttending(Random element)
        {            
            for (int i = 0; i < numberLessons; i++)
            {
                attendingLessons[i] = new int();
                attendingLessons[i] = element.Next(0, 2);
                sumAttendance += attendingLessons[i];
            }
            for (int i = 0; i < numberLessons; i++)
            {                
                sumAttendance += attendingLessons[i];
            }
        }

        public void printAttendingStudent(int semester)
        {
            if (semester == 1)
            {
                int check = numberLessons / 4;
                for (int i = 0; i < numberLessons; i++)
                {
                    if (i % check == 0 && i != (4 * (numberLessons / 4)))
                    {
                        Console.Write("|| ");
                        Console.Write(attendingLessons[i] + "  ");                        
                    }
                    else
                    {
                        Console.Write(attendingLessons[i] + "  ");
                    }
                    
                }
                Console.WriteLine();
            }
            else
            {
                int check = numberLessons / 5;
                for (int i = 0; i < numberLessons; i++)
                {
                    if (i % check == 0 && i != (5 * (numberLessons / 5)))
                    {
                        Console.Write("|| ");
                        Console.Write(attendingLessons[i] + "  ");
                    }
                    else
                    {
                        Console.Write(attendingLessons[i] + "  ");
                    }

                }
                Console.WriteLine();
            }
            
        }                

        public void calculateAttending()
        {
            sumAttendance = 0;
            for (int i = 0; i < numberLessons; i++)
            {
                sumAttendance += attendingLessons[i];
            }
        }
    }
}
