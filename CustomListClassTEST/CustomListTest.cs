using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTEST
{
    [TestClass]
    public class CustomListTest
        
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
            Assert.AreEqual(custom.count, 1);
        }

        [TestMethod]

        public void TestRemove()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            //Act
            custom.Remove(2);
            //Assert
            Assert.AreEqual(custom.count, 0);
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
            Assert.AreEqual(number.count, 1);
        }

        [TestMethod]

        public void TestToString()
        {
            //Arrange
            CustomList<string> test = new CustomList<string>();
            string itemOne = "testing";
            string itemTwo = "one";
            test.Add(itemOne);
            test.Add(itemTwo);
            string actualResult = test.ToString();
            //Act
            
            //Assert
            Assert.AreEqual(test.ToString(), actualResult);
        }

        //[TestMethod]

        //public void TestOverloadAdd()
        //{
        //    //Arrange
        //    CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
        //    CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6 };
        //    //Act
        //    CustomList<int> result;
        //    result = listOne + listTwo;
        //    //Assert
        //    Assert.AreEqual(, result);
        //}

    }
}
