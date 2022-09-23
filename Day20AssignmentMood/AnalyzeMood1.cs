using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20AssignmentMood
{
    public class MoodAnalyserCustomException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_MESSAGE,
            NULL_MESSAGE,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD,
            NO_SUCH_CONSTRUCTOR
        }
        public readonly ExceptionType type;
        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }

    public class AnalyzeMood1
    {
        private string message;
        public AnalyzeMood1(string message)
        {
            this.message = message;
        }
        public AnalyzeMood1()
        {
            Console.WriteLine("Default Constructor");
        }
        public string AnalyseMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (message.ToUpper().Contains("SAD"))
                {
                    Console.WriteLine("Your current mood is: Sad Mood");
                    return "Sad Mood";
                }
                else
                {
                    Console.WriteLine("Your current mood is: Happy Mood");
                    return "Happy Mood";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Console.WriteLine(exception.Message);
                return exception.Message;
            }

        }

    }
}
