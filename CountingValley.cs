using System;
using System.Collections.Generic;
using System.Text;

namespace MyLab.Training
{
    class CountingValley
    {
        public CountingValley()
        {
            string valley = "UDDDUDUU";
            int level = 0;
            int nbvalleys = 0;
            for (int i = 0; i < valley.Length; ++i)
            {
                if (valley[i].Equals('U')) level++;
                else level--;

                if (valley[i].Equals('U') && level == 0) nbvalleys++;
            }
            Console.WriteLine("Valleys number is:" + nbvalleys);
        }
    }
}
