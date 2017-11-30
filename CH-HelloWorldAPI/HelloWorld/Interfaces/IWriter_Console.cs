using System;

namespace HelloWorld.Interfaces
{
    class IWriter_Console : IWriter
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
