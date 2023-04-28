using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoCsharpBasicPracticProblem
{
    public class EvenOddNumber
    {
        public bool CheckEvenOrOdd(int num)
        {
           
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
               return false;
            }
        }
    }
}
