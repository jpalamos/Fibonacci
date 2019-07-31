using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1,n,temp=0;
            Console.WriteLine("Ingrese la cantidad");
            n = Convert.ToInt32(Console.ReadLine());
;           for(int i=0; i < n; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
                Console.WriteLine(a);
            }
            Convert.ToInt32(Console.ReadLine());
        }
    }
}
