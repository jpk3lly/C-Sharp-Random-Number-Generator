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
            List<string> previousNamesSelected = new List<string>();

            while (nameCount <= noOfNames)                                                              
            {
                var nameIndex = selection.Next(names.Length);
                var selectedName = new names[nameIndex];
                Console.WriteLine($"Name {nameCount} is: {selectedName}");
                previousNamesSelected.Add(selectedName); 
                nameCount++;
            }

            Console.WriteLine($"Names previously selected are: {previousNamesSelected}");  // can't get this line to show for love nor money
            Console.WriteLine("Press Any Button To Continue...");
            Console.ReadLine();
        }
    }
}
