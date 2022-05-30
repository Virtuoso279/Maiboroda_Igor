using System;
using System.Collections.Generic;

namespace Version2
{
    class Attendance2
    {
        int[] attendingLessons;
        int numberLessons;        

        //конструктори
        public Attendance2(int numberLessons)
        {
            this.numberLessons = numberLessons;
            attendingLessons = new int[numberLessons];                        
        }
        public Attendance2()
        {
            Console.WriteLine("Пустий облік відвідування створений");
        }
        public Attendance2(int numberLessons, int[] attendingLessons)
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
            
        }

        public void printAttendingStudent()
        {
            for (int i = 0; i < numberLessons; i++)
            {
                Console.Write(attendingLessons[i] + " ");
            }
            Console.WriteLine();
        }

        public void changeAttending()
        {

        }
    }
}
