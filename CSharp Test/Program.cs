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
            Console.WriteLine("Greetings! Please enter the key 'c' to use the Currency Converter, or any other key to use the temperature converter:");
            string answer = Console.ReadLine();

            if (answer == "c")
            {
                Console.WriteLine("Welcome to the Currency Converter.");
                Console.WriteLine("Please enter the key 'r' to convert from Rands or any other key to convert from Dollars:");
                string choice = Console.ReadLine();

                if (choice == "r")
                {
                    Console.WriteLine("Please enter your amount in Rands:");
                    float rands = float.Parse(Console.ReadLine());
                    float dollars = rands / 0.052f;
                    Console.WriteLine("The amount in Dollars is: " + dollars.ToString("0.000"));
                }
                else
                {
                    Console.WriteLine("Please enter your amount in Dollars:");
                    float dollars = float.Parse(Console.ReadLine());
                    float rands = dollars * 19.38f;
                    Console.WriteLine("The amount in Rands is: " + rands.ToString("0.000"));
                }
            }
            else
            {
                Console.WriteLine("Welcome to the Temperature Converter.");
                Console.WriteLine("Please enter the key 't' to convert from Celsius or any other key to convert from Farenheit:");
                string choice = Console.ReadLine();

                if (choice == "t")
                {
                    Console.WriteLine("Enter a temperature in celsius:");
                    float celsius = float.Parse(Console.ReadLine());
                    float farenheit = celsius * 1.8f + 32f;
                    Console.WriteLine("The temperature in Farenheit is: " + farenheit);
                }
                else
                {
                    Console.WriteLine("Please enter a temperature in Farenheit:");
                    float farenheit = float.Parse(Console.ReadLine());
                    float celsius = (farenheit - 32f) / 1.8f;
                    Console.WriteLine("The temperature in celsius is: " + celsius);
                }
            }
        }

        static void Main(string[] args)
        {
            MyMethod();
        }
    }
}
