using System;
using System.IO;

namespace HelloWorld.Interfaces
{
    class IWriter_File : IWriter
    {
        public void WriteMessage(string fileloc, string message)
        {
            using (var filelocation = new StreamWriter(fileloc))
            {
                filelocation.WriteLine(message);
                Console.WriteLine("Writing to file complete.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);

            }
        }

        public void WriteMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}

