using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int i=int.Parse(Console.ReadLine());
            int reverse = 0;
            Console.WriteLine("given number:" + i);
            while(!(i == 0)) 
            {
                int k = i % 10;
                reverse=(reverse*10) +k;
                i = i / 10;
            }
            Console.WriteLine("reverse numbers is:"+reverse);
        }
    }
}
