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
            Console.WriteLine("How many names do you want to generate? ");

            int noOfNames = int.Parse(Console.ReadLine());
            var selection = new Random();
            int nameCount = 1;

            while (nameCount <= noOfNames)                                              // Loop to retun selected amount of names
            {
                var nameIndex = selection.Next(names.Length);                           // This variable needed moving into the loop to stop  
                Console.WriteLine($"Name {nameCount} is: {names[nameIndex]}");          // it just returning the same name for each loop
                nameCount++;
            }

            Console.WriteLine("Press Any Button To Continue...");
            Console.ReadLine();
        }
    }
}
