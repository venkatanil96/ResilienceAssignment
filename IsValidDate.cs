using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class IsValidDate
    {
        static bool isLeap(int year)
        {
            return (((year % 4 == 0) & (year % 100 != 0)) || (year % 400 == 0));
        }
        static bool isValidDate()
        {
            Console.WriteLine("Enter the Day");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Month");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year");
            int y = Convert.ToInt32(Console.ReadLine());

            if (m < 0 || m > 12)
                return false;
            if (d < 0 || d > 31)
                return false;
            if (m == 2)
            {
                if (isLeap(y))
                {
                    return (d <= 29);
                }
                else
                {
                    return (d <= 28);
                }
            }

            if (m == 4 || m == 6 || m == 9 || m == 11)
                return (d <= 30);

            return true;


        }


        static void Main(string[] args)
        {
            //isValidDate();

            if (isValidDate())
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();
        }
    }
}

