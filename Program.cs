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
            ReverseString reverse= new ReverseString();
            Console.WriteLine("Please insert the string to revers");
            string str=Console.ReadLine();
            string rev=reverse.ReverseStringMethod(str);
            Console.WriteLine("Original string is:" + str);
            Console.WriteLine("Reverse string is: "+rev);
            Console.ReadLine();
        }
    }
}
