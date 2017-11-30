using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Configuration;
using HelloWorld.Interfaces;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["baseaddress"]);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ConfigurationManager.AppSettings["mediatype"]));
                
                var response = client.GetAsync(ConfigurationManager.AppSettings["getasync"]).Result;
                string message = response.Content.ReadAsStringAsync().Result;

                //App needs to support future enhancements to write to database, console, file location etc. 
                //Using config file to determine where to write to
                var writeLoc = ConfigurationManager.AppSettings["writeloc"];

                if (writeLoc == "console")
                {
                    IWriter_Console console = new IWriter_Console();
                    console.WriteMessage(message);
                }
                else if (writeLoc == "file")
                {
                    var location = ConfigurationManager.AppSettings.Get("fileloc");
                    Console.WriteLine("Writing to file:" + location);
                    IWriter_File file = new IWriter_File();
                    file.WriteMessage(location, message);
                }
                else if (writeLoc == "database")
                {
                    IWriter_Database database = new IWriter_Database();
                    database.WriteMessage(message);
                }
                else
                {
                    IWriter_Console console = new IWriter_Console();
                    var errormessage = "The write location for the message has an error. Please correct the write location.";
                    console.WriteMessage(errormessage);
                }


            }
        }
    }
}
