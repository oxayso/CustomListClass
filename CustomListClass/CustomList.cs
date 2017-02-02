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

        T[] items = new T[0];

        public void Add(T itemToAdd)
        {
            items[this.numberCount] = itemToAdd;
            T[] tempArray = new T[items.Length];
            items = tempArray;

            string numberCount = " " ;
            for (int i = 0; i < numberCount.Length; i++)
            {

            }
 

            //for (int i = 0; i < numberCount; i++)
            //{
            //    CustomList<int> number = new CustomList<int>();
            //}
        }      
    }
}
