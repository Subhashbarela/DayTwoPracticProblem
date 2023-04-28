using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoCsharpBasicPracticProblem
{
    public class SumOfSquare
    {
        public void SumOfSqr(int num)
        {
            int sum = 0;
            int sqr = 0;
            for (int i = 1; i <= num; i++)
            {
                sqr = i * i;
                Console.Write(sqr + " ");
                sum += sqr;
            }
            Console.WriteLine("\n Total sum of above Square is: " + sum);


        }
    }
}
