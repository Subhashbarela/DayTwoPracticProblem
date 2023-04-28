using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoCsharpBasicPracticProblem
{
    public class ReverseString
    {
        public string ReverseStringMethod(string str)
        {

            string reverse = "";

            int length = str.Length - 1;

            while (length >= 0)
            {
                reverse = reverse + str[length];
                length--;
            }
            return reverse;

        }
    }
}
