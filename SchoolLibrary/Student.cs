using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public enum gradeLevels { Freshman, Sophomore, Junior, Senior }
        public gradeLevels gradeLevel { get; set; }

        public override float ComputeGradeAverage()
        {
            //TODO: fix implimentaion later
            return 4.0f;
        }
        public override string SendMessage(string message)
        {
            var original = base.SendMessage(message);
            var sb = new StringBuilder(original);
            sb.AppendLine("This message is private and confidential.");
            return sb.ToString();
        }
    }
}
