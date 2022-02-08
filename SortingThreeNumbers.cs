using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class SortingThreeNumbers
    {

        static void sortThreeNumbers()
        {
            Console.WriteLine("Enter the A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the C");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a >= b && a >= c)
            {
                if (b >= c)
                {
                    Console.WriteLine($"Sorting order: {a},{b},{c}");
                }
                else
                    Console.WriteLine($"Sorting order: {b},{c},{a}");
            }
            else if (b >= a && b >= c)
            {
                if (a >= c)
                {
                    Console.WriteLine($"Sorting order: {c},{a},{b}");
                }
                else
                    Console.WriteLine($"Sorting order: {a},{c},{b}");
            }
            else if (c >= a && c >= b)
            {
                if (a >= b)
                {
                    Console.WriteLine($"Sorting order: {b},{a},{c}");
                }
                else
                    Console.WriteLine($"Sorting order: {a},{b},{c}");
            }
        }
        static void Main(string[] args)
        {
            sortThreeNumbers();
            Console.ReadLine();
        }

    }
}
