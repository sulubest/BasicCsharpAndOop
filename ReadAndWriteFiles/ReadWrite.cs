using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BasicCsharpAndOop.ReadAndWriteFiles
{
    class ReadWrite
    {
        public ReadWrite()
        {
            string[] lines = { "This is first line", "This is second line", "This is third line" };
            File.WriteAllLines("MyFirstText.txt", lines);

            string[] fileContents = File.ReadAllLines("MyFirstText.txt");
            foreach (string line in fileContents)
            {
                Console.WriteLine(line);
            }
        }
        
    }
}
