using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace UnitTestMood
{
    [TestClass]
    public class OperationTest
    {
        /// <summary>
        /// Tests the method1.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string message;
            message = "I am in happy mood";
            string expected = "HAPPY";
            Operation obj = new Operation();

            //Act
            string actual = obj.MoodAnalyze(message);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string message;
            message = "I am in sad mood";
            string expected = "SAD";
                Operation obj1 = new Operation();

            //Act
            string actual = obj1.CheckMood(message);

            Assert.AreEqual (expected, actual);
        }
    }
}