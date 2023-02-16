using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Nathan";
            string favMovie = "Aquamarine";

            Console.WriteLine("So, we meet again.  My name is" + firstName.ToLower() + ", and I believe that " + favMovie.ToLower() + " is the greatest, most divine and aesthetic exerience the film industry has ever devised.  I'm aware your opinion differs, and I am here to deal with that.");

            favMovie = favMovie.ToUpper();

            Console.WriteLine(favMovie + "!!!!!!!");

            if (favMovie.Contains("THE"))
                Console.WriteLine("True?");
            else
                Console.WriteLine("The greatest movie of all time would never include such a monotonous and mundane word such as \"the\" in its title.");

            firstName = firstName.Replace("a", "@");
            firstName = firstName.Replace("t", "7");
            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            favMovie = favMovie.Replace("I", "1");

            Console.WriteLine(firstName);
            Console.WriteLine(favMovie);

            Console.WriteLine("");

            //p2

            string favQuote = "\"You miss one hundred percent of the shots you don't take.\"";

            Console.WriteLine("Aquamarine once said, " + favQuote + "  Truly an influential and thought-provoking statement from a movie worth all the awards that society can muster.");

            favQuote = favQuote.ToLower();

            string[] vowels = { "a", "e", "i", "o", "u", "y" };

            foreach (string vowel in vowels)
                favQuote = favQuote.Replace(vowel, "");

            Console.WriteLine(favQuote);
            Console.Write("Even without vowels, this quote is still inspirational!");
            Console.WriteLine("");

            //p3

            Console.WriteLine("");
            Console.WriteLine("-----####------------------------------------------");
            Console.WriteLine("----#######---------------------####---------------");
            Console.WriteLine("---##########-----------------########-------------");
            Console.WriteLine("--############---------------##########------------");
            Console.WriteLine("-#############--------------###--####--#-----------");
            Console.WriteLine("############----------------##----##---------------");
            Console.WriteLine("##########------------------##--88##--88-----------");
            Console.WriteLine("########-------------------###--88##--88#----------");
            Console.WriteLine("######-------#--#--#--#----####--####--##----------");
            Console.WriteLine("########-------------------##############----------");
            Console.WriteLine("##########-----------------##############----------");
            Console.WriteLine("-###########---------------##############----------");
            Console.WriteLine("--############-------------##############----------");
            Console.WriteLine("---###########-------------##-###--###-##----------");
            Console.WriteLine("----#########--------------#---##--##---#----------");
            Console.WriteLine("-----######----------------------------------------");
            Console.WriteLine("pac man pac man pac man pac man pac man pac man pac");


            Console.ReadLine();
        }
    }
}