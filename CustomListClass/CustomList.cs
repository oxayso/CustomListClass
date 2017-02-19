using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable<T> 
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
            string myString = null;
            for (int i = 0; i < count; i++)
            {
                myString += myItems[i] + " ";
            }
            return myString;
        }

        public void Add(T itemToAdd)
        {
            if(count >= myItems.Length)
            {
                T[] increasedTempArray = new T[myItems.Length * 2 + 1]; // increase by 1 and multiply by 2 to ensure capacity of array
                for (int i = 0; i < myItems.Length; i++)
                {
                    increasedTempArray[i] = myItems[i];
                }
                myItems = increasedTempArray;
            }
            myItems[count] = itemToAdd;
            count++;
        }

        public bool Remove(T itemToRemove)
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

            if(itemFound) count--; // decrement item(s) in array
            return itemFound;
        }

        public static CustomList<T> operator +(CustomList<T> myList, CustomList<T> myListTwo)
        {
            CustomList<T> positiveList = new CustomList<T>();
            foreach (T item in myList)
            {
                positiveList.Add(item);
            }
            foreach (T item in myListTwo)
            {
                positiveList.Add(item);
            }
            return positiveList;
        }

        public static CustomList<T> operator -(CustomList<T> negativeList, CustomList<T> myListTwo)
        {
            foreach (T item in myListTwo)
            {
                negativeList.Remove(item);
            }
            return negativeList;
        }

        public CustomList<T> Zipper(CustomList<T> listTwo)
        {
            CustomList<T> zipperList = new CustomList<T>();
            var itemInList = listTwo.GetEnumerator(); // set to var b/c it is generic T

            foreach (T itemListOne in this) // "in this" refers to contents of obj "itemListOne" 
            {
                if (itemInList.MoveNext()) // "MoveNext" will check if condition is true then will continue to next item in list, if false = end of list
                {
                    zipperList.Add(itemListOne);
                    zipperList.Add(itemInList.Current); // "Current" will return the same item in list until .MoveNext has met a a condition T/F 
                }
                else
                {
                    break;
                }
            }
            return zipperList;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; ++i)
            {
                yield return myItems[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }           
 }
