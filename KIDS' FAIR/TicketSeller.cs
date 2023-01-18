using System;

public class TicketSeller
{
	public TicketSeller()
	{
        private string name; 
		private double price = 100; 
		private int numOfAdults; 
		private int numOfChildren; 
		private double amountToPay;
    public void greet() => Console.WriteLine("Welcome to KIDS' FAIR!)\n Children get always a 75% discount!");

    /*Method for reading name of the users pet*/
    public void getNameInput()
    {
        Console.WriteLine("Your name please:\n ");
        name = Console.ReadLine();
    }

    public void getNumOfAdultsInput()
    {
        Console.WriteLine("Number of adults");
        numOfAdults = int.Parse(Console.ReadLine());
    }

    public void getNumOfChildrenInput()
    {
        Console.WriteLine("Number of children? ")
        numOfChildren = int.Parse(Console.ReadLine());
    }

    private double getAmounToPay()
    {
        double adultAmount = numOfAdults* 100;
        double childrenAmount = (100 - (100*0.75)) * numOfChildren;
        double amountToPay = adultAmount + childrenAmount;
        return amountToPay;

    }

    public void Displayinformation()
    {
        Console.WriteLine($"+++ Your receipt +++ \n +++ Amount to pay = {getAmounToPay()} +++ \n +++ Thank you {name} and please come back! +++");
    }

    public void Start()
    {
        greet();
        getNameInput();
        getNumOfAdultsInput();
        getNumOfChildrenInput();
        Displayinformation();
    }
}
}
