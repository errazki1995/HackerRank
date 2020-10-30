using System;
using System.Collections.Generic;
using System.Text;

namespace MyLab.Training
{
    class U
    {
       public U()
        {

        }
      public  static void Print(string msg)
        {
            Console.WriteLine(msg); 
        }

        public static void Display(int[,] data)
        {
            Print("-----Displaying the matrix----");
            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.Write("[");
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.Write("]");
                Print("");
            }
        }

        public static void DisplayLongArr(long[,] data)
        {
            Print("-----Displaying the matrix----");
            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.Write("[");
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.Write("]");
                Print("");
            }
        }
        public static void debugArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("");
        }
        public static void debugArray(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
