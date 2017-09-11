using System;

namespace week2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			//Console.WriteLine("Hello Mr. Cox!");
			// string userValue;
			//userValue = Console.ReadLine();
			//Console.WriteLine("Hello Mr. Cox!" + userValue);
			//Console.ReadLine();

			Console.WriteLine("Would you prefer what is behind door number 1, 2, or 3");
		    string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                message = ("You won a new wife!!!");
            else if (userValue == "2")
				message = ("You won a new child!!!");
			else if (userValue == "3")
			    message = ("You loose everything that you have!!!");
            else
                message = ("Sorry that you are dumb and can't pick a number!");
			   
			Console.WriteLine(message);
			Console.ReadLine();
		}
    }
} 
//this code gives you three options and lets the user pick them and for each
// of the three numbers the user can guess they win a prize. 
// This is important bc it allows for user input.