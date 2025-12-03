// See https://aka.ms/new-console-template for more information
double fahrenheit, celsius;
Console.Write("Enter Celsius Degeree : ");
celsius = Convert.ToDouble(Console.ReadLine());

fahrenheit = (1.8 * celsius) + 32;
Console.WriteLine($"Fahrenheit Degree : {fahrenheit}");