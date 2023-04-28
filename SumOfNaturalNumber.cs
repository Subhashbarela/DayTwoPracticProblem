using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoCsharpBasicPracticProblem
{
    public class SumOfNaturalNumber
    {
        public void SumOfN_NaturalNumberMethod()
        {

            Console.WriteLine("Please insert the number to find sum");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while (temp > 0)
            {
                Console.Write("{0}+",temp);
                sum += temp;
                temp--;
            }
            Console.WriteLine("\nsum of {0} natural number is: {1}", num, sum);
            Console.ReadLine();

        }
    }
}
