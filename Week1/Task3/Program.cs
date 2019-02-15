using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static int[] doubleArray(int size,int[] mArray) //Create a method,with to parameters "size" and initial array ,that doubles an initial array and return new doubled array
        {
            int[] dArray = new int[size * 2 + 1]; //Create a new array with doubled size of initial array
            for (int i = 0; i < size; i++)
            {
                dArray[2*i + 1] = mArray[i]; //Each item with odd index is equal to the elements of the initial array
            }
            for(int i = 1; i <= size; i++)
            {
                dArray[2 * i] = dArray[2 * i - 1]; //Each item with even index is equal to the elements with odd index
            }
            return dArray;
        }

        static void Main(string[] args)
        {
            string x = Console.ReadLine(); //wait for the input
            int ss = int.Parse(x); //convert string to int
            int[] array = new int[ss]; //create an array
            string str = Console.ReadLine(); //wait for the input
            array = str.Split(' ').Select(int.Parse).ToArray(); //split string into array items

            int[] doubled = doubleArray(ss, array); //use the method
            for (int i = 1; i <= ss * 2; i++) //output a doubled array
            {
                Console.Write(doubled[i] + " ");
                
            }
            Console.ReadKey();
        }
    }
}
