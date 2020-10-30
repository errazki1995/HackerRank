using System;
using System.Collections.Generic;
using System.Text;

namespace MyLab.Training
{
    class BirthdayCakesCandles
    {
        public BirthdayCakesCandles()
        {
            List<int> candles = new List<int>();
            candles.Add(4); candles.Add(1); candles.Add(4); candles.Add(3);
            BirthDayCandleProcess(candles);

        }

        public void debugDict(Dictionary<int,int> dic)
        {
            foreach(KeyValuePair<int,int> kvp in dic)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
        public int BirthDayCandleProcess(List<int> candles)
        {
            Dictionary<int, int> candlesDic = new Dictionary<int, int>();
            int max = 0;
            for (int i = 0; i < candles.Count; ++i)
            {
                if (candles[i] > max) max = candles[i];

                if (candlesDic.ContainsKey(candles[i]))
                {
                    int candlesUnit;
                    if (candlesDic.TryGetValue(candles[i], out candlesUnit))
                    {
                        candlesDic[candles[i]] = candlesUnit + 1;
                    }
                }
                else candlesDic.Add(candles[i], 1);
            }
            
            return candlesDic[max];
        }

    }
}
