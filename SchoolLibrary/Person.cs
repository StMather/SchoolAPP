using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public abstract class Person
    {
        public string fitstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        public abstract float ComputeGradeAverage();

        public virtual string SendMessage(string message)
        {
            var sb = new StringBuilder();
            var timeStamp = string.Format("Sent on {0:D} at {0:t}", DateTime.Now);
            sb.AppendLine(timeStamp);
            sb.AppendLine();
            sb.AppendLine("Dear " + fitstName + ", ");
            sb.AppendLine(message);
            return sb.ToString();
        }
    }
    
}
