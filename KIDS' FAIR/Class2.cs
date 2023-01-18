using System;

public class Pet
{
    /*Declaring all variables*/
    private string name = " ";
    private int age = 0;
    private bool isFemale = true;

    /*Method for reading name of the users pet*/
    public string ReadName()
    {
        Console.WriteLine("Greetings from the Movie Object! :)" + "\n-----------");
        Console.WriteLine("What is the name of your pet? ");
        name = Console.ReadLine();
        /*Console.WriteLine("Fetching name -OK" + "\n-----------");*/
        return name;

    }
}
