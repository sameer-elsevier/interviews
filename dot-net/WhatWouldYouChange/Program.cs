using System;

namespace ExampleProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var exampleClass = new ExampleClass();

            exampleClass.ExampleMethod("ExampleTexttxt");

            Console.Write(exampleClass.exampleText);
            Console.ReadKey();
        }
    }
}