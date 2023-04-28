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
            FindNumberOfTable table = new FindNumberOfTable();
            table.TableOfNum();
            //find square on given table
            table.FindSquar();
            Console.ReadLine();
        }
    }
}
