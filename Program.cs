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
            SumOfSquare sqr=new SumOfSquare();
            Console.WriteLine("Please insert the number to find sum of square");
            int num =int.Parse(Console.ReadLine());
            sqr.SumOfSqr(num);
               
        }
    }
}
