using System;

namespace HelloWorld.Interfaces
{
    class IWriter_Database : IWriter
    {
        public void WriteMessage(string message)
        {
            //Database connection, then write to database
            //In the meantime...
            Console.WriteLine("This message is meant to be written to the database, for now it will display...");
            Console.WriteLine(message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}

