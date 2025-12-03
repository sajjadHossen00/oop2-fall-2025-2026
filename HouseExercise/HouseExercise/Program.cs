
using System;
public class House
{
    public int YearBuilt { get; set; }
    public double Size { get; set; } 
    public House(int yearBuilt, double size)
    {
        YearBuilt = yearBuilt;
        Size = size;
    }
    private int HowOld()
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - YearBuilt;
    }
    public bool CanBeSold()
    {
        return HowOld() > 15;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"House built in {YearBuilt}, Size: {Size}");
        Console.WriteLine($"Can be sold: {CanBeSold()}");
    }
}
public class Program
{
    public static void Main()
    {
        Console.Write("Enter the year the house was built: ");
        int yearBuilt = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the size of the house: ");
        double size = Convert.ToDouble(Console.ReadLine());

        House myHouse = new House(yearBuilt, size);
        myHouse.DisplayInfo();
    }
}
