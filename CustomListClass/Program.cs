﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass

{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            //testList.Remove(2);

            CustomList<int> testListTwo = new CustomList<int>();
            testListTwo.Add(5);
            testListTwo.Add(6);
            testListTwo.Add(7);
            testListTwo.Add(4);

            // ** commented out code in order to test different methods **

            CustomList<int> stringList = testList + testListTwo; // test for override ToString
            Console.WriteLine(stringList);

            CustomList<int> positiveList = testList + testListTwo; // test for overloading add operator
            Console.WriteLine($"\n{positiveList}");

            CustomList<int> negativeList = testList - testListTwo; // test for overloading minus operator
            Console.WriteLine(negativeList);

            Console.WriteLine(testList.Zipper(testListTwo)); //test for zipper

            Console.ReadKey();
        }
    }
}



