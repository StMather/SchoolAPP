using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class EnglishPaper
    {
        public string title { get; set; }
        public int MinimumWordCount { get; set; }
        public string paperText { get; set; }
        public int wordCount
        {
            get { return paperText.WordCount(); }
        }
    }
}
