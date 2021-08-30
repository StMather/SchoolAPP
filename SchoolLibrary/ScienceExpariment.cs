using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class ScienceExpariment : IScored
    {
        public string hypothesis { get; set; }
        public string material { get; set; }
        public string method { get; set; }
        public string conclustion { get; set; }
        public float score { get; set; }
        public float maximumScore { get; set; }
    }
}
