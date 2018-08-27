using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int a = 1000;
            int b = 0;
                
            double d = 0;
            while (b < 5)
            { int sum = 0;
                for (int i = 2; i < a; i++)
                {


                    if (a%i==0)
                    {
                        sum += i;
                    }

                }
                if (sum==0)
                {
                    numbers[b] = a;
                   
                    b++;
                }a++;
                    
                    


            }
            for (int i = 0; i < 5; i++)
            {
                d += numbers[i];
            }
            Console.WriteLine(d / 5);
            Console.ReadKey();
                
        }
    }
}
