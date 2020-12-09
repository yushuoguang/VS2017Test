using System;
using Newtonsoft.Json;

namespace ConsoleApp2017
{
    class Program
    {
        static void Main(string[] args)
        {
            string blah = "blah";
            Console.WriteLine(JsonConvert.SerializeObject(blah));
            Console.ReadLine();
        }
    }
}
