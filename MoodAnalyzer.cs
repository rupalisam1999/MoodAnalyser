using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyzer
    {
        private string message;

        public MoodAnalyzer()
        {
        }

        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood(string moodMessage)
        {
            try
            {
                if (moodMessage == null)
                {
                    throw new NullReferenceException();
                }
                if (moodMessage.Equals(string.Empty))
                {
                    throw new MoodAnalyzerCustomExceptions((MoodAnalyzerCustomExceptions.ExceptionType)1, "Message Entered in Empty");
                }

                if (moodMessage.ToLower().Contains("SAD"))
                {
                    return "SAD";

                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        
    }
}