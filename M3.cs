using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class M3
    {
        static void Main(string[] args)
        {
            int evenSum = 0;int oddSum = 0;
            for (int i = 1; i <=7; i++)
            {
                Console.WriteLine("enter number");
                int k = int.Parse(Console.ReadLine());
                if(k%2==0)
                {
                    evenSum = evenSum + k;
                }
                else
                {
                    oddSum = oddSum + k;
                }
            }
            Console.WriteLine("even sum is" + evenSum);
            Console.WriteLine("odd sum is " + oddSum);
            Console.Read();
        }
    }
}
