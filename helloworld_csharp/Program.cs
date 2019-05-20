using System;
using System.IO;

namespace helloworld_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");

            var l = File.ReadAllLines("ejemplo.txt");

            foreach(var s in l) {
                Console.WriteLine(s);
            }


            
            
        }
    }
}
