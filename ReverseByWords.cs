using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class ReverseByWords
    {
        static String reverseByWords(String str = "I Have To Go")
        {
            int i = str.Length - 1;
            int start, end = i + 1;
            String result = "";

            while (i >= 0)
            {
                if (str[i] == ' ')
                {
                    start = i + 1;
                    while (start != end)
                        result += str[start++];

                    result += ' ';

                    end = i;
                }
                i--;
            }

            start = 0;
            while (start != end)
                result += str[start++];

            return result;
        }


        static void Main(string[] args)
        {

            Console.WriteLine(reverseByWords());
            Console.ReadLine();
        }

    }
}
