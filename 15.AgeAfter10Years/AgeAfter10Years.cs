using System;
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("How year old are You: ");
        string age = Console.ReadLine();
        Console.WriteLine("After 10 year You will be on "
            + (int.Parse(age) + 10) + " year old");
    }
}

