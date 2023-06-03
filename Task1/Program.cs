using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Conference WRA202 = new Conference();
            Console.WriteLine("Checking whether methods work with empty tree");
            Console.WriteLine("Press enter to continue.......");
            Console.ReadLine();
            Console.WriteLine("There are {0} delegates in the list", WRA202.noConfDelegates());
            Console.WriteLine();
            Console.WriteLine("The average amount due per delegate is R{0}", WRA202.avgAmntDue());
            Console.ReadLine();
            int choice = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Build tree top down");
                Console.WriteLine("2. Number of delegates in list");
                Console.WriteLine("3. Average amount due per delegate");
                Console.WriteLine("9. Terminate");
                do
                {
                    Console.Write("Enter selection ");
                    choice = int.Parse(Console.ReadLine());
                    if (((choice < 1) || (choice > 3)) && (choice != 9))
                        Console.WriteLine("Error with selection made");
                }
                while ((choice != 1) && (choice != 2) && (choice != 3) && (choice != 9));
                switch (choice)
                {
                    case 1:
                        if (WRA202.ConfDelegates != null)
                            WRA202.ConfDelegates = WRA202.ConfDelegates.clear();
                        WRA202.buildTreeTopDown();
                        Console.WriteLine("Displaying nodes in tree");
                        WRA202.displayTreeStructure();
                        Console.WriteLine("Press enter to continue.......");
                        Console.ReadLine();
                        break;
                    case 2:
                        if (WRA202.ConfDelegates != null)
                            WRA202.ConfDelegates = WRA202.ConfDelegates.clear();
                        WRA202.buildTreeTopDown();
                        Console.WriteLine("There are {0} delegates in the list", WRA202.noConfDelegates());
                        Console.WriteLine("Press enter to continue.......");
                        Console.ReadLine();
                        break;
                    case 3:
                        if (WRA202.ConfDelegates != null)
                            WRA202.ConfDelegates = WRA202.ConfDelegates.clear();
                        WRA202.buildTreeTopDown();
                        Console.WriteLine("The average amount due per delegate is R{0}", WRA202.avgAmntDue());
                        Console.WriteLine("Press enter to continue.......");
                        Console.ReadLine();
                        break;
                    default: break;
                }
            }
            while (choice != 9);
            Console.WriteLine("Processing terminated - press enter to continue");
            Console.ReadLine();
        }
    }
}

