using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20AssignmentMood
{
    public class MoodAnalyzer
    {
        public string message;

        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public string Mood()
        {
            try
            {
                if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                return "happy";
            }
        }
    }
}
