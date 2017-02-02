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

        T[] item = new T[0];

        public CustomList()
        {

        }

        public void Add()
        {
            for (int i = 0; i < numberCount; i++)
            {
                //custom.numberCount.Add(number);
            }
        }

        public void CreateCapacity()
        {
            for (int i = 0; i < 100; i++)
            {
                
            }
        }
    }
}
