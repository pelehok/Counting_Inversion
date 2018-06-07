using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Inversion
{
    class Divide_And_Conquer
    {
        public int CountInvertion(List<int> inputList)
        {
            if(inputList.Count==0 || inputList.Count == 1)
            {
                return 0;
            }
            int leftInv = CountInvertion(inputList.GetRange(0, inputList.Count / 2));
            int rightInv = CountInvertion(inputList.GetRange(inputList.Count / 2+1, inputList.Count / 2-1));
            //int splitInv = CountSplitInv(inputList);
            return 0;
        }
    }
}
