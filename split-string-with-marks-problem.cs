using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class Solution 
    { 
       public int solution (string sentence)
       {
          int maxLength =0, wordLength = 0;
          string[] symbols = new string[] {"?",",","!", "."};
          
          foreach (string s in sentence.Split(symbols, StringSplitOptions.None))
          {
              wordLength= symbols.Split(' ').Count(word => word != String.Empty);
              maxLength = maxLength > wordLength  ? maxLength : wordLength;
          }
          return maxLength ;
       }
}
