using System;
using System.Collections.Generic;
using System.Text;

namespace MyLab.Training
{
    class Mini_Max_Sum
    {
        public Mini_Max_Sum()
        {
            int[] arr = new int[] {1,3,5,7,9 };
            //findMinMax(arr);
            miniMaxSum(arr);

        }
    
         void miniMaxSum(int[] arr)
        {
            int sumMin = 0;
            int sumMax = 0;
            Array.Sort(arr);
            for (int i = 0;i<arr.Length; ++i)
            {
                if (i < arr.Length-1) sumMin+=arr[i];
                if (i > 0 ) sumMax+=arr[i];
            }
            Console.WriteLine(sumMin + " " + sumMax);

        }

    }
}
