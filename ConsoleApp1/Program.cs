using System;
using System.IO;
namespace ConsoleApp1
{
 
    class Program
    { 
        static void Main(string[] args)
        {
            ExceptionsCollection exCollection = new ExceptionsCollection();
            exCollection.ShowException();
            
            Console.ReadKey();

        }
    }
}
