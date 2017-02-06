using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable
    {
        public int arrayCount;
        public T[] myItems;
        public object value1 { get; set; }
        public object value2 { get; set; }
        public override string ToString()
        {
            return "Override String: " + value1 + " , " + value2;
        }

        public CustomList()
        {
            myItems = new T[0];
            arrayCount = 0;

            OverloadAddOperator obj1 = new OverloadAddOperator();
            obj1.Num1 = 10;
            obj1.Str1 = "OPERATOR";

            OverloadAddOperator obj2 = new OverloadAddOperator();
            obj2.Num1 = 10;
            obj2.Str1 = "OVERLOAD!";

            OverloadAddOperator obj3 = new OverloadAddOperator();

            obj3 = obj1 + obj2;

        }

        public void CustomAdd(T itemToAdd)
        {
            if(arrayCount >= myItems.Length)
            {
                T[] increasedTempArray = new T[myItems.Length + 4];
                for (int i = 0; i < myItems.Length; i++)
                {
                    increasedTempArray[i] = myItems[i];
                }
                myItems = increasedTempArray;
            }
            myItems[arrayCount] = itemToAdd;
            arrayCount++;
        }


        public void CustomRemove(T itemToRemove)
        {
            if(myItems.Length < arrayCount)
            {
                T[] removeTempArray = new T[myItems.Length - 4];
                for (int i = 0; i < myItems.Length; i--)
                {
                    removeTempArray[i] = myItems[i];
                }
                myItems = removeTempArray;
                }
                myItems[arrayCount] = itemToRemove;
            arrayCount--;
        }

       public IEnumerator GetEnumerator() //myiteration
        {
            for (int i = 0; i < myItems.Length; i++)
            {
                yield return myItems[i];
            }
        }

        //public static void Main(string[] args)
        //{
        //    OverloadAddOperator obj1 = new OverloadAddOperator();
        //    obj1.Num1 = 10;
        //    obj1.Str1 = "OPERATOR";

        //    OverloadAddOperator obj2 = new OverloadAddOperator();
        //    obj2.Num1 = 10;
        //    obj2.Str1 = "OVERLOAD!";

        //    OverloadAddOperator obj3 = new OverloadAddOperator();

        //    obj3 = obj1 + obj2;
        //}

        public class OverloadAddOperator
        {
            public int Num1 = 0;
            public string Str1 = "";

            public static OverloadAddOperator operator +(OverloadAddOperator obj1, OverloadAddOperator obj2)
            {
                OverloadAddOperator obj3 = new OverloadAddOperator();
                obj3.Num1 = obj3.Num1 + obj2.Num1;
                obj3.Str1 = obj1.Str1 + obj2.Str1;
                return  obj3;
            }
        }
    }
}


//{
//increasedTempArray[i] = arrayItems[i];
//}
//increasedTempArray[arrayItems.Length] = itemToAdd;
//arrayItems = increasedTempArray;
//arrayCount++; 