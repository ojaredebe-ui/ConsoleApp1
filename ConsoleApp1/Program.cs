using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp2
{
    class program
    {
        static void Main(string[] args)
        {
            /*
             * Activity 2.1
             * Created by: Ebe, Jared
             *Program Description: The Program shall allow the user to eneter 6 random words 
             *(3 nouns and 3 anjectives). These word shall replace the nouns and 
             * adjective of a poem or song lyrics. Display the original and new result 
            */

            try
            {
                string noun1 = "", noun2 = "", noun3 = "";
                string adj1 = "", adj2 = "", adj3 = "";

                Console.Write("Enter first noun: ");
                noun1 = Console.ReadLine();
                Console.Write("Enter second noun: ");
                noun2 = Console.ReadLine();
                Console.Write("Enter third noun: ");
                noun3 = Console.ReadLine();

                Console.Write("Enter first adjective: ");
                adj1 = Console.ReadLine();
                Console.Write("Enter second adjective: ");  
                adj2 = Console.ReadLine();
                Console.Write("Enter third adjective: ");
                adj3 = Console.ReadLine();

                Console.WriteLine("\n********** ORIGINAL **********");
                Console.WriteLine("Tiny little secrets");
                Console.WriteLine("Get buried in the dirt");
                Console.WriteLine("And if they we\'re dug up");
                Console.WriteLine("Someone would probably get hurt");
                Console.WriteLine("So leave them safely there");
                Console.WriteLine("To rot amongst the leaves");
                Console.WriteLine("Admiring instead");
                Console.WriteLine("The truth is summer\'s green trees");

                Console.WriteLine("\n********** RESULT **********");
                Console.WriteLine("{0} little secrets", noun1);
                Console.WriteLine("Get buried in the {0}", adj1);
                Console.WriteLine("And if they we\'re dug up");
                Console.WriteLine("Someone would probably get {0}", adj2);
                Console.WriteLine("{0} leave them safely there", noun2);
                Console.WriteLine("To rot amongst the {0}", adj3);
                Console.WriteLine("Admiring instead");
                Console.WriteLine("The {0} is summer\'s green trees", noun3);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error encountered. " + e.ToString());
            }
            finally
            {
                Console.ReadKey();
            }





        }
    }
}