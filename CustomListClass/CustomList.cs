using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable
    {
        public int count;
        public T[] myItems;
        public CustomList()
        {
            myItems = new T[0];
            count = 0;
        }
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            {
                builder.Append("Testing ");
                builder.Append("One ");
                builder.Append("Two ");
                builder.Append("Three \n\n");

                for (int i = 0; i < 10; i++)
                {
                    builder.Append("10 times ");
                }

                string actualResult = builder.ToString();
                return actualResult;
            }
        }

        public void Add(T itemToAdd)
        {
            if(count >= myItems.Length)
            {
                T[] increasedTempArray = new T[myItems.Length * 2 + 1];
                for (int i = 0; i < myItems.Length; i++)
                {
                    increasedTempArray[i] = myItems[i];
                }
                myItems = increasedTempArray;
            }
            myItems[count] = itemToAdd;
            count++;
        }

        public void Remove(T itemToRemove)
        {
            bool itemFound = false;
            for (int i = 0; i < count; i++)
            {
                if (myItems[i].Equals (itemToRemove))
                {
                    itemFound = true;
                }
                if (itemFound)
                {
                    myItems[i] = myItems[i + 1];
                }
            }     
        }

       public IEnumerator GetEnumerator() //myiteration
        {
            for (int i = 0; i < count; i++)
            {
                yield return myItems[i];
            }
        }

        //public class OverloadAddOperator
        //{
        //    class OverloadAdd
        //    {
        //        CustomList<int> result;
        //        CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
        //        CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6 };

        //        public static OverloadAdd operator +(OverloadAdd listOne, OverloadAdd listTwo)
        //        {
        //            OverloadAdd result;
        //            result = listOne + listTwo;
        //            return result;
        //        }
            //}
     }           
 }
