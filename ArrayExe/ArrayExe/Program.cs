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

            int[] num = new int[15];
            num[0] = 34;
            num[1] = 5;
            num[2] = 67;
            num[3] = 1;
            num[4] = 99;
            num[5] = 34;
            num[6] = 44;
            num[7] = 78;
            num[8] = 34;
            num[9] = 0;


            int ii = 10;
            Console.WriteLine("We already have  34, 5, 67, 1, 99, 34, 44, 78, 34, 0 ");
            Console.WriteLine("Type another five number ");
            while (ii < num.Length)
            {
                num[ii] = int.Parse(Console.ReadLine());
                ii++;
            }
            
            
            Console.WriteLine("Result: " + string.Join(" + ", num) + " = " + num.Sum());
            Console.ReadKey();

        }
    }
}
