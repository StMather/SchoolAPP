using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Teacher : Person
    {
        
        public string subject { get; set; }

        public override float ComputeGradeAverage()
        {
            //TODO:fix implimentaion later
            return 0.0f;
        }
    }
}
