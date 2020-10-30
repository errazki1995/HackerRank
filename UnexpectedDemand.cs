using System;
using System.Collections.Generic;
using System.Text;

namespace MyLab.Training
{
    class UnexpectedDemand
    {
        public UnexpectedDemand()
        {
            int[] orders = new int[] { 10, 30 };
            
        }
        int filledOrders(int[] order,int stockAvailable)
        {
            int canfulfill = 0;
            for (int i = 0; i < order.Length; i++)
            {
                if (order[i] <= stockAvailable)
                {
                    canfulfill++;
                    stockAvailable--;
                }
            }
            return canfulfill;
        }
    }
}
