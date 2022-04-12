using System;

namespace Lab3
{
    public static class StartupProject
    {        
        public static int size;         //task 2
        public static int str;          //task 6
        public static int colum;        //task 6
        public static string sentence;  //task 9

        public static void SecondTask(Random point)
        {
            int minimal, maximal;
            int[] arr = new int[size];
            Console.WriteLine("Your array: ");
            for (int i = 0; i < StartupProject.size; i++)
            {
                arr[i] = point.Next(-50, 50);
                Console.Write(arr[i] + " ");
            }           
            Console.WriteLine("\nSorted array: ");
            Array.Sort(arr);
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Write("\nInput minimal value of diapason: ");
            while (!int.TryParse(Console.ReadLine(), out minimal))
            {
                Console.Write("Input minimal value: ");
            }
            Console.Write("Input maximal value of diapason: ");
            while (!int.TryParse(Console.ReadLine(), out maximal))
            {
                Console.Write("Input maximal value: ");
            }
            if (minimal >= maximal)
            {
                Console.WriteLine("Not correct min and max values!");
                SecondTask(point);
            }

            //перевірка введеного діапазону чисел            
            if (minimal < arr[0] || maximal > arr[size - 1])
            {
                Console.WriteLine("Not correct range!");
                SecondTask(point);
            }
            else if (maximal <= 0 && minimal < 0)
            {
                Console.WriteLine("Range of negative numbers!\nThere are no prime numbers");
                SecondTask(point);
            }
            else if (maximal > 0 && minimal < 0)
            {
                for (int l = 0; l < size; l++)
                {
                    if (arr[l] >= 0)
                    {
                        minimal = arr[l];
                        break;
                    }
                }
            }

            //перевірка належності границь діапазону до масиву
            if (Array.IndexOf(arr, minimal) == -1 || Array.IndexOf(arr, maximal) == -1)
            {
                Console.WriteLine("Not correct range!");
                SecondTask(point);
            }

            //пошук простих чисел в масиві
            bool primeExist = false;
            Console.Write("Prime numbers: ");
            for (int i = Array.IndexOf(arr, minimal); i < Array.IndexOf(arr, maximal) + 1; i++)
            {
                for (int j = 2; j <= arr[i] / 2; j++)
                {
                    if (arr[i] % j == 0 && arr[i] != j)
                    {
                        arr[i] = 0;
                        break;
                    }
                }
                if (arr[i] != 0)
                {
                    primeExist = true;
                    Console.Write(arr[i] + " ");
                }
            }

            if (!primeExist)
            {
                Console.WriteLine("There are no prime numbers");
            }
            else Console.WriteLine();
        }      

        public static void SixthTask()
        {            
            int minimal, maximal;   
            Console.Write("Input minimal value: ");
            while (!int.TryParse(Console.ReadLine(), out minimal))
            {
                Console.Write("Input minimal value: ");
            }

            Console.Write("Input maximal value: ");
            while (!int.TryParse(Console.ReadLine(), out maximal))
            {
                Console.Write("Input maximal value: ");
            }

            if (minimal >= maximal)
            {
                Console.WriteLine("Not correct min and max values!");
                SixthTask();
            }

            int[,] arr = new int[str, colum];
            int[] sum = new int[str];
            int sumString = 0, sumAll = 0, index = 0;
            Random element = new Random();
            Console.WriteLine("Your matrix: ");
            for (int i = 0; i < str; i++)
            {
                for (int k = 0; k < colum; k++)
                {
                    arr[i, k] = element.Next(minimal, maximal);
                    Console.Write(arr[i, k] + "\t");
                    sumString += arr[i, k];
                    sumAll += arr[i, k];
                }
                Console.WriteLine();
                sum[i] = sumString;
                sumString = 0;
            }

            sumString = sum[0];
            for (int i = 0; i < str; i++)
            {
                Console.WriteLine("Profit from {0} product = {1}", i, sum[i]);
                if (sum[i] > sumString)
                {
                    sumString = sum[i];
                    index = i;
                }
            }

            Console.WriteLine("Total profit: " + sumAll);
            Console.WriteLine("The largest profit from {0} product: {1}", index, sumString);            
        }        

        public static void NinthTask()
        {
            int round = 0, square = 0, curly = 0;           
            //пошук дужок в рядку
            for (int i = 0; i < sentence.Length; i++)
            {
                switch (sentence[i])
                {
                    case '(': round++; break;
                    case ')': round--; break;
                    case '[': square++; break;
                    case ']': square--; break;
                    case '{': curly++; break;
                    case '}': curly--; break;
                }
            }

            if (round == 0 && square == 0 && curly == 0)
            {
                Console.WriteLine("Correct sequence");
            }
            else Console.WriteLine("Not correct sequence");
        }
                
    }
}
