using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoCsharpBasicPracticProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            EvenOddNumber evenodd = new EvenOddNumber();
            Console.WriteLine("Enter the number to check even or odd: ");
            int num = int.Parse(Console.ReadLine());
            bool check = evenodd.CheckEvenOrOdd(num);
           
                if (check  == true)
                {
                    Console.WriteLine("  {0} is Even number: ", num);
                }
                else
                {
                    Console.WriteLine("  {0} is Odd number: ", num);
                    
                }
            Console.ReadLine();

        }
    }
}
