using System;
using System.IO;

namespace AzureWebJob
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"AzureWebJob Ran at {DateTime.Now.ToString()}");

            File.AppendAllText("RunLog.txt", DateTime.Now.ToString() + Environment.NewLine);
            
            
            
        }
    }
}
