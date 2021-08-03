using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharpAndOop.ForLoop
{
    class ForLoops
    {
        public ForLoops()
        {
            //---Array---

            int[] array = { 1,2,3,4,5};

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            for (int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }

            int index = 0;
            while (index < array.Length)
            {
                Console.WriteLine(array[index]);
                index++;
            }


            //--List--
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
