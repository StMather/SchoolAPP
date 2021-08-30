using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class ScoreUtility
    {
        public static IScored bestOfTwo(IScored assigment1, IScored assigment2)
        {
            var score1 = assigment1.score / assigment1.maximumScore;
            var score2 = assigment2.score / assigment2.maximumScore;
            if(score1 > score2)
            {
                return assigment1;
            }else
            {
                return assigment2;
            }

        }
    }
}
