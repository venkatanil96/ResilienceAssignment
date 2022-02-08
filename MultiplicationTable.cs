using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class MultiplicationTable
    {
        static void Main()
        {
            Console.WriteLine("Enter the Number:");
            int Tno = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(Tno + " X " + i + " = " + Tno * i);
                i++;
            }
        }
    }
}
