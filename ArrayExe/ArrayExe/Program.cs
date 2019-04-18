using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");

            string[] name = new string[5];
            int i = 0;
            Console.WriteLine("Please Type five name.....");
            while (i < name.Length)
            {
                name[i] = Console.ReadLine();
                i++;
            }

            Console.WriteLine ("Hello, " + string.Join(",", name) + "!");

            Console.WriteLine("");
            Console.WriteLine("Task 2");

            int[] num = new int[10] { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };
            
            Console.WriteLine("Result: " + string.Join("+", num) + " = " + num.Sum());
            Console.ReadKey();

        }
    }
}
