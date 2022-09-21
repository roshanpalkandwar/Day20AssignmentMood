using Day20AssignmentMood;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
    }
}