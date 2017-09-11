using System;

namespace week2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x, y, a, b;

            // Asignment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            //There are many mathematical operations ....

            //addition
            x = 3 + 4;

            //subtraction 
            x = 4 - 3;

            //multiplication
            x = 10 * 5;

            //division
            x = 10 / 5;

            // There are many operators used to evaluate values....

            //equality
            if (x == y)
            {
            }

			//greater than
			if (x > y)
			{
			}

			//less than
			if (x < y)
			{
			}

			//greater than or equal to
			//greater than
			if (x >= y)
			{
			}

			//less than or equal to
			//greater than
			if (x <= y)
			{
			}

			// There are two "conditional" operators as well that can be used to expand/ emhance an evaluation
			// ... and they can be combined together multiple times.

			//conditional AND operator
            if ((x > y) && (a > b))
			{
			}

			//conditional OR operator
			if ((x > y) || (a > b))
			{
			}

            // Also here is the inline conditional operator we learned about in the previous lesson
            string message = (x == 1) ? "Car" : "Boat";

            // Member acces and method invocation
            Console.WriteLine("Hi");
		}
    }
} 
//this code shows you all the diffrent ways to use math in your code.
// Its important bc it shows basic things that we will use a lot this year