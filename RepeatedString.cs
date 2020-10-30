using System;
using System.Collections.Generic;
using System.Text;

namespace MyLab.Training
{
    class RepeatedString
    {
        public RepeatedString()
        {
            long c = repeatedStringZ("aba", 10);
            Console.WriteLine(c);
        }

        public long countA(string input)
        {
            long vcountA = 0;
            for (long i = 0; i < input.Length; i++)
            {
                if (input[(int)i].Equals('a')) vcountA++;
            }
            return vcountA;
        }
        public long repeatedStringZ(string input,long n)
        {
            long cA = countA(input);
            long res = cA * (n/input.Length);
            long res_rest = n % input.Length;

            if (res_rest == 0)
            {
                 return res;
            }
            else
            {
                for (int i = 0; i < res_rest; i++)
                {
                    if (input[i].Equals('a')) res++;
                }
             }
           return res;

        }


    }
}
