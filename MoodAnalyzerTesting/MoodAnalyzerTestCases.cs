using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyzerTesting
{
    [TestClass]
    public class MoodAnalyzerTestCases
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
    }
}
