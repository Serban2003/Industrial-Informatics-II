using System;
using System.Collections.Generic;

namespace ConsoleAppClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference.WebServiceSoapClient service = new ServiceReference.WebServiceSoapClient();

            Int32 option = 0;
            do
            {
                PrintMenu();
                try
                {
                    option = Int32.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            {
                                List<String> list = service.GetListItems();
                                Console.WriteLine();
                                Console.WriteLine("List");
                                foreach (String item in list)
                                {
                                    Console.WriteLine($"* {item}");
                                }
                                break;
                            }
                        case 2:
                            {
                                Int32 conversionOption = 0;
                                do
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Temperature Conversion");
                                    Console.WriteLine("1. Celsius to Fahrenheit");
                                    Console.WriteLine("2. Fahrenheit to Celsius");
                                    Console.WriteLine("3. Exit");
                                    Console.Write("Choose option: ");

                                    try
                                    {
                                        conversionOption = Int32.Parse(Console.ReadLine());
                                        if (conversionOption == 3) break;
                                        Console.Write("Insert temperature: ");
                                        Double temperature = Double.Parse(Console.ReadLine());

                                        if (conversionOption == 1)
                                        {
                                            Console.WriteLine($"{temperature}C = {service.ConvertTemperature(temperature, "CToF")}F");
                                        }
                                        else if (conversionOption == 2)
                                        {
                                            Console.WriteLine($"{temperature}F = {service.ConvertTemperature(temperature, "FToC")}C");
                                        }
                                        else if (conversionOption != 3)
                                        {
                                            Console.WriteLine("Invalid option!");
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Could not convert temperature!");
                                    }
                                } while (conversionOption != 3);
                                break;
                            }

                        case 3:
                            {
                                Console.WriteLine();
                                Console.WriteLine("Currency Conversion");
                                Console.Write("Insert RON: ");
                                try
                                {
                                    Double ronCurrency = Double.Parse(Console.ReadLine());
                                    Console.WriteLine($"{ronCurrency}RON = {service.ConvertRonToEuro(ronCurrency)}EUR");
                                }
                                catch
                                {
                                    Console.WriteLine("Could not convert currency!");
                                }

                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine($"Date and time: {service.GetDateTime()}");
                                break;
                            }

                        default: break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid option!");
                    option = 0;
                }

            } while (option != 5);
        }

        static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("<----- Web Service Menu ---->");
            Console.WriteLine("1. Display list");
            Console.WriteLine("2. Convert temperature (C, F)");
            Console.WriteLine("3. Convert currency (RON to EURO)");
            Console.WriteLine("4. Display current time");
            Console.WriteLine("5. Exit");
            Console.Write("Select option: ");
        }
    }
}
