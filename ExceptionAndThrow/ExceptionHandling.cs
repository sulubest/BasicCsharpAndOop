using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharpAndOop.ExceptionAndThrow
{
    class ExceptionHandling
    {
        public ExceptionHandling()
        {
            try
            {
                Console.WriteLine("Input a number here");
                string input = Console.ReadLine();
                int convertedInputToNumber;

                bool isConvertedSuccessfully = int.TryParse(input, out convertedInputToNumber);

                if (!isConvertedSuccessfully)
                {
                    throw new Exception("Conversion was not successfull");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an error: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Rest of application is still running");
            }


        }
    }
}
