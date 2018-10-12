using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class revString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string naresh = Console.ReadLine();
            char[] reddy = naresh.ToCharArray();
            string reverse = "";
            for(int i=reddy.Length-1;i>=0;i--)
            {
                reverse = reverse + reddy[i];
            }
            Console.WriteLine(reverse);
        }
    }
}
