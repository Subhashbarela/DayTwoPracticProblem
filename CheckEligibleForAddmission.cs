using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoCsharpBasicPracticProblem
{
    public class CheckEligibleForAddmission
    {
        public bool EligibleOrNot(int math,int physics,int chem)
        {
            
            if (math + physics + chem >= 180)
            {
                return true;
            }
            else if ((math + chem) >= 140)
            {
                return true;         
            }
            else if ((math + physics) >= 140)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
