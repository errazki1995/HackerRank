using System;
using System.Collections.Generic;
using System.Text;

namespace MyLab.Training
{
    class Clouds
    {


        public Clouds()
        {
            //int[] clouds = new int[] { 0, 1, 0, 0, 1, 0 };    //should print 3
            //int[] clouds = new int[] { 0, 0, 1, 0, 0, 1, 0 }; //should print 4
            int[] clouds = new int[] { 0, 0, 0, 1, 0, 0 };      //shoud print 3
            Console.WriteLine(jumpingOnClouds(clouds));

        }

        void debugPath(int[] clouds, int actualindex, int path)
        {
            Console.WriteLine("Array :");
            for (int i = 0; i < clouds.Length; ++i)
            {
                Console.Write(clouds[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("the actual index is :" + actualindex + " and the path is" + path);
        }
        static int jumpingOnClouds(int[] clouds)
        {
            int count = 0;
            for (int i = 0; i < clouds.Length; ++i)
            {
                if (clouds[i] == 0)
                {
                    i = i + 1;
                }
                count++;
            }
            return count;
        }

        /*
       static int jumpingOnClouds(int[] clouds)
        {
            int[] cldouds = new int[] { 0, 0, 1, 0, 0, 1, 0 }; //should print 4

            int count = 0;
            for (int i = 0; i < clouds.Length - 2; ++i)
            {
                if (clouds[i + 1] == 0 && clouds[i + 2] == 0 || clouds[i + 1] == 1 && clouds[i + 2] == 0)
                {
                    i = i + 1;
                    count++;
                }
                else if (clouds[i + 1] == 0 && clouds[i + 2] == 1)
                {

                    count++;
                }


            }
            return count;
        }
        */
    }
}
