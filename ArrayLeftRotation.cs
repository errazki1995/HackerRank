using System;
using System.Collections.Generic;
using System.Text;

namespace MyLab.Training
{
    class ArrayLeftRotation
    {
        public ArrayLeftRotation()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original array");
            debugArray(a);
            ShiftArray(a, 2);
            Mehdi_shiftArray(a, 2);
        }
        static void debugArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("");
         }





        /*
         */
        static int[] rotLeftFirstVersion(int[] a, int d)
        {

            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {

                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }

            return a;
        }

        /*
         * Second Version 
         */


         int[] ShiftArray(int[] a, int shift)
        {
            int[] FinalArray = new int[a.Length];
            int firstCutIndex = 0;
            int secondCutIndex = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (secondCutIndex < shift)
                {
                    FinalArray[(a.Length - shift) + secondCutIndex] = a[i];
                    secondCutIndex++;
                }

                else if (i >= shift)
                {
                    FinalArray[firstCutIndex] = a[i];
                    firstCutIndex++;
                }
            }
            Console.WriteLine("mine");
            debugArray(FinalArray);

            return FinalArray;
        }


        int  [] Mehdi_shiftArray(int [] a,int shift)
        {
            
            for(int i = 0; i < shift; i++)
            {
                Array.Reverse(a, 0,a.Length);
                Array.Reverse(a, 0, a.Length - 1);
            }
            debugArray(a);
            return a;
        }


    }
}
