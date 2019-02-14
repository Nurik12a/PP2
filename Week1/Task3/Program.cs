using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse (Console.ReadLine()); // чтение размера массива
            int [] a = new int[n + 1]; // создал 1-индексированный массив, использует только + 1..a + n + 1
            for (int i = 1; i <= n; i++) {   // чтение массива целых чисел
                a[i] = int.Parse (Console.ReadLine()); 
            }
            for (int i = 1; i <= n; i++) {
                Console.Write (a[i].ToString() + " " + a[i].ToString() + " "); // преобразовать [i] в ​​строку и вывести их дважды с пробелами, разделенными

            }
        }

    }
}
