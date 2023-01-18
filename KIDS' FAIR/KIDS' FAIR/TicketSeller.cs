using System;

public class TicketSeller
{
    public TicketSeller() {}
    /*Constructors*/
    private string name; 
		private double price = 100; 
		private int numOfAdults; 
		private int numOfChildren; 
		private double amountToPay;
    public void greet() => Console.WriteLine("\nWelcome to KIDS' FAIR!)\nChildren get always a 75% discount!");

    /*Method for reading name of the user*/
    public void getNameInput()
    {
        Console.WriteLine("\nYour name please:");
        name = Console.ReadLine();
    }

    /*Method for number of Adults*/
    public void getNumOfAdultsInput()
    {
        Console.WriteLine("Number of adults:");
        numOfAdults = int.Parse(Console.ReadLine());
    }

    /*Method for number of Children*/
    public void getNumOfChildrenInput()
    {
        Console.WriteLine("Number of children:");
        numOfChildren = int.Parse(Console.ReadLine());
    }

    /*Method for calculating the total amount to pay*/
    private double getAmounToPay()
    {
        double adultAmount = Convert.ToDouble(numOfAdults)* 100;
        double childrenAmount = (100 - (100*0.75)) * Convert.ToDouble(numOfChildren);
        double amountToPay = adultAmount + childrenAmount;
        return amountToPay;

    }

    /*Display*/
    public void Displayinformation()
    {
        Console.WriteLine($"+++ Your receipt +++ \n+++ Amount to pay = {getAmounToPay().ToString("N2")} +++ \n+++ Thank you {name} and please come back! +++");
    }

    /*Runner*/
    public void Start()
    {
        greet();
        getNameInput();
        getNumOfAdultsInput();
        getNumOfChildrenInput();
        Displayinformation();
    }
}

