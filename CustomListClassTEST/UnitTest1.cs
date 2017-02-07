using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTEST
{
    [TestClass]
    public class UnitTest1
        
    {
        public int number;
        public int myValue;

        [TestMethod]
        public void TestCustomAdd()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            //Act
            custom.Add(3);
            //Assert
            Assert.AreEqual(custom.arrayCount, 1);
        }

        [TestMethod]

        public void TestCustomRemove()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            custom.Add(3);
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
            number.Add(2);
            //Act
            foreach (int num in number)
            {
                Console.WriteLine($"Number in CustomArray:{num}");
            }
            //Assert
            Assert.AreEqual(number.arrayCount, 1);
        }

        ///[TestMethod]

        //public void TestOverrideToStringConversion()
        //{
        //    //Arrange
        //    CustomList<int> number = new CustomList<int>();
        //    number.Add(1);
        //    number.Add(2);
        //    number.Add(3);
        //    //string actualResult;
        //    //Act

        //    //Assert
        //    Assert.AreEqual(number.ToString(), actualResult);
        //}

        //[TestMethod]

        //public void TestOperatorAddOverload()
        //{
        //    //Arrange
        //    CustomList<int> addOperator = new CustomList<int>();
        //    //Act

        //    //Assert
       
        //}
       
    }
}
