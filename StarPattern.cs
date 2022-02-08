using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class StarPattern
    {
        public static void star()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }       
        static void Main(string[] args)
        {
            
            star();
            
            Console.ReadLine();
        }
    }
}
