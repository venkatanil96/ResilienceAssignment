using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Trignometry
    {
        static int fact(int x)
        {
            int i, fact = 1;
            for (i = 1; i <= x; i++)
                fact = fact * i;
            return fact;
        }
        static float power(float num, int expo)
        {
            float result = 1;
            while (expo != 0)
            {
                result *= num;
                --expo;
            }
            return result;
        }
        static void Main(string[] args)
        {
            float x, Q, sum = 0;
            int i, j, limited;

            Console.WriteLine("Enter value of x : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the limit upto which u want to expand : ");
            limited = Convert.ToInt32(Console.ReadLine());
            Q = x;
            x = (float)(x * (3.1415 / 180));

            for (i = 1, j = 1; i <= limited; i++, j = j + 2)
            {
                if (i % 2 != 0)
                {
                    sum = sum + power(x, j) / fact(j);
                }
                else
                    sum = sum - power(x, j) / fact(j);
            }

            Console.WriteLine("Sign of x value is : " + Q + ", " + sum);
            Console.ReadLine();
        }

    }
}
