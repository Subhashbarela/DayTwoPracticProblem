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
            FactOfGivenRange fact = new FactOfGivenRange();
            Console.WriteLine("Please insert the range to find fact :");
            int num=int.Parse(Console.ReadLine());
            fact.FactOfGivenRange_Method(num);

            FactOfGivenNumber number= new FactOfGivenNumber();
            Console.WriteLine("Please insert the number to find fact :");
            int num2 = int.Parse(Console.ReadLine());
            number.FactorialOfGivenNumber(num2);
            Console.ReadLine();
        }
    }
}
