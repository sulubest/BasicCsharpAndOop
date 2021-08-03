using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharpAndOop.StringFormatting
{
    class StringFomatManupulate
    {
        static string someText = "Here is some text";
        static string someOtherText = "Here is some other text";

        bool isEqual = someText.Equals(someOtherText,StringComparison.OrdinalIgnoreCase);

        String formattedString = string.Format("{0} {1} Here is some more text",someText,someOtherText);

        string anotherText = string.Empty;

        String replacedText = someText.Replace("text","string");

        
        
        public void Print()
        {
            Console.WriteLine(isEqual);
            Console.WriteLine(formattedString);
            Console.WriteLine(someText.Length);
            Console.WriteLine(someText[8]);
            Console.WriteLine(someText.Substring(8,4));
            Console.WriteLine(someText.ToUpper());
            Console.WriteLine(replacedText);

            
            //Convert string to number
            Console.WriteLine("Input a number here");
            string input = Console.ReadLine();
            int convertedInputToNumber;
            int.TryParse(input, out convertedInputToNumber);
            Console.WriteLine("{0} is your inputted number", convertedInputToNumber);
        }
    }
}
