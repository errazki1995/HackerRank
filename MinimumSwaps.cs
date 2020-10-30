using System;
using System.Collections.Generic;
using System.Text;

namespace MyLab.Training
{
    class MinimumSwaps
    {
        public MinimumSwaps()
        {
            //int[] a = new int[] { 4, 3, 1, 2 };
            //int[] a = new int[] { 2, 3, 4, 1,5 };
            int[] a = new int[] { 1, 3, 4, 2,5 };
            U.debugArray(a);
            U.debugArray(letsSwap(a));

        }

        public int findPosition(int value,int index,int[] a)
        {
            int pos = -1;
            for (int i = index; i < a.Length; i++)
            {
                if (a[i] == value)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }



        public int[] letsSwap(int[] a)
        {
            int counter = 0;
            for(int i = 0; i < a.Length; i++)
            {
                U.Print("Value:"+a[i]+" should be :"+(i+1));
            
                  if(a[i] !=i+1) {
                    int tmp = a[i];
                    int pos_to_swap_with = findPosition(i+1,i, a);

                    a[i] = a[pos_to_swap_with];
                    a[pos_to_swap_with] = tmp;

                    U.Print("Swapping :" + a[i] + " with: " + a[pos_to_swap_with]);
                    counter++;
                    


                   

                }

            }
            U.Print("Swapped: " + counter + " times");
            return a;
        }
    }
}
