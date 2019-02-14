using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool primeN(int x) //create a function
        {
            if (x <= 1) //if x is less or equals 1 then return "false"
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(x); i++) //start cycle from 2 to the square of the function parameter
            {
                if (x % i == 0) //check if x is divided by i;
                {
                    return false; //if "yes" return false, which means that the number is not prime
                }
            }
            return true; //leave the function, return "true", means that the number is Prime
        }
        static void Main(string[] args)
        {
            int cnt = 0; //initialize counter
            int size = Convert.ToInt32(Console.ReadLine()); //input the size of the array into "size" var-le
            int[] arr = new int[size]; //create array with size of "size"
            string s = Console.ReadLine(); //initialize array items with string type in one line
            arr = s.Split(' ').Select(int.Parse).ToArray(); //split the string untill the gap and push that values into the array
            for (int i = 0; i < arr.Length; i++)
            {
                if (primeN(arr[i]) == true) //if function returns true then the number is Prime, so incriment the counter value
                {
                    cnt++; 
                }
            }
            Console.WriteLine(cnt); //outup the number of the Prime numbers in the given array
            for (int i = 0; i < arr.Length; i++)
            {
                if (primeN(arr[i]) == true) //condition for printing out the prime numbers, algorithm is the same as in the previous conditional statement
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
