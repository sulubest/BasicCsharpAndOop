using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharpAndOop.ListAndArray
{
    class ListAndArrays
    {
        public ListAndArrays()
        {
            //----List------
            var myFirstList = new List<int>();
            //or
            //List<int> myFirstList = new List<int>();

            Console.WriteLine("value count: {0}",myFirstList.Count);

            myFirstList.Add(10);
            myFirstList.Add(25);

            Console.WriteLine("value count: {0}; value 1:{1} value 2:{2}", myFirstList.Count,myFirstList[0],myFirstList[1]);

            //----Array------

            int[] myFirstArray = new int[10];
            myFirstArray[9]= 5;
            Console.WriteLine("Array value: {0}", myFirstArray[9]);

            int[] mySecondArray = { 7,10,15,3,9,2};
            Array.Sort(mySecondArray);
        }
    }
}
