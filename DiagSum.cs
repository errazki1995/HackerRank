using System;
using System.Collections.Generic;
using System.Text;

namespace MyLab.Training
{
    class DiagSum
    {
       public DiagSum()
        {
           /*
            * initializing and populating the lists
            */
          
            List<List<int>> arr = new List<List<int>>();
            int n = 3;
            List<int> row1 = new List<int>();
            List<int> row2 = new List<int>();
            List<int> row3 = new List<int>();
            row1.Add(1); row1.Add(2); row1.Add(2);
            row2.Add(2); row2.Add(3); row2.Add(4);
            row3.Add(19); row3.Add(19); row3.Add(3); //7-24 = 17...
            arr.Add(row1);
            arr.Add(row2);
            arr.Add(row3);
            Console.WriteLine(sumDiagonal(arr));

        }

        public int sumDiagonal(List<List<int>> arr)
        {
            int leftsum=0,rightsum = 0;
            int rightpos = arr.Count - 1;
            int finalResult = 0;
            for(int i = 0; i < arr.Count; ++i)
            {
                 leftsum+=arr[i][i];
                 rightsum += arr[i][rightpos];
                 --rightpos;
            }        
            finalResult = leftsum - rightsum;
            return Math.Abs(finalResult);
        }
    }
}
