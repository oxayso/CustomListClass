using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass

{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> itemWord = new CustomList<string>();
            CustomList<int> itemNumber = new CustomList<int>();
            Console.ReadKey();
        }
    }
}
