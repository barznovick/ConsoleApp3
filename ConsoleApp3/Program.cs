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
            Console.WriteLine("Hello World");

            int i = 0;

            foreach (string arg in args)
            {
                Console.WriteLine(String.Format("Argument #{0} = {1}", i, arg));
                i++;
            }
            if (args.Length >= 3)
            {

                if (args[0] == "poo")
                {
                    Console.WriteLine("I have to pinch a loaf.");
                }
                if (args[1] == "pee")
                {
                    Console.WriteLine("I pee in the toilet.");
                }

                Console.WriteLine(String.Format("My favorite place to drink from the {0}.", args[2]));
            }
            //I am on the dev branch.
            Console.WriteLine("bye bye birdy");
        }
    }
}
