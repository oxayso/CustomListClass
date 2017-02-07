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
        public object num1 { get; set; }
        public object num2 { get; set; }
        public object num3 { get; set; }
        public override string ToString()
        {
            //create the logic to stringify any object
            // StringBuilder
            num1 = "1";
            num2 = "2";
            num3 = "3";
            return num1 + ", " + num2 + ", " + num3;           
        }
        public CustomList()
        {
            myItems = new T[0];
            arrayCount = 0;
        }

        public void Add(T itemToAdd)
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



       //class OverloadAddOperator
       // {
       //     public int Num1 = 0;
       //     public string Str1 = "";

       //     class OverloadAddOperator1 : CustomList<int>
       //     {
       //         public static OverloadAddOperator operator +(OverloadAddOperator obj1, OverloadAddOperator obj2)
       //         {
       //             OverloadAddOperator obj3 = new OverloadAddOperator();
       //             obj3.Num1 = obj3.Num1 + obj2.Num1;
       //             obj3.Str1 = obj1.Str1 + obj2.Str1;
       //             return obj3;
       //         }

       //     }
        //}
      
    } 
}