using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class fibonancci
    {
        static void Main(string[] args)
        {
            int f1 = 1;
            int f2= 1;
            Console.Write(f1 + "," + f2 +",");
            for(int i=2;i<=10;i++)
            {
               int f3 = f1 + f2;
                Console.Write(f3+ ",");
                f1 = f2;
                f2 = f3;
            }
        }
    }
}
