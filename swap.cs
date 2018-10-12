using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class swap
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 4;
            int c;
            Console.WriteLine("before swaping a is:" + a + ",b is:" + b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("after swaping a is:" + a + ",b is:" + b);
            Console.Read();
        }
    }
}
