using System;
using System.Diagnostics;

namespace Lab1ASD
{    
    public class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }

        public void Print()
        {
            Console.Write(data + " ");
            if (next != null)
            {
                next.Print();
            }
        }

        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }        
    }

    class Program
    {
        static int minimal, maximal;        

        static int search(Node head, int key)
        {
            int x = 0;            
            while (head != null)
            {
                x++;
                if (head.data == key)
                    return x;
                head = head.next;
            }
            return -1;
        }

        static int GetElement(Node head, int position)
        {
            for (int i = 0; i < position - 1; i++)
            {
                head = head.next;
            }
            return head.data;
        }

        static void Sort(Node clas)
        {
            //сортування списку
            int tmp;
            Node index = null;
            while (clas != null)
            {
                index = clas.next;
                while (index != null)
                {
                    if (clas.data > index.data)
                    {
                        tmp = clas.data;
                        clas.data = index.data;
                        index.data = tmp;
                    }
                    index = index.next;
                }
                clas = clas.next;
            }
        }

        static void LinkedListLinearSearch(Node head)
        {
            Console.WriteLine("==================================================");
            int size = 0, key = 0;
            Console.WriteLine("Linear search in linked list");
            Random element = new Random();
            Console.Write("Input number of elements of linked list: ");
            while (!Int32.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Input number of elements: ");
            }
            
            for (int i = 1; i < size; i++)
            {
                head.AddToEnd(element.Next(minimal, maximal));
            } 
            
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            Console.WriteLine("Linked list:");
            head.Print();            

            Console.Write("\nEnter number of key: ");
            while (!Int32.TryParse(Console.ReadLine(), out key))
            {
                Console.Write("Input number int format: ");
            }
            
            if (search(head, key) >= 0)
            {
                Console.WriteLine("Index of element = " + (search(head, key) - 1));
                sWatch.Stop();
                Console.WriteLine("Duration = " + sWatch.ElapsedMilliseconds + " ms");
            }
            else
            {
                Console.WriteLine("Not exist");
                sWatch.Stop();
                Console.WriteLine("Duration = " + sWatch.ElapsedMilliseconds + " ms");
            }            
        }

        static void LinkedListLinearSearchBarrier(Node head)
        {
            Console.WriteLine("==================================================");
            int size = 0, key = 0, x = 0;
            Console.WriteLine("Linear search in linked list with barier");
            Random element = new Random();
            Console.Write("Input number of elements of linked list: ");
            while (!Int32.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Input number of elements: ");
            }
                        
            for (int i = 1; i < size; i++)
            {
                head.AddToEnd(element.Next(minimal, maximal));
            } 
            
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            Console.WriteLine("Linked list:");
            head.Print();            

            Console.Write("\nEnter number of key: ");
            while (!Int32.TryParse(Console.ReadLine(), out key))
            {
                Console.Write("Input number int format: ");
            }
            
            head.AddToEnd(key); //додаємо число в кінець списку
            while (head.data != key)
            {
                head = head.next;
                x++;
            }
            sWatch.Stop();

            if (x != size)
            {
                Console.WriteLine("Index of element = " + (x));
                Console.WriteLine("Duration = " + sWatch.ElapsedMilliseconds + " ms");
            }
            else
            {
                Console.WriteLine("Not exist");
                Console.WriteLine("Duration = " + sWatch.ElapsedMilliseconds + " ms");
            }
        }        

        static void LinkedListBinarySearch(Node head)
        {
            Console.WriteLine("==================================================");
            int size = 0, key = 0;
            Console.WriteLine("Binary search in linked list");
            Random element = new Random();
            Console.Write("Input number of elements of linked list: ");
            while (!Int32.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Input number of elements: ");
            }

            for (int i = 1; i < size; i++)
            {
                head.AddToEnd(element.Next(minimal, maximal));
            }
                        
            Console.WriteLine("Linked list:");
            head.Print();
            Console.WriteLine();  

            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            Sort(head);            
            Console.WriteLine("Sorted linked list:");
            head.Print();            

            Console.Write("\nEnter number of key: ");
            while (!Int32.TryParse(Console.ReadLine(), out key))
            {
                Console.Write("Input number int format: ");
            }
            
            //бінарний пошук
            int center, right = size, left = 0;
            do
            {
                center = right - ((right - left) / 2);
                if (GetElement(head, center) < key) left = center + 1;
                else right = center - 1;
            } while ((left <= right) && (GetElement(head, center) != key));
            sWatch.Stop();

            if (GetElement(head, center) == key)
            {
                Console.WriteLine("Index of your element " + (center - 1));
                Console.WriteLine("Duration = " + sWatch.ElapsedMilliseconds + " ms");
            }
            else
            {
                Console.WriteLine("Key isn't included in array");
                Console.WriteLine("Duration = " + sWatch.ElapsedMilliseconds + " ms");
            }
        }

        static void LinkedListBinarySearchGoldenR(Node head)
        {
            Console.WriteLine("==================================================");
            int size = 0, key = 0;
            Console.WriteLine("Binary search in linked list");
            Random element = new Random();
            Console.Write("Input number of elements of linked list: ");
            while (!Int32.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Input number of elements: ");
            }

            for (int i = 1; i < size; i++)
            {
                head.AddToEnd(element.Next(minimal, maximal));
            }
                        
            Console.WriteLine("Linked list:");
            head.Print();
            Console.WriteLine(); 
            
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            Sort(head);            
            Console.WriteLine("Sorted linked list:");
            head.Print();            

            Console.Write("\nEnter number of key: ");
            while (!Int32.TryParse(Console.ReadLine(), out key))
            {
                Console.Write("Input number int format: ");
            }

            //бінарний пошук золотий перетин            
            int center, right = size, left = 0;
            do
            {
                center = Convert.ToInt32(right - ((right - left) / 1.618));
                if (GetElement(head, center) < key) left = center + 1;
                else right = center - 1;
            } while ((left <= right) && (GetElement(head, center) != key));
            sWatch.Stop();

            if (GetElement(head, center) == key)
            {
                Console.WriteLine("Index of your element " + (center - 1));
                Console.WriteLine("Duration = " + sWatch.ElapsedMilliseconds + " ms");
            }
            else
            {
                Console.WriteLine("Key isn't included in array");
                Console.WriteLine("Duration = " + sWatch.ElapsedMilliseconds + " ms");
            }
        }

        static void LinearSearch()
        {
            Console.WriteLine("==================================================");
            int size; //кількість елементів масиву 
            Console.WriteLine("Linear search");
            Console.Write("Input size of array: ");

            //перевірка змінної size
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Input array size: ");
            }

            //генерація випадкових елементів масиву
            int[] arr = new int[size];
            Random element = new Random();
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            Console.WriteLine("Elements of array:");            
            for (int i = 0; i < size; i++)
            {
                arr[i] = element.Next(minimal, maximal);
                Console.Write(arr[i] + " ");                
            }
            Console.WriteLine();          
                                 
            int key = 0, j = 0, index = 0;
            Console.Write("Enter key number: ");
            while (!int.TryParse(Console.ReadLine(), out key))
            {
                Console.Write("Input another key: ");
            }
            
            //алгоритм лінійного пошуку
            bool found = false;
            while (j < size && !found)
            {
                if (arr[j] == key)
                {
                    index = j;
                    found = true;
                }
                else j++;
            }
            sWatch.Stop(); 

            if (!found)
            {
                Console.WriteLine("Element not exist!");
                Console.WriteLine("Duration = " + sWatch.ElapsedMilliseconds + " ms");
            }
            else
            {
                Console.WriteLine("Element exist! Index = {0}", index);
                Console.WriteLine("Duration = " + sWatch.ElapsedMilliseconds + " ms");
            }
        }

        static void LinearBarrierSearch()
        {
            Console.WriteLine("==================================================");
            int size; //кількість елементів масиву 
            Console.WriteLine("Linear search with Barrier");
            Console.Write("Input size of array: ");

            //перевірка змінної size
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Input array size: ");
            }

            //генерація випадкових елементів масиву
            int[] arr = new int[size + 1];
            Random element = new Random(); 
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            Console.WriteLine("Elements of array:");           
            for (int i = 0; i < size; i++)
            {
                arr[i] = element.Next(minimal, maximal);  
                Console.Write(arr[i] + " ");              
            }
            Console.WriteLine();

            //вводимо шукане число і перевіряємо
            int key = 0, j = 0;
            Console.Write("Enter key number: ");
            while (!int.TryParse(Console.ReadLine(), out key))
            {
                Console.Write("Input another key: ");
            }
            
            //алгоритм лінійного пошуку з бар'єром
            arr[size] = key; //додаємо в кінець елемент масиву, який = шуканому
            while (arr[j] != key)
            {
                j++;
            }
            sWatch.Stop();

            if (j == size)
            {
                Console.WriteLine("Element not exist!");
                Console.WriteLine("Duration = " + sWatch.ElapsedMilliseconds + " ms");
            }
            else
            {
                Console.WriteLine("Element exist! Index = {0}", j);
                Console.WriteLine("Duration = " + sWatch.ElapsedMilliseconds + " ms");
            }
            
        }

        static void BinarySearch()
        {
            Console.WriteLine("==================================================");
            int size; //кількість елементів масиву 
            Console.WriteLine("Binary Search");
            Console.Write("Input size of array: ");

            //перевірка змінної size
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Input array size: ");
            }

            //генерація випадкових елементів масиву
            int[] arr = new int[size];
            Random element = new Random();  
            Console.WriteLine("Elements of array:");          
            for (int i = 0; i < size; i++)
            {
                arr[i] = element.Next(minimal, maximal);
                Console.Write(arr[i] + " ");                
            }
            Console.WriteLine();           

            //сортування масиву
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            Array.Sort(arr);

            //виведення відсортованого масиву            
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            
            //вводимо шукане число і перевіряємо
            int key = 0;
            Console.Write("Enter key number: ");
            while (!int.TryParse(Console.ReadLine(), out key))
            {
                Console.Write("Input another key: ");
            }
            
            //бінарний пошук
            int left = 0, right = size - 1, middle = 0;
            bool found = false;
            while (left <= right && !found)
            {
                middle = (left + right) / 2;
                if (arr[middle] == key) found = true;
                else if (arr[middle] > key) right = middle - 1;
                else left = middle + 1;
            }
            sWatch.Stop();

            if (!found)
            {
                Console.WriteLine("Element not exist!");
                Console.WriteLine("Duration = " + sWatch.ElapsedMilliseconds + " ms");
            }
            else 
            {
                Console.WriteLine("Element exist! Index = {0}", middle);
                Console.WriteLine("Duration = " + sWatch.ElapsedMilliseconds + " ms");
            }
            
        }

        static void BinarySearchGoldenRatio()
        {
            Console.WriteLine("==================================================");
            int size; //кількість елементів масиву 
            Console.WriteLine("Improved Binary Search");
            Console.Write("Input size of array: ");

            //перевірка змінної size
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Input array size: ");
            }

            //генерація випадкових елементів масиву
            int[] arr = new int[size];
            Random element = new Random();
            Console.WriteLine("Elements of array:");            
            for (int i = 0; i < size; i++)
            {
                arr[i] = element.Next(minimal, maximal);
                Console.Write(arr[i] + " ");                
            }
            Console.WriteLine();

            //сортування масиву
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            Array.Sort(arr);

            //виведення відсортованого масиву            
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();            

            //вводимо шукане число і перевіряємо
            int key = 0;
            Console.Write("Enter key number: ");
            while (!int.TryParse(Console.ReadLine(), out key))
            {
                Console.Write("Input another key: ");
            }

            //бінарний пошук удосконалений            
            int left = 0, right = size - 1, middle = 0;
            bool found = false;
            while (left < right && !found)
            {
                middle = Convert.ToInt32(right - (right - left) / 1.618);
                if (arr[middle] == key) found = true;
                else if (arr[middle] > key) right = middle - 1;
                else left = middle + 1;
            }
            sWatch.Stop();

            if (!found)
            {
                Console.WriteLine("Element not exist!");
                Console.WriteLine("Duration = " + sWatch.ElapsedMilliseconds + " ms");
            }
            else 
            {
                Console.WriteLine("Element exist! Index = {0}", middle);
                Console.WriteLine("Duration = " + sWatch.ElapsedMilliseconds + " ms");
            }            
        }

        static void Main()
        {
            Console.WriteLine("Lab 1 ASD. Maiboroda Igor IPZ-11");
            Console.Write("Choose your minimal value of array/list: ");
            while (!int.TryParse(Console.ReadLine(), out minimal))
            {
                Console.Write("Input minimal value: ");
            }
            Console.Write("Choose your maximal value of array/list: ");
            while (!int.TryParse(Console.ReadLine(), out maximal))
            {
                Console.Write("Input maximal value: ");
            }

            if (minimal >= maximal)
            {
                Console.WriteLine("Wrong values!");
            }
            else
            {                
                Menu();
            }
            
        }

        static void Menu()
        {
            int task = 5, choice = 0;
            Console.Write("Input 1 to work with array or 2 with Linked list (0 to stop): ");
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice < 0 && choice > 2))
            {
                Console.Write("Input 1 or 2 (0 to stop): ");
            }

            if (choice == 1)
            {
                Console.WriteLine("Work with array");
                Console.WriteLine("========================Menu==========================");
                Console.WriteLine("1. Linear Search\n2. Linear Search with Barrier\n3. Binary Search\n4. Improved Binary Search");

                while (task != 0)
                {
                    Console.Write("Input number of algorithm or 0 to stop: ");
                    while (!int.TryParse(Console.ReadLine(), out task) || (task < 0 && task > 4))
                    {
                        Console.Write("Input number of task: ");
                    }

                    switch (task)
                    {
                        case 1: LinearSearch(); break;
                        case 2: LinearBarrierSearch(); break;
                        case 3: BinarySearch(); break;
                        case 4: BinarySearchGoldenRatio(); break;
                    }
                }

                Menu();
            }
            else if(choice == 2)
            {
                Console.WriteLine("Work with linked list");
                Console.WriteLine("========================Menu==========================");
                Console.WriteLine("1. Linear Search\n2. Linear Search with Barrier\n3. Binary Search\n4. Binary Search Golden Ratio");

                while (task != 0)
                {
                    Console.Write("Input number of algorithm or 0 to stop: ");
                    while (!int.TryParse(Console.ReadLine(), out task) || (task < 0 && task > 4))
                    {
                        Console.Write("Input number of task: ");
                    }

                    Random elem = new Random();
                    Node myNode = new Node(elem.Next(-1000, 1000));
                    switch (task)
                    {
                        case 1: LinkedListLinearSearch(myNode); break;
                        case 2: LinkedListLinearSearchBarrier(myNode); break;
                        case 3: LinkedListBinarySearch(myNode); break;
                        case 4: LinkedListBinarySearchGoldenR(myNode); break;
                    }
                }

                Menu();
            }            
        }
    }
}
