using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class AvgOfPosAndNeg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 Numbers");

            float[] a = new float[10];
            float SumOfPos = 0.0f;
            float SumOfNeg = 0.0f;
            int CountPos = 0;
            int CountNeg = 0;


            for (int i = 0; i < a.Length; i++)
            {

                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                    SumOfNeg = SumOfNeg + a[i];
                CountNeg++;

            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0)
                    SumOfPos = SumOfPos + a[i];
                CountPos++;
            }
            Console.WriteLine("Avg of Negative is : " + SumOfNeg / CountNeg);
            Console.WriteLine("Avg of Positive is : " + SumOfPos / CountPos);
            Console.ReadLine();
        }
    }
}
