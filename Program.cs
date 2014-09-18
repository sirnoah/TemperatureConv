/*
 * Andres Ramirez
 * 09/16/2014
 * COSC 1415 002
 * Homework 3 Solution
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConv
{
    class Program
    {
        static void Main(string[] args)
        {
            // First, write three methods that gather input, preform the calculation, and display the requested information.
            // Step 1 : Get end-user input
            double fahrenheitTemperature = GetTemperatureInFahrenheit();
            // Step 2: Perform your necessary calculations.
            double celciusTemperature = CalulateTemperatureInCelcius(fahrenheitTemperature);
            //Step 3: Display Requested Information. Because void we just call it.
            DisplayTemperatures(fahrenheitTemperature, celciusTemperature);
            
        }
        //This method will gatehr the requested temperature in Fahrenheit from the end-user.
        //Parameters are for using data to use for the method from external
        private static double GetTemperatureInFahrenheit()
        {
            //Gather the input and store it
            Console.Write("Give a temperature in Fahrenheit to be converted to Celcius: ");
            string input = Console.ReadLine();

            //Convert the gathered end user input to a data type that can be used for calculations.
            double convertedInput = double.Parse(input);
            //OR
            //double convertedInput = Convert.ToDouble(input);
            return convertedInput;
        }
        //This method will convert the given temperature in Fahrenheit to Celcius
        private static double CalulateTemperatureInCelcius(double temperatureToConvert)
        {
            //Convert and store the given temperature to Celcius. Be sure to set it to a double value by assigning a D for each number as we a re working with doubles (decimals) or we will get intiger results aka 0.
            double celciusResult = 5D / 9D * (temperatureToConvert - 32D);
            return celciusResult;
        }
        // This method will display both the given fahreneheit temperature as well as the converted celcius temperature.
        private static void DisplayTemperatures(double temperatureInFahrenheit, double temperatureInCelcius)
        { 
            //Show the user a temperature in fahrenheit as well as in celcius.
            Console.WriteLine("For your given temperature of {0}, the converted Celcius of that is {1}.", temperatureInFahrenheit, temperatureInCelcius);
            Console.ReadKey();
        }
    }
}
