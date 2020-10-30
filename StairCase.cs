using System;
using System.Collections.Generic;
using System.Text;

namespace MyLab.Training
{
    class StairCase
    {
        
        public StairCase()
        {

            DrawStairs(49);

        }
        public void DrawStairs(int n)
        {
            for (int i = 0; i < n; ++i)
            {
                int numbers = n - i - 1;

                for (int j = 0; j < n; ++j)
                {
                   
                    if (j < numbers) Console.Write(" ");
                    else Console.Write("#");
                }
                Console.WriteLine("");
            }
        }
    }

    
}
