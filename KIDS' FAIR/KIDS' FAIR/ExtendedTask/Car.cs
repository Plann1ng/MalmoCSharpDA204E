using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedTask
{
    public class Car
    {
        public Car() {}
        private double price;
        private int year;
        private String model;
        private String manifacturer;
        private int weight;
        private Boolean isAutomatic;

        /*Method to greet user.*/
        public void greet() => Console.WriteLine("Starting the car registry!\n");

        /*Method for reading Model of the user's car.*/
        public void getCarModelInput()
        {
            Console.WriteLine("What is the model of your car? ");
            model = Console.ReadLine();
        }

        /*Method for reading Year of the user's car*/
        public void getCarYearInput()
        {
            Console.WriteLine($"What is the year {model} was manifactured? ");
            year = int.Parse(Console.ReadLine());
        }

        /*Method for reading Manifacturer of the user's car*/
        public void getCarManifacturerInput()
        {
            Console.WriteLine($"Which company manifactured {model}? ");
            manifacturer = Console.ReadLine();
        }

        /*Method for reading Weight of the user's car*/
        public void getCarWeightInput()
        {
            Console.WriteLine($"What is the weight of {model}? ");
            weight = int.Parse(Console.ReadLine());
        }

        /*Method for reading Automatization of the user's car*/
        public void getisAutomaticInput()
        {
            Console.WriteLine($"Is {model} automatic (y/n)? ");
            string userAnswer = Console.ReadLine();
            if (userAnswer == "y" || userAnswer == "Y")
            {
                isAutomatic = true;
            }
            else if (userAnswer == "n" || userAnswer == "N")
            {
                isAutomatic = false;
            }
            else
            {
                Console.WriteLine("Please answer with only <y> or <n>");
                getisAutomaticInput();
            }
        }

        /*Method for reading Price of the user's car*/
        public void getCarPriceInput()
        {
            Console.WriteLine($"What is the price of {model}? ");
            price = Convert.ToDouble(int.Parse(Console.ReadLine()));
        }

        /*Method to print out details about user's car*/
        public void getDetails()
        {
            Console.WriteLine("+++++++++++++++++++++");
            Console.WriteLine($"You car model is {model}");
            Console.WriteLine($"{model} was manifactured in {year}\nManifactured by {manifacturer}");
            Console.WriteLine($"{model} weights {weight}\n{model} costs {price.ToString("N2")}");
            if (isAutomatic)
            {
                Console.WriteLine($"{model} is automatic");
            }
            else if (!isAutomatic)
            {
                Console.WriteLine($"{model} is not automatic");
            }
            }

        public void getDateTime()
        {
            DateTime now = new DateTime();
            Console.WriteLine(now.ToString());
        }

        /*Runner*/
        public void Start()
            {
                greet();
                getCarModelInput();
                getCarYearInput();
                getCarManifacturerInput();
                getCarWeightInput();
                getisAutomaticInput();
                getCarPriceInput();
                getDetails();
                getDateTime();
        }
        }
    }

