using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTEST
{
    [TestClass]
    public class UnitTest1
        
    {
        public int number; 

        [TestMethod]
        public void TestCustomAdd()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            //Act
            custom.CustomAdd(3);
            //Assert
            Assert.AreEqual(custom.arrayCount, 1);
        }

        [TestMethod]

        public void TestCustomRemove()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            custom.CustomAdd(3);
            //Act
            custom.CustomRemove(3);
            //Assert
            Assert.AreEqual(custom.arrayCount, 0);
        }

        [TestMethod]
        public void TestMyIteration()
        {
            //Arrange
            CustomList<int> number = new CustomList<int>();
            number.CustomAdd(2);
            //Act
            foreach (int num in number)
            {
                Console.WriteLine($"Number in CustomArray:{num}");
            }
            //Assert
            Assert.AreEqual(number.arrayCount, 1);
        }
    }
}
