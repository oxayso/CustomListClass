using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTEST
{
    [TestClass]
    public class UnitTest1
    {
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
            //Act
            custom.CustomRemove(1);
            //Assert
            Assert.AreEqual(custom.arrayCount, null);
        }

    }
}
