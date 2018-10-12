using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class polindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int i = int.Parse(Console.ReadLine());
            int reverse = 0;
            int l = i;
            while(!(i==0))
            {
                int k = i % 10;
                reverse=(reverse*10) +k;
                i=i / 10;
            }
            if(l==reverse)
            {
                Console.WriteLine("given number is polindrome");

            }
            else
            {
                Console.WriteLine("given number is not polindrome");
            }
        }
    }
}
