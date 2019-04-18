using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListEXE
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int Rnum1 = random.Next(0, 100);
            int Rnum2 = random.Next(0, 100);
            int Rnum3 = random.Next(0, 100);
            int Rnum4 = random.Next(0, 100);
            int Rnum5 = random.Next(0, 100);


            List<int> num = new List<int>();
            num.Add(Rnum1);
            num.Add(Rnum2);
            num.Add(Rnum3);
            num.Add(Rnum4);
            num.Add(Rnum5);
            Console.WriteLine("We already have " + string.Join(", " , num) + " Type Another number" );
            num.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Result is : " + string.Join(" + " , num) + " = " + num.Sum());


            Console.ReadLine();
        }
    }
}
