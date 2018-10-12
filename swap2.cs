using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class swap2
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 6;
            Console.WriteLine("before swaping a and b is:" + a + "," + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("after swaping a and b is:" + a + "," + b);
         
        }
    }
}
