using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable<T> where T : IComparable
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

            if(itemFound) count--;
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
            CustomList<T> zipList = new CustomList<T>();
            var listTwoItem = listTwo.GetEnumerator();

            foreach (T itemListOne in this)
            {
                if (listTwoItem.MoveNext())
                {
                    zipList.Add(itemListOne);
                    zipList.Add(listTwoItem.Current);
                }
                else
                {
                    break;
                }
            }
            return zipList;
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
