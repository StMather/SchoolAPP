using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class School
    {
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phoneNumber { get; set; }
        private string _twitterAddress;
        public string twitterAddress
        {
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("The Twitter address must begin with @");
                }
            }
        }
        public School()
        {
            name = "Untitled School";
            phoneNumber = "555-1234";
        }
        public School(string SchoolName, string SchoolPhoneNumber)
        {
            name = SchoolName;
            phoneNumber = SchoolPhoneNumber;
        }
        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}
        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;
        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(name);
            sb.AppendLine(address);
            sb.Append(city);
            sb.Append(", ");
            sb.Append(state);
            sb.Append("  ");
            sb.Append(zip);

            return sb.ToString();
        }
    }
}
