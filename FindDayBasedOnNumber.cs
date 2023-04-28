using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoCsharpBasicPracticProblem
{
    public class FindDayBasedOnNumber
    {
        public void WeekDays()
        {
            Console.WriteLine("Please insert the number as u want to print Day");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    {
                        Console.WriteLine("Today is Sunday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Today is Monday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Today is Tuesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Today is Wednesday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Today is Thursday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Today is Friday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Today is Saturday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine(" user insert invalid number of day");
                        break;
                    }
            }
        }
    }
}
