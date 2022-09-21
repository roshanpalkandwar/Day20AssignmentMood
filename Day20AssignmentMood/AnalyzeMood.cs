using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20AssignmentMood
{
    public class AnalyzeMood
    {
        public string message;

        public AnalyzeMood(string message)
        {
            this.message = message;
        }

        public string Mood()
        {
            // message = message.ToLower();
            if (message.Contains("happy"))
                return "happy";
            else
                return "sad";
        }
    }
}
