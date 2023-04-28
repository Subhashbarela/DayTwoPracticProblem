using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoCsharpBasicPracticProblem
{
    public class ArithmaticOperation
    {
        public void Mani_ArithmaticOp()
        {
            Console.WriteLine("Please insert the num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the choice  \n1:Additon  \n2:Subtraction \n3:Multiplication \n4:Division");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        int res = num1 + num2;
                        Console.WriteLine("addition Of two nummber is : " + res);
                        break;
                    }
                case 2:
                    {
                        int res = num1 - num2;
                        Console.WriteLine("Substraction Of two nummber is : " + res);
                        break;
                    }
                case 3:
                    {
                        int res = num1 * num2;
                        Console.WriteLine("Multiplication Of two nummber is : " + res);
                        break;
                    }
                case 4:
                    {
                        int res = num1 / num2;
                        Console.WriteLine("Division Of two nummber is : " + res);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You insert invalid number ");
                        break;
                    }

            }
        }
    }
}
