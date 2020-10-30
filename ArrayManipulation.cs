using System;
using System.Collections.Generic;
using System.Text;

namespace MyLab.Training
{
    class ArrayManipulation
    {
        public ArrayManipulation()
        {   //we have params a,b which are intervals and k is the value to add in this index interval (fill)
            int[][] query = new int[3][];

            query[0] = new int[3];
            query[1] = new int[3];
            query[2] = new int[3];

            query[0] = new int[] { 1, 5, 3 };
            query[1] = new int[] { 4, 8, 7 };
            query[2] = new int[] { 6, 9, 1 };

            //int[,] data = new int[,] { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
            //MainFunction(5, query);
            longMainFunctionOptimised(10, query);

        }

        public void initMat(long[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                    data[i, j] = 0;
            }
        }


        public void longMainFunctionOptimised(long n, int[][] query)
        {
            long[] data = new long[n + 1];
            long max = 0;
            long sum = 0;
            for (int i = 0; i < query.Length; i++)
            {
                data[query[i][0]] += query[i][2];
                data[query[i][1] + 1] -= query[i][2];

            }
            for (int index = 0; index < data.Length; index++)
            {
                sum += data[index];
                if (sum > max) max = sum;
            }
            Console.WriteLine(max);

        }




        //BruteForce
        public long MainFunction(long n,int[][] query)
        {
            long[,] data = new long[query.Length,n];
            long max =0;
            for(int i = 0; i < data.GetLength(0); i++)
            {   

                for(int j = 0; j <data.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        if (j >= (query[i][0] - 1) && j < (query[i][1]))
                        {
                           data[i, j] += query[i][2];
                        }
                    }
                    else
                    {
                        if (j >= (query[i][0] - 1) && j < (query[i][1]))
                        {
                            data[i, j] = data[i, j] + data[i - 1, j] + query[i][2];
                        }
                        else
                        {
                            data[i, j] += data[i - 1, j];
                        }
                    }
                    if (data[i, j] >= max) max = data[i, j];

                }
               
            }
            U.Print("Max is:"+max);

            return max;
        }
    }
}


/*
 *                     if (i == 0) data[i, j] += query[i, 2];

                     if(j >= (query[i, 0] - 1) && j < (query[i, 1]))
                    {
                        data[i, j] = data[i, j] + data[i - 1, j] + query[i, 2];
                    }
                    else
                    {
                        data[i, j] += data[i - 1, j];
                    }
                    //test max
                    if (data[i, j] >= max) max = data[i, j];
 */
