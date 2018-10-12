using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class M2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int i = int.Parse(Console.ReadLine());
            if(i%2==0)
            {
                Console.WriteLine("given number is even");
                Console.Read();
            }
            else
            {
                Console.WriteLine("given number is odd number");
                Console.Read();
            }
        }
    }
}
