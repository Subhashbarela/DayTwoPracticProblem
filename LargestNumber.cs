using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoCsharpBasicPracticProblem
{
    public class LargestNumber
    {
        public void FindLargestNum()
        {
            Console.WriteLine("Please insert number One");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert number Two");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert number Three");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Number One is greater ");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Number Two is greater");
            }
            else
            {
                Console.WriteLine("Number Threee is greater");
            }
        }
    }
}
