using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
     {
        private string message;
        public MoodAnalyserFactory(string message)
        {
            this.message = message;
        }
        public static object CreateMoodAnalyze(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
           
            if (result.Success)

            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyzeType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyzeType);

                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyzerCustomExceptions(MoodAnalyzerCustomExceptions.ExceptionType.NO_SUCH_CLASS, "Class Is Not Found");
                }
            }
            else
            {
                throw new MoodAnalyzerCustomExceptions(MoodAnalyzerCustomExceptions.ExceptionType.NO_SUCH_METHOD, "Constructor Is Not Found");
            }
        }
    }
}
