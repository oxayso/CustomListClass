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
        public void TestAdd()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            //Act
            custom.Add(3);
            //Assert
            Assert.AreEqual(custom.arrayCount, 1);
        }

        [TestMethod]

        public void TestRemove()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            custom.Add(3);
            //Act
            custom.Remove(3);
            //Assert
            Assert.AreEqual(custom.arrayCount, 0);
        }

        [TestMethod]
        public void TestGetEnumerator()
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

        [TestMethod]

        public void TestToString()
        {
            //Arrange
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("Testing ");
            builder.Append("One ");
            string actualResult = builder.ToString();
            //Act
            
            //Assert
            Assert.AreEqual(builder.ToString(), actualResult);
        }

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
