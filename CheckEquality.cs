﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoCsharpBasicPracticProblem
{
    public class CheckEquality
    {
        public void CheckEqualOrNot()
        {
            Console.WriteLine("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Two number are equal");
            }
            else
            {
                Console.WriteLine("Two number are not equal");
                Console.ReadLine();
            }
        }
    }
}
