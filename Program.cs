using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitingRoom
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to Alex's waiting room!");
            Console.WriteLine();
            Console.WriteLine("Please enter your name.");
            Console.WriteLine();
            string  CustomerNameInput = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Please enter your ID# or DL# to continue.");
            Console.WriteLine();
            string CustomerID = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the name of the person who you are here to see.");
            Console.WriteLine();
            string CustomerWantsToSee = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Please give us a brief description of your issue.");
            Console.WriteLine();
            string CustomerIssue = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("If there is any additional info required, please enter it here.");
            Console.WriteLine();
            string AdditionalInfo = Console.ReadLine();
            Console.WriteLine("Please press any key to continue.");
            Console.ReadKey();
            Console.WriteLine("Thank you,");
            Console.WriteLine(CustomerNameInput);
            Console.WriteLine(".");
            Console.WriteLine();
            Console.WriteLine(CustomerWantsToSee);
            Console.WriteLine(" will be with you shortly, thank you for your patience.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Here's the info we have on you so far:");
            Console.WriteLine("Your DL/ID # ");
            Console.WriteLine(CustomerID);
            Console.WriteLine();
            Console.WriteLine("You are here to see: ");
            Console.WriteLine(CustomerWantsToSee);
            Console.WriteLine();
            Console.WriteLine("Your reported issue is : ");
            Console.WriteLine(CustomerIssue);
            Console.WriteLine();
            Console.WriteLine("And any additional info : ");
            Console.WriteLine(AdditionalInfo);
            Console.WriteLine("Please press any key to end.");
            Console.ReadKey();
            

        }
    }
}
