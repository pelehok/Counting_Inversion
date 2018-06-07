using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Inversion
{
    class Brute_Force_algoritm
    {
        public long CountInv(List<int> inputList)
        {
            long res = 0;
            for(int i = 0; i < inputList.Count; i++)
            {
                for(int j = i+1; j < inputList.Count; j++)
                {
                    if (inputList[i] > inputList[j])
                    {
                        res++;
                    }
                }
            }
            return res;
        }
    }
}
