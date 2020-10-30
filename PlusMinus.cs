using System;
using System.Collections.Generic;
using System.Text;

namespace MyLab.Training
{
    class PlusMinus
    {
        public PlusMinus()
        {
            int[] arr = new int[] { 1, 1, 0, -1, -1 };
            plusMinusO(arr);

        }

        void plusMinusO(int[] arr)
        {
            decimal posratio  = 0;
            decimal minratio  = 0;
            decimal zeroratio = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] == 0) zeroratio++;
                else if (arr[i] < 0) minratio++;
                else posratio++;
            }
            decimal total = (decimal)arr.Length;
            decimal resmin  =  minratio / total;
            decimal reszero =  zeroratio / total;
            decimal resmax = posratio / total;
            Console.WriteLine(resmax.ToString("N6"));
            Console.WriteLine(resmin.ToString("N6"));
            Console.WriteLine(reszero.ToString("N6"));
           

        }
    }
}
