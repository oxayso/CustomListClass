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
            CustomList<int> number = new CustomList<int>();
            number.CustomAdd(1);
            number.CustomAdd(2);
            number.CustomAdd(3);
            number.CustomAdd(4);
            foreach (int num in number.arrayItems)
            {
                Console.WriteLine($"Number: {num}");
            }
                       
            Console.ReadKey();
        }
    }
}


//CustomList<string> itemWord = new CustomList<string>();
