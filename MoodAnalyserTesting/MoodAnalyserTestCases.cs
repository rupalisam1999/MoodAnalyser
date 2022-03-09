using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyserTesting
{
    [TestClass]
    public class MoodAnalyserTestCases
    {
        [TestMethod]
        public void GivenNullMood_WhenAnalyzeMood_ShouldReturn_HAPPY()
        {
            // Arrange
            string moodMessage = null;
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string expected = "HAPPY";
            //Act
            string actual = moodAnalyzer.AnalyzeMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //[TC-4.1]:Given MoodAnalyzer class name should return MoodAnalyzer Object

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
           
            object expected = new MoodAnalyzer();
            object obj = MoodAnalyserFactory.CreateMoodAnalyze("MoodAnalyser.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }

        //[TC-4.2]:Given  class name when improper should throw  MoodanAlisysExceotion

        [TestMethod]

        public void GivenClassName_WhenImproper_ShouldThrowMoodAnalysisException() 
        {
            string expected = "Class Not Found";
            try
            {
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
                object obj = MoodAnalyserFactory.CreateMoodAnalyze("MoodAnalyser.MoodAnalyzer", "MoodAnalyzer");
            }
            catch (MoodAnalyzerCustomExceptions ex)
            {
                Assert.Equals(expected, ex.Message);
            }
        }
         //[TC-4.3]: Given class constructor not proper should throw MoodAnalysisException

        [TestMethod]
        public void GivenClass_WhenConstructorNotProper_ShouldThrow_MoodAnalysisException()
        {
            string expected = "Constructor Not Found";
            try
            {
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
                object obj = MoodAnalyserFactory.CreateMoodAnalyze("MoodAnalyser.MoodAnalyzer", "MoodAnalyzer");
            }
            catch (MoodAnalyzerCustomExceptions ex)
            {
                Assert.Equals(expected, ex.Message);
            }
        }
    }
}
