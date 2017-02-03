using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>   
    {
        public int numberCount;
        T[] items;


        public CustomList()
        {
            items = new T[0];
            numberCount = 0;
        }
        public void CustomAdd(T itemToAdd)
        {

            //items[numberCount] = itemToAdd;
            T[] increaseArray = new T[items.Length + 5];
            for (int i = 0; i < items.Length; i++)
            {
                increaseArray[i] = items[i];
            }

            increaseArray[items.Length] = itemToAdd;
            items = increaseArray;
                                   
        }    
        
        public void CustomRemove(T itemToRemove)
        {
            T[] removeTempArray = new T[items.Length - 3];
            //for (int i = 0; i < items.Length; i++);
            {
                
            }
        }  

        public void CheckForSpaces(T items)
        {

        }
    }
}


//for (int i = 0; i < numberCount; i++)
//{
//    CustomList<int> number = new CustomList<int>();
//}
