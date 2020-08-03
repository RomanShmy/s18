using System;

namespace hello_console
{
    class Program
    {
        static void Main(string[] args)
        {
            String message = BuildMessage("World");
            Console.WriteLine($"Hello {message}!");
        }

        static String BuildMessage(String message){
            return "World";
        }
    }
}
