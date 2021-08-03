using BasicCsharpAndOop.ClassAndObject;
using BasicCsharpAndOop.ConditionalStatement;
using BasicCsharpAndOop.Encapsulation;
using BasicCsharpAndOop.ExceptionAndThrow;
using BasicCsharpAndOop.ForLoop;
using BasicCsharpAndOop.Inheritance;
using BasicCsharpAndOop.Interface;
using BasicCsharpAndOop.ListAndArray;
using BasicCsharpAndOop.NullCoalescing;
using BasicCsharpAndOop.ReadAndWriteFiles;
using BasicCsharpAndOop.StringFormatting;
using BasicCsharpAndOop.ValueVSReference;
using System;
using System.Text;

namespace BasicCsharpAndOop
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.WriteLine("This age come from class!! {0} {1}","Age is:",person1.Print());

            StringFomatManupulate _stringFormatManupulate = new StringFomatManupulate();
            _stringFormatManupulate.Print();

            IfCondition ifCondition = new IfCondition(); //works for non static method
            ifCondition.Condition();

            //IfCondition.Condition(); // works only for static method

            ExceptionHandling exceptionHandling = new ExceptionHandling();

            ListAndArrays listAndArrays = new ListAndArrays();

            ForLoops forLoop = new ForLoops();

            ReferenceExample referenceExample = new ReferenceExample();

            CoalescingEample coalescingEample = new CoalescingEample();

            ReadWrite readWrite = new ReadWrite();

            //--Inheritance ---

            PersonInheritance personInheritance = new PersonInheritance("Sultan","Mahmud");
            personInheritance.Sleep();

            SuperPersonInheritance superPersonInheritance = new SuperPersonInheritance("Safwan", "Mahmud");
            superPersonInheritance.Sleep();
            superPersonInheritance.Fly();

            //--Encapsulation--

            PersonEncap personEncap1 = new PersonBuilder().Build();
            PersonEncap personEncap2 = new PersonBuilder().WithAge(37).Build();
            PersonEncap personEncap3 = new PersonBuilder().WithAge(5).WithFirstName("Safwan").Build();
            Console.WriteLine("Name: {0} and Age: {1}",personEncap3.FirstName,personEncap3.Age);

            //--String Builder--

            StringBuilder myString1 = new StringBuilder();
            myString1.Append("Here is some text");
            myString1.Append("Here is some more text");
            myString1.Append("Here is even more text");

            Console.WriteLine(myString1);

            string myString2 = "Here is some text";
            myString2 = myString2 + "Here is some more text";
            myString2 = myString2 + "Here is even more text";
            Console.WriteLine(myString1);

            //--Jagged Array and Matrix--
            int[][] jagged = new int[10][];
            jagged[0] = new int[90];
            jagged[1] = new int[80];

            int[,] matrix = new int[10,10];

            //--Writing Constant---
            Console.WriteLine(Constants.Constants.test1);
            Console.WriteLine(Constants.Constants.test2, personEncap3.FirstName, personEncap3.Age);

            //--Interface example--
            Ferrari ferrari = new Ferrari();
            Lambargoni lambargoni = new Lambargoni();

            PersonInterface personInterface = new PersonInterface(ferrari);
            personInterface.Drive();

    }
    }
}
