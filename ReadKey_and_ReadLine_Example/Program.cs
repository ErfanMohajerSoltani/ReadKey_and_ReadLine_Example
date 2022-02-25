using System;

namespace ReadKey_and_ReadLine_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start!");

            // When we use ReadKey command, console waits for pressing any key to continue
            Console.ReadKey();

            // When we use ReadLine command, in truth we're giving input and console waits to user enter a value
            Console.Write("\n" + "Please enter your full name: ");

            string fullName;
            fullName = Console.ReadLine();

            Console.WriteLine("Hi " + fullName + ", Hope you enjoyed <3" + "\n" + "-----------------------------------------------");
        }
    }
}
