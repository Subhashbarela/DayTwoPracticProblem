using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoCsharpBasicPracticProblem
{
    public class FlipCoinProgram
    {
        public void PlayTheGameOfFlipCoin()
        {
            int Ram = 1;
            int Sham = 2;
            int tossTime = 20;
            Random random = new Random();
            while (tossTime > 0)
            {
                int check = random.Next(0, 3);

                if (check == 0)
                {
                    Ram++;
                }
                else
                {
                    Sham++;
                }
                tossTime--;
            }
            if (Ram > Sham)
            {
                Console.WriteLine("Ram Point is: {0} \n Sham Point is: {1} \n So Ram is winner: ", Ram, Sham);
            }
            else
            {
                Console.WriteLine("Sham Point is: {0} \n Ram Point is: {1} \n So Sham is winner: ", Sham, Ram);

            }
        }

    }
}
