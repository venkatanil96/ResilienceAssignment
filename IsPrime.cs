using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class IsPrime
    {
        static bool isPrimeNumber(int n)
        {
            if (n == 1)
            {
                return false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isPrimeNumber(n));
            
            Console.ReadLine();
        }
    }
}
