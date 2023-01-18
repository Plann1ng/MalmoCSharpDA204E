using System;

public class Pet
{
    /*Declaring all variables*/
    private string name;
    private int age;
    private bool isFemale = true;

    public void greet() => Console.WriteLine("Greetings from MyPet class! :)\n");

    /*Method for reading name of the users pet*/
    public void getNameInput()
    {
        Console.WriteLine("What is the name of your pet? ");
        name = Console.ReadLine();
    }

    /*Method for reading Age of the users pet*/
    public void getAgeInput()
    {
        Console.WriteLine($"What is {name}'s age? ");
        age = int.Parse(Console.ReadLine());
    }

    /*Method for reading gender of the users pet*/
    public void getGenderinput()
    {
        Console.WriteLine("Is your pet a female? (y/n)?");
        string userAnswer = Console.ReadLine();
        if ( userAnswer == "y" || userAnswer == "Y")
        {
            isFemale= true;
        }
        else if (userAnswer == "n" || userAnswer == "N")
        {
            isFemale= false;
        }
        else
        {
            Console.WriteLine("Please answer with only <y> or <n>");
            getGenderinput();
        }
    }

    /*Display info*/
    public void Displayinformation()
    {
        Console.WriteLine("\n+++++++++++++++++++++++++++++");
        Console.WriteLine($"Name: {name} Age: {age}");
        if (isFemale)
            Console.WriteLine($"{name} is a good girl");
        else
            Console.WriteLine($"{name} is a goot boy");
        Console.WriteLine("+++++++++++++++++++++++++++++");
    }

    /*Display*/
    public void Start()
    {
        greet();
        getNameInput();
        getAgeInput();
        getGenderinput();
        Displayinformation();
    }
}
