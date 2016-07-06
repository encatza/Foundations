using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter seconds to convert:");
        string input = Console.ReadLine();
        float some_input = float.Parse(input);
        //int seconds = ;
        int sec_in_Day = 86400;
        int sec_in_Hour = 3600;
        int sec_in_Min = 60;
        int sec_in_Sec = 1;


        float sec_to_Day = some_input / sec_in_Day;
        float sec_to_Hour = some_input / sec_in_Hour;
        float sec_to_Min = some_input / sec_in_Min;
        float sec_to_Sec = some_input / sec_in_Sec;

        Console.WriteLine("There are {0} days  {1} hours  {2} minutes and {3} seconds",  sec_to_Day, sec_to_Hour, sec_to_Min, sec_to_Sec);
        Console.WriteLine("in user's input");
        //  Console.WriteLine("There are {0} days  {1} hours  {2} minutes {3} seconds" + "  in" + " " + input + "  seconds" ,  sec_to_Day, sec_to_Hour, sec_to_Min, sec_to_Sec);


        Console.ReadLine();
    }
    
}