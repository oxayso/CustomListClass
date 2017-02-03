using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        public int arrayCount;
        public T[] arrayItems;

        public CustomList()
        {
            arrayItems = new T[0];
            arrayCount = 0;
        }
        public void CustomAdd(T itemToAdd)
        {
            if(arrayCount >= arrayItems.Length)
            {
                T[] increasedTempArray = new T[arrayItems.Length + 4];
                for (int i = 0; i < arrayItems.Length; i++)
                {
                    increasedTempArray[i] = arrayItems[i];
                }
                arrayItems = increasedTempArray;
            }
            arrayItems[arrayCount] = itemToAdd;
            arrayCount++;
        }

        public void CustomRemove(T itemToRemove)
        {
            if(arrayCount <= arrayItems.Length)
            {
                T[] removeTempArray = new T[arrayItems.Length - 1];
                for (int i = 0; i < arrayItems.Length; i--)
                {
                    removeTempArray[i] = arrayItems[i];
                }
                arrayItems = removeTempArray;
                }
                arrayItems[arrayCount] = itemToRemove;
            arrayCount--;
        }
        

    }
}



//{
//increasedTempArray[i] = arrayItems[i];
//}
//increasedTempArray[arrayItems.Length] = itemToAdd;
//arrayItems = increasedTempArray;
//arrayCount++; 