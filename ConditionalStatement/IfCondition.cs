using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharpAndOop.ConditionalStatement
{
    class IfCondition
    {
        
        static string userNmae = Console.ReadLine();
        
        static string password = Console.ReadLine();

        public IfCondition()
        {
            Console.WriteLine("Input user id and password");
   
        }
        public void Condition()
        {
            if (userNmae == "sultan" && password == "abc123")
            {
                Console.WriteLine("This is Admin");
            }
            else if (userNmae == "safwan" && password == "abc123")
            {
                Console.WriteLine("This is Moderator");
            }
            else
            {
                Console.WriteLine("This is Guest");
            }
        }
    }
}
