using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class Solution
    {
        static int solution(int[] array)
        {
            int[] newArray = new int[array.Length];
            Array.Copy(array, newArray, array.Length);

            Array.Sort(newArray);
            int result = 0, start = -1, end = 0;
            
            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] != array[i])
                    if (start == -1)
                    {
                        start = i;
                        end = (i + 1);
                    }
                    else
                    {
                        end = i;
                    }
            }
            
            if ((start >= 0) && (end >= 0))
            {
                result = ((end) - (start)) + 1;
            }

            return result;
        }
    }
}
