using System;
using System.Collections.Generic;
using System.Text;

namespace MyLab.Training
{
    class SalesByMatchHackerrank
    {
        int[] socksColors = { 1, 2, 2, 3, 4, 4, 1, 1, 2, 3, 3 };
        Dictionary<int, int> pairSocks = new Dictionary<int, int>();

        void initSockDict()
        {
            for(int i = 0; i < socksColors.Length; ++i)
            {
                if (!pairSocks.ContainsKey(socksColors[i])) pairSocks.Add(socksColors[i], 0);
            }
        }
        void OrganizeSockPairs()
        {
            for(int i = 0; i < socksColors.Length; ++i)
            {
                int value;
                if(pairSocks.TryGetValue(socksColors[i],out value))
                {
                    pairSocks[socksColors[i]] = value + 1;
                }
            }
        }
        
        int PairCount()
        {
            int result = 0;
            foreach(KeyValuePair<int,int> kvp in pairSocks)
            {
                if (kvp.Value % 2 != 0) { result += ((kvp.Value - 1) / 2); }
                else result += (kvp.Value / 2);
            }
            return result;
        }
        void debugTheHashMap()
        {
            foreach(KeyValuePair<int,int> kvp in pairSocks)
            {
                Console.WriteLine("Sock Color :{0} count {1}", kvp.Key, kvp.Value);
            }
        }

        public SalesByMatchHackerrank()
        {
            Console.WriteLine("initialising the hashmap");
            initSockDict();
            Console.WriteLine("Output: ");
            debugTheHashMap();
            Console.WriteLine("Organising pairs");
            OrganizeSockPairs();
            debugTheHashMap();
            Console.WriteLine("The result is:" + PairCount());
        }

        

    }
}
