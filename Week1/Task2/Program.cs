using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Nursultan = new Student("Nursultan","18BD110447");
            Nursultan.year = 1;
            Nursultan.Info();
        }
    }
    class Student 
{
        public string name;
        public string id;
        public int year;
        public Student(string n, string i)
{
            name = n;
            id = i;
}
        public void Info() 
{
            year++;
            Console.WriteLine($"{name}-{id}-{year}");
            Console.ReadKey();
}
}
}
