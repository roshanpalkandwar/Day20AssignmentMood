using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day20AssignmentMood
{
    public class MoodAnalayzerFacotry1
    {
        public static object CreateMoodAnalyserObject(string className, string constructorName, string message)
        {
            string pattern = @"." + constructorName + "$";
            var result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(className);
                    object res;
                    if (message == null)
                    {
                        res = Activator.CreateInstance(moodAnalyserType, null);
                    }
                    else
                    {
                        res = Activator.CreateInstance(moodAnalyserType, message);
                    }
                    return res;
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "Exception: class not found");
                }
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CONSTRUCTOR, "Exception: constructor not found");
            }
        }
    }
}
