using System;
using System.Collections.Generic;

namespace Version2
{
    class Program2
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;            
            Console.WriteLine("Майборода Ігор Сергійович ІПЗ-11");
            Console.WriteLine("Проект №46. Версія 2");
            Console.WriteLine("Старт імітації");
            Console.WriteLine(new string('=', 60));

            Points2 []marks = new Points2[25];
            marks[0] = new Points2(5, 3);
            marks[1] = new Points2(5, 3);

            Attendance2 []attending = new Attendance2[25];
            attending[0] = new Attendance2(30);
            attending[1] = new Attendance2(30);

            Group2 IPZ11 = new Group2("ФІТ", "ІПЗ", 1, "ІПЗ-11", 25);
            IPZ11[0] = new Student2(marks[0], attending[0], "Igor");
            IPZ11[1] = new Student2(marks[1], attending[1], "Oleg");

            Student2 student1 = new Student2();
            Student2 student2 = new Student2("Stepan", 55, 38);

            Group2 IPZ12 = new Group2(IPZ11);
            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Фініш імітації");
        }
    }
}
