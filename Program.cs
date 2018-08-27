using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a>b)
            {
                int c = b;
                b = a;
                a = c;
            }
            for (int i = a+1; i <b; i++)
            {
                int sum = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        sum += 1;
                    }
                }
                if (sum==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
