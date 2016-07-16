using System;

using System.Linq;

/*The factorial of an integer n, written n!, is the product of the consecutive integers 1 through n.

For example, 5 factorial is calculated as: 5! = 5 x 4 x 3 x 2 x 1 = 120.

Write a program that allows the user to enter the number of factorials to display
*/


    class DisplayFactorials
    {
        static void Main()
        {
        Console.WriteLine("Enter value:");
        string str = Console.ReadLine();
        int num = int.Parse(str); //converting string into int
        int fact  = 1;

        for (int i = 1; i <= num; i++)

        {
            fact = i * fact;
            Console.WriteLine("{0}!    =    {1}   ", i, fact);
        }
            Console.ReadLine();
    }

    }

