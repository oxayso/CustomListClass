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
        //public bool itemToRemove;
        public object value1 { get; set; }
        public object value2 { get; set; }
        public override string ToString()
        {
            return value1 + "," + value2;
        }

        public CustomList()
        {
            myItems = new T[0];
            arrayCount = 0;
            //itemToRemove = true;
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
    }
}


//{
//increasedTempArray[i] = arrayItems[i];
//}
//increasedTempArray[arrayItems.Length] = itemToAdd;
//arrayItems = increasedTempArray;
//arrayCount++; 