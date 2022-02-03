using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            var names = new string[]
           {
                "JP", "Joanne", "Jude", "Jules"
           };

            Console.WriteLine("Name options are: " + string.Join(", ", names));

            var selection = new Random();
            var nameIndex = selection.Next(names.Length);

            Console.WriteLine($"Selected name is: {names[nameIndex]}");
            /*
            ============================================================================================ 
            WHAT EACH VARIABLE RETURNS 
            ============================================================================================
            Console.WriteLine($"This is just the 'names' variable: {names}");
            Console.WriteLine($"This is just the 'nameIndex' variable: {nameIndex}");
            Console.WriteLine($"This is how the names[nameIndex] variable returns: {names[nameIndex]}");
            Console.WriteLine($"This is how the names.Length variable returns: {names.Length}");
            ============================================================================================
            */
            Console.WriteLine("Press Any Button To Continue...");
            Console.ReadLine();
        }
    }
}
