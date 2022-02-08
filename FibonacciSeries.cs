using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class FibonacciSeries
    {
        static int[] values = new int[1000];
        public static int fibonacci(int n)
        {
            if (n == 1) return values[0];
            if (n == 2) return values[1];
            else
            {
                values[n - 1] = fibonacci(n - 1) + fibonacci(n - 2);
                return values[n - 1];
            }
        }
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());


            values[0] = 0;
            values[1] = 1;
            //console.write(values[0] + " " + values[1]);
            //for (int i = 2; i < n; ++i)v
            //    values[2] = values[0] + values[1];
            //console.writeline(values[3] + " ");
            //values[0] = values[1];
            //values[1] = values[2];
            Console.WriteLine(fibonacci(n));
            Console.ReadLine();
        }

    }
}
