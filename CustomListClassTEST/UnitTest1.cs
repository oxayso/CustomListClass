using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            int expectedCount = 1;
            //Act
            custom.Add(6);
            //Assert
            Assert.AreEqual(custom.numberCount, expectedCount);
        }
    }
}
