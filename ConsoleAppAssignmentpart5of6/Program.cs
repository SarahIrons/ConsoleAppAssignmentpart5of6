using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleAppAssignmentpart5of6
{
    //    CONSOLE APP PART FIVE ASSIGNMENT
    //   Add the following to your console app and perform these actions:
    //A list of strings that has at least two identical strings in the list.Ask the user to select text to search for in the list.
    //Create a loop that iterates through the list and then displays the indices of the items matching the user-selected text. Ensure to remove any break statements that may prevent your code from returning multiple matches.
    //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list. (You do not need to provide any additional chances for the user to enter text.)
    class Program
    {
        static void Main()
        {//A list of strings that has at least two identical strings in the list.Ask the user to select text to search for in the list.
            string[] seaLife = { "cuttlefish", "lobster", "angelfish", "crab", "lobster", "crab", "seahorse", "crab" };
            Console.WriteLine("Search the aquarium here: ");
            //Create a loop that iterates through the list and then displays the indices of the items matching the user-selected text. Ensure to remove any break statements that may prevent your code from returning multiple matches.

            bool result = seaLife.AsQueryable().Contains(Console.ReadLine());
            Console.WriteLine(result);
            if (result != true)
            {
                Console.WriteLine("We do not have that creature in the aquarium.");
            }
            else
            {
                Console.WriteLine("Yes! We have that creature here.");
            }
            //Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list.

            Console.WriteLine("Here are all of the creatures we have at the aquarium: ");
            Console.WriteLine(String.Join("\n", seaLife));
            Console.WriteLine("Whoops, let me update our list and remove duplicates...");
            Console.WriteLine("Here is the list with duplicates removed: ");
            var noDupeList = (seaLife.Distinct().ToArray());
            for (var i = 0; i < noDupeList.Length; i++)
            {
                Console.WriteLine(i + "  " + noDupeList[i]);

            }

        }
   
    }
}
    


    

