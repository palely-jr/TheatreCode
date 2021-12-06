using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbhiTheatre
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("    Multiplex Universe");

        A:
            Console.WriteLine("\nSelect the option you want to perform:\n1. Add a Customer\n2. Book a screening \n3. Add a Movie \n4. Display DVDs\nEnter 0 to quit");
            choice_option = int.Parse(Console.ReadLine());
            switch (choice_option)
            {
                case 1:
                   
                    goto A;

                case 2:
                   
                    goto A;

                case 3:
                    
                    goto A;

                case 4:
                   
                    goto A;

                case 0:
                    Environment.Exit(1);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("\n\nInvalid Choice!");
                    System.Threading.Thread.Sleep(1500);
                    goto A;

            }





        }
    }
}
