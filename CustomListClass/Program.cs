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
            number.CustomAdd(0);
            number.CustomAdd(1);
            number.CustomAdd(2);
            number.CustomAdd(3);
            foreach (int num in number)
            {
                Console.WriteLine($"Number In CustomArray: {num}\n");
            }

            //public static void OverrideToStringConversion()
            {
                int myNumber = 1;
                Console.WriteLine(myNumber.ToString());

                CustomList<int> myValue = new CustomList<int>();
                myValue.value1 = 1;
                myValue.value2 = 2;

                Console.WriteLine(myValue.ToString());
            }

            Console.ReadKey();
        }
    }
}



