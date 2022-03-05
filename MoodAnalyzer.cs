using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyzer
    {
        public string AnalyzeMood(string moodMessage)
        {
            if (moodMessage.ToLower().Contains("SAD"))
            {
                return "SAD";

            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
