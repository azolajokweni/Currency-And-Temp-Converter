using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyTempConverter
{
    class Program
    {
        static void MyMethod()
        {
            // Welcome message and user input
            Console.WriteLine("Greetings! Please enter the key 'c' to use the Currency Converter, or any other key to use the temperature converter:");
            string answer = Console.ReadLine();

            if (answer == "c")
            {
                // If user inputs "c", then they are referred to the currency part of the app
                // User can choose to convert from Rands to Dollars or visa versa
                Console.WriteLine("Welcome to the Currency Converter.");
                Console.WriteLine("Please enter the key 'r' to convert from Rands or any other key to convert from Dollars:");
                string choice = Console.ReadLine();

                if (choice == "r")
                {
                    // User input is read and parsed to a float, answer is given in Dollars
                    Console.WriteLine("Please enter your amount in Rands:");
                    float rands = float.Parse(Console.ReadLine());
                    float dollars = rands * 0.052f;
                    Console.WriteLine("The amount in Dollars is: " + dollars.ToString("0.00"));
                }
                else
                {
                    // User input is read and parsed to a float, answer is given in Rands
                    Console.WriteLine("Please enter your amount in Dollars:");
                    float dollars = float.Parse(Console.ReadLine());
                    float rands = dollars * 19.38f;
                    Console.WriteLine("The amount in Rands is: " + rands.ToString("0.00"));
                }
            }
            else
            {
                // Temperature part of the App
                Console.WriteLine("Welcome to the Temperature Converter.");
                Console.WriteLine("Please enter the key 't' to convert from Celsius or any other key to convert from Fahrenheit:");
                string choice = Console.ReadLine();

                if (choice == "t")
                {
                    // User input is read and parsed to a float, answer is given in Fahrenheit
                    Console.WriteLine("Enter a temperature in celsius:");
                    float celsius = float.Parse(Console.ReadLine());
                    float fahrenheit = celsius * 1.8f + 32f;
                    Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit.ToString("0.00"));
                }
                else
                {
                    // User input is read and parsed, answer is given in celsius
                    Console.WriteLine("Please enter a temperature in Fahrenheit:");
                    float fahrenheit = float.Parse(Console.ReadLine());
                    float celsius = (farenheit - 32f) / 1.8f;
                    Console.WriteLine("The temperature in celsius is: " + celsius.ToString("0.00"));
                }
            }
        }

        static void Main(string[] args)
        {
            MyMethod();
        }
    }
}
