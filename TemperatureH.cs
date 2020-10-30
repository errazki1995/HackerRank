using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyLab.Training
{
    class TemperatureH
    {

        public TemperatureH()
        {
            double[,] temperatures = GenerateData(10, 10);
            Display(temperatures);
            //int v = ExcellentThermometerCount(temperatures, 0.8);
            //Console.WriteLine(v);
            //AverageTemperatures(temperatures);
            //AveragesSorted(temperatures);
            Console.WriteLine("--------------Faulty-----------");
            U.debugArray(FaultyMeasurements(temperatures));
        }
        public double GenerateValue(double min, double max, Random r)
        {
            //var n = (r.NextDouble() * (max - min)) + max;
            var n = r.NextDouble() * (max - min + 0.1) + min;
            return n;
        }
        public double DoubleIt(double v)
        {
            return Convert.ToDouble(v.ToString("N2"));
        }

        public double[,] GenerateData(int numOfThermometers, int numOfMeasurements)
        {
            double[,] therms = new double[numOfThermometers, numOfMeasurements];
            Random random = new Random();

            for (int i = 0; i < numOfThermometers; i++)
            {
                int okchance = (int)GenerateValue(1, 10, random);

                if (okchance == 1)
                {
                    for (int j = 0; j < numOfMeasurements; j++) therms[i, j] = DoubleIt(GenerateValue(0.0, 255, random));
                }
                else
                    for (int j = 0; j < numOfMeasurements; j++)
                    {
                        double measureValue = DoubleIt(GenerateValue(36, 38, random));
                        therms[i, j] = measureValue;

                    }
            }
            return therms;
        }

        public void Display(double[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.Write("Device " + (i + 1) + " |");
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

        public double[] AverageTemperatures(double[,] data)
        {
            double[] averages = new double[data.GetLength(1)];

            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.WriteLine("average temperature of Device " + (i + 1) + ":");
                double sum = 0.0;
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    sum += data[i, j];
                }
                //Console.WriteLine(sum);
                averages[i] = sum / data.GetLength(1);
                Console.Write(DoubleIt(averages[i]));
                Console.WriteLine("");
            }
            return averages;
        }

        public int ExcellentThermometerCount(double[,] data, double range)
        {
            double r0 = 37.0;
            int excellent = 0;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                bool Isrange = true;

                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (!((DoubleIt(data[i, j]) >= (DoubleIt(r0 - range)) && DoubleIt(data[i, j]) <= (DoubleIt(r0 + range)))))
                    {
                        Isrange = false;
                        break;
                    }
                }
                if (Isrange) excellent++;
            }
            return excellent;
        }

        public double[] AveragesSorted(double[,] data)
        {
            double[] arr = AverageTemperatures(data);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] >= arr[j])
                    {
                        double tv = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tv;
                    }
                }



            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + " ");

            }


            return arr;
        }

        public int GetFaultyMeasurementCount(double[,] data, double r0)
        {
            int counter = 0;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (data[i, j] >= r0 + 1 || data[i, j] <= r0 - 1) counter++;
                }
            }
            return counter;
        }
        public double[] FaultyMeasurements(double[,] data)
        {
            double r0 = 37.0;
            int index = 0;
            int countMeasure = GetFaultyMeasurementCount(data, r0);
            double[] faulty = new double[countMeasure];

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (data[i, j] >= r0 + 1 || data[i, j] <= r0 - 1)
                    {
                        faulty[index] = data[i, j];
                        index++;
                    }
                }
            }
            return faulty;
        }

    }
}
