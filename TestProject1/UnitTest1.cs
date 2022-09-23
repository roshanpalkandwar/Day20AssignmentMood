using Day20AssignmentMood;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //UC1
        [TestMethod]
        public void GivenMsgReturnHappy()
        {
            //arrange
            string msg = "I AM in happy mood";
            var expexted = "happy";

            //act
            AnalyzeMood analyzeMood = new AnalyzeMood(msg);
            var actual = analyzeMood.Mood();
            //Assert
            Assert.AreEqual(expexted, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        [TestCategory("SAD Mood")]
        public void GivenMessageShouldReturnSad()
        {

            AnalyzeMood mood = new AnalyzeMood("I am in SAD Mood");
            string excepted = "sad";
            var actual = mood.Mood();
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void GivenNull_ThrowCustomException()
        {
            try
            {
                //Arrange
                AnalyzeMood1 moodAnalyser = new AnalyzeMood1(null);
                //Act
                string actual = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserCustomException exception)
            {
                //Assert
                Assert.AreEqual("Mood should not be null", exception.Message);
            }
        }

       
        /// UC 3.2 : Given empty should throw moodAnalysis custom exception indicating empty mood
        
        [TestMethod]
        public void GivenEmpty_ThrowCustomException()
        {
            //Arrange
            AnalyzeMood1 moodAnalyser = new AnalyzeMood1("");
            string expected = "Mood should not be empty";
            //Act
            string actual = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
         [TestMethod]
        public void GivenImproperClassName_ShouldThrowMoodAnalysisException()
        {
            try
            {
                //Act
                object result = MoodAnalyzerFactory.CreateMoodAnalyserObject("MoodAnalyzerProblemDifferent.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalyserCustomException exception)
            {
                //Assert
                Assert.AreEqual("Exception: class not found", exception.Message);
            }
        }

        
        [TestMethod]
        public void GivenImproperConstructorName_ShouldThrowMoodAnalysisException()
        {
            try
            {
                //Act
                object result = MoodAnalyzerFactory.CreateMoodAnalyserObject("MoodAnalyzerProblem.MoodAnalyser", "MoodAnalyserDifferent");
            }
            catch (MoodAnalyserCustomException exception)
            {
                //Assert
                Assert.AreEqual("Exception: constructor not found in the class", exception.Message);
            }
        }
     
        [TestMethod]
        public void UC5GivenImproperClassName_ShouldThrowMoodAnalysisException()
        {
            try
            {
                //Act

                object result = MoodAnalayzerFacotry1.CreateMoodAnalyserObject("MoodAnalyzerProblemDifferent.MoodAnalyser", "MoodAnalyser", "happy");
            }
            catch (MoodAnalyserCustomException exception)
            {
                //Assert
                Assert.AreEqual("Exception: class not found", exception.Message);
            }
        }
        /// <summary>
        /// UC 5.3 : Given an improper constructor name should throw mood analysis exception.
        /// </summary>
        [TestMethod]
        public void UC5GivenImproperConstructorName_ShouldThrowMoodAnalysisException()
        {
            try
            {
                //Act

                object result = MoodAnalayzerFacotry1.CreateMoodAnalyserObject("MoodAnalyzerProblem.MoodAnalyser", "MoodAnalyserDifferent", "happy");
            }
            catch (MoodAnalyserCustomException exception)
            {
                //Assert

                Assert.AreEqual("Exception: constructor not found", exception.Message);
            }
        }
    }
}