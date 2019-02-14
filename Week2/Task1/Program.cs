using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class Program
    {
        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\PP2\Week2\test1.txt");
            System.Console.WriteLine(text);
            string[] lines = System.IO.File.ReadAllLines(@"C:\PP2\Week2\test1.txt");
            string word = lines[0];
            string reversed = Reverse(word);
            if (word == reversed)
            {
                Console.WriteLine("Yes");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No");
                Console.ReadKey();
            }


        }

    }
}

