using System;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MoodAnalyzer moodAnalyser = new MoodAnalyzer();
            string result = moodAnalyser.AnalyzeMood("I am in SAD mood");
            Console.WriteLine(result);
        }
    }
}
