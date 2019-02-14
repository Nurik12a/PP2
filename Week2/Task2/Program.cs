using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static bool primeN(int x)
        {
            if (x <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            ;
            string s = System.IO.File.ReadAllText(@"C:\PP2\Week2\test2.txt");
            int[] arr = new int[s.Length / 2 + 1];
            arr = s.Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (primeN(arr[i]) == true)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\PP2\Week2\test3.txt", true))
                    {
                        file.Write(arr[i] + " ");
                    }
                }
            }
        }
    }
}