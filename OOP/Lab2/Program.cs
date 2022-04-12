using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Lab2
{
    class Program
    {
        static void MenuList()
        {
            Console.WriteLine("==================== Menu ======================");
            Int32 task = 10;
            while (task != 0)
            {
                Console.WriteLine("Task 1: work with array\nTask 6: work with matrix\nTask 8: work with equation\nTask 9: work with string");
                Console.Write("Choose a number of task (input 0 to stop): ");
                while (!Int32.TryParse(Console.ReadLine(), out task) || (task != 0 && task != 1 && task != 6 && task != 8 && task != 9))
                {
                    Console.Write("Enter numbers 0, 1, 6, 8 or 9: ");
                }
                switch (task)
                {
                    case 0: break;
                    case 1: FirstTask(); break;                    
                    case 6: SixthTask(); break;                    
                    case 8: EighthTask(); break;
                    case 9: NinthTask(); break;
                }
            }
        }

        static void FirstTask()
        {
            Int32 size, minimal, maximal;
            Console.WriteLine("Task 1");

            Console.Write("Input number of elements of array: ");            
            while (!Int32.TryParse(Console.ReadLine(), out size) || (size <= 0 ))
            {
                Console.Write("Input number of elements: ");
            }

            Console.Write("Input minimal value: ");           
            while (!Int32.TryParse(Console.ReadLine(), out minimal))
            {
                Console.Write("Input minimal value: ");
            }

            Console.Write("Input maximal value: ");            
            while (!Int32.TryParse(Console.ReadLine(), out maximal))
            {
                Console.Write("Input maximal value: ");
            }

            if (minimal >= maximal)
            {
                Console.WriteLine("Not correct min and max values!");
                FirstTask();
            }

            int[] arr = new int[size];
            Random element = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = element.Next(minimal, maximal);
            }

            Console.WriteLine("Your array of numbers: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            //сортування Шелла
            int k, j, step;
            int temp;
            for (step = size / 2; step > 0; step /= 2)
            {
                for (k = step; k < size; k++)
                {
                    temp = arr[k];
                    for (j = k; j >= step; j -= step)
                    {
                        if (temp < arr[j - step]) 
                            arr[j] = arr[j - step];
                        else 
                            break;
                    }
                    arr[j] = temp;
                }
            }

            //виведення відсортованого масиву
            Console.WriteLine("Sorted array of numbers: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            //вибір наступного завдання
            Int32 choice;
            Console.Write("Input 0 to back to menu or 1 to continue work with array: ");
            while (!Int32.TryParse(Console.ReadLine(), out choice) || (choice != 0 && choice != 1))
            {
                Console.Write("Input only 0 or 1: ");
            }

            if (choice == 0) MenuList();
            else
            {
                choice = 10;
                while (choice != 0)
                {
                    Console.Write("Input number of task (2, 3, 4, or 5) or 0 to back to menu: ");
                    while (!Int32.TryParse(Console.ReadLine(), out choice) || (choice < 0 || choice > 5 || choice == 1)) 
                    {
                        Console.Write("Input only 0, 2, 3, 4 or 5: ");
                    }
                    switch (choice)
                    {
                        case 2: SecondTask(arr, size); break;
                        case 3: ThirdTask(arr, size); break;
                        case 4: FourthTask(arr, size); break;
                        case 5: FifthTask(arr, size); break;
                    }
                }
                MenuList();
            }          
        }

        static void SecondTask(int []arr, int size)
        {
            Int32 minimal, maximal;            
            Console.WriteLine("Task 2");

            Console.Write("Input minimal value of diapason: ");
            while (!Int32.TryParse(Console.ReadLine(), out minimal))
            {
                Console.Write("Input minimal value: ");
            }

            Console.Write("Input maximal value of diapason: ");
            while (!Int32.TryParse(Console.ReadLine(), out maximal))
            {
                Console.Write("Input maximal value: ");
            }

            if (minimal >= maximal)
            {
                Console.WriteLine("Not correct min and max values!");
                SecondTask(arr, size);
            }

            //перевірка введеного діапазону чисел            
            if (minimal < arr[0] || maximal > arr[size - 1])
            {
                Console.WriteLine("Not correct range!");
                SecondTask(arr, size);
            }
            else if (maximal <= 0 && minimal < 0)
            {
                Console.WriteLine("Range of negative numbers!\nThere are no prime numbers");
                SecondTask(arr, size);
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
                SecondTask(arr, size);
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
            } else Console.WriteLine();
            
        }

        static void ThirdTask(int[] arr, int size)
        {
            bool positive = false, zero = true;
            int temp = 0, sensor = 0;

            Console.WriteLine("Task 3");      

            //перестановка елементів масиву
            for (int i = 1; i < size; i++)
            {
                sensor = i;
                for (int k = i + 1; k < size; k++)
                {                    
                    if (!positive && zero)
                    {
                        if (arr[k] > 0)
                        {
                            temp = arr[i];
                            arr[i] = arr[k];
                            arr[k] = temp;
                            positive = true;
                            zero = false;                            
                            break;
                        }
                    } 
                    else if (positive && zero)
                    {
                        if (arr[k] < 0)
                        {
                            temp = arr[i];
                            arr[i] = arr[k];
                            arr[k] = temp;
                            positive = false;
                            zero = true;
                            break;
                        }
                    }
                    else if (!zero)
                    {
                        sensor++;
                        if (arr[k] == 0)
                        {
                            temp = arr[i];
                            arr[i] = arr[k];
                            arr[k] = temp;
                            positive = true;
                            zero = true;                              
                            break;
                        }
                    }
                }

                if (!zero && sensor == size - 1)
                {
                    zero = true;
                    positive = true;
                    i--;
                }
            }

            //виведення масиву
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void FourthTask(int[] arr, int size)
        {
            Console.WriteLine("Task 4");
            int minValue = arr[size - 1], maxValue = arr[0];
            int indexMin = 0, indexMax = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] > 0 && arr[i] < minValue)
                {
                    minValue = arr[i];
                    indexMin = i;
                }

                if (arr[i] < 0 && arr[i] > maxValue)
                {
                    maxValue = arr[i];
                    indexMax = i;
                }
            }

            if (arr[0] < 0 && arr[size - 1] <= 0)
            {
                Console.WriteLine("There are no positive numbers!");
                Console.WriteLine("Max value of negative: " + arr[size - 1]);
                Console.WriteLine("Index: " + (size - 1));
            } else if (arr[0] >= 0 && arr[size - 1] > 0)
            {
                Console.WriteLine("There are no negative numbers!");
                Console.WriteLine("Min value of positive: " + arr[0]);
                Console.WriteLine("Index: " + 0);
            }
            else
            {
                Console.WriteLine("Max value of negative: " + maxValue);
                Console.WriteLine("Index: " + indexMax);
                Console.WriteLine("Min value of positive: " + minValue);
                Console.WriteLine("Index: " + indexMin);
            }
            
        }

        static void FifthTask(int[] arr, int size)
        {
            Console.WriteLine("Task 5");
            int left, right, center = 0;
            int minimal, maximal, indexMin = 0, indexMax = 0;
            bool found = false;

            Console.Write("Input minimal value of diapason: ");
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
                Console.WriteLine("Not correct left and right values!");
                EighthTask();
            }

            //використання алгоритму бінарного пошуку
            //шукаємо мінімальне значення діапазону
            Console.WriteLine("Use algorithm Binary Search");
            left = 0; right = size;
            while (left < right && !found)
            {
                center = (right + left) / 2;
                if (minimal < arr[center]) right = center;
                else if (minimal > arr[center]) left = center + 1;
                else found = true;               
            }

            if (found) 
            {
                indexMin = center; 
                found = false;
            }
            else
            {
                Console.WriteLine("Minimal value don't exist in array!");
                FifthTask(arr, size);
            }

            //шукаємо максимальне значення діапазону
            left = 0; right = size;
            while (left < right && !found)
            {
                center = (right + left) / 2;
                if (maximal < arr[center]) right = center;
                else if (maximal > arr[center]) left = center + 1;
                else found = true; 
            }

            if (found)
            {
                indexMax = center;                
            }
            else
            {
                Console.WriteLine("Maximal value don't exist in array!");
                FifthTask(arr, size);
            }

            //виводимо результат
            Console.WriteLine("Number of elements: " + (indexMax - indexMin + 1));
            Console.Write("Elements: ");
            for (int i = indexMin; i < indexMax + 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            //використання методу BinarySearch класу Array 
            Console.WriteLine("Use method BinarySearch");
            if (Array.BinarySearch(arr, minimal) < 0 || Array.BinarySearch(arr, maximal) < 0)
            {
                Console.WriteLine("Minimal or maximal value don't exist in array!");
                FifthTask(arr, size);
            }

            indexMin = Array.BinarySearch(arr, minimal);
            indexMax = Array.BinarySearch(arr, maximal);

            //виводимо результат
            Console.WriteLine("Number of elements: " + (indexMax - indexMin + 1));
            Console.Write("Elements: ");
            for (int i = indexMin; i < indexMax + 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void SixthTask()
        {
            Console.WriteLine("Task 6");
            Int32 str, colum, minimal, maximal;            

            Console.Write("Input number of strings of matrix: ");
            while (!Int32.TryParse(Console.ReadLine(), out str) || (str <= 0))
            {
                Console.Write("Input number of strings: ");
            }

            Console.Write("Input number of columns of matrix: ");
            while (!Int32.TryParse(Console.ReadLine(), out colum) || (colum <= 0))
            {
                Console.Write("Input number of columns: ");
            }

            Console.Write("Input minimal value: ");
            while (!Int32.TryParse(Console.ReadLine(), out minimal))
            {
                Console.Write("Input minimal value: ");
            }

            Console.Write("Input maximal value: ");
            while (!Int32.TryParse(Console.ReadLine(), out maximal))
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

            Int32 choice;
            Console.Write("Input 0 to back to menu or 7 to go to task 7: ");
            while (!Int32.TryParse(Console.ReadLine(), out choice) || (choice != 0 && choice != 7))
            {
                Console.Write("Input only 0 or 7: ");
            }
            if (choice == 0)
            {
                MenuList();
            }
            else
            {
                SeventhTask(arr, str, colum);
                MenuList();
            }
        }

        static void SeventhTask(int [,]arr, int str, int colum)
        {
            //пошук мінімальних елементів
            int minimal = arr[0, 0], indexStr = 0, indexCol = 0;
            for (int i = 0; i < str; i++)
            {
                for (int k = 0; k < colum; k++)
                {
                    if (arr[i, k] < minimal)
                    {
                        minimal = arr[i, k];
                        indexStr = i; indexCol = k;
                    }
                }
            }
            Console.WriteLine("Minimal element = {0}, index: {1} and {3}", minimal, indexStr, indexCol);

            //видалення рядка
            for (int i = indexStr; i < str - 1; i++)
            {
                for (int k = 0; k < colum; k++)
                {
                    arr[i, k] = arr[    i + 1, k];
                }
            }

            //видалення стовпця
            for (int i = 0; i < str - 1; i++)
            {
                for (int k = indexCol; k < colum - 1; k++)
                {
                    arr[i, k] = arr[i, k + 1];
                }
            }

            
            //виведення нової матриці
            for (int i = 0; i < str - 1; i++)
            {
                for (int k = 0; k < colum - 1; k++)
                {
                    Console.Write(arr[i, k] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void EighthTask()    
        {
            Console.WriteLine("Task 8");
            double left, right;           

            Console.Write("Input minimal value of diapason: ");
            while (!double.TryParse(Console.ReadLine(), out left))
            {
                Console.Write("Input left value: ");
            }

            Console.Write("Input maximal value of diapason: ");
            while (!double.TryParse(Console.ReadLine(), out right))
            {
                Console.Write("Input right value: ");
            }

            if (left >= right)
            {
                Console.WriteLine("Not correct left and right values!");
                EighthTask();
            }
            
            double accuracy = 0.00001;
            double center = 0;            

            while (Math.Abs(right - left) > accuracy) //|right - left|>ε
            {
                center = (right + left) / 2; //розраховуємо значення середньої точки
                if ((Math.Pow((left * left - 5 * left + 7), 2) - (left - 2) * (left - 3)) * (Math.Pow((center * center - 5 * center + 7), 2) - (center - 2) * (center - 3)) < 0)
                {                               
                    right = center; //якщо //F(left)*F(center)<0, то праву межу інтервалу переносимо в середню точку 
                }
                else left = center; //в середню точку переносимо ліву межу
            }

            Console.WriteLine("Answer = " + center);
            Console.WriteLine("Let's check answer: " + (Math.Pow((center * center - 5 * center + 7), 2) - (center - 2) * (center - 3)));
            Console.WriteLine("The equation has no roots");
        }

        static void NinthTask()
        {
            int round = 0, square = 0, curly = 0;
            Console.WriteLine("Task 9");
            Console.Write("Input string with '()' '{}' '[]': ");
            string sentence = Console.ReadLine();

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

        static void Main() //головна функція
        {            
            Console.WriteLine("Lab 2. IPZ-11 Maiboroda Igor");
            MenuList();                                       
        }        
    }
}



