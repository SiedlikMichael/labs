using System;

class program
{
    static void Main()
    {

        Console.WriteLine("enter length of room in feet");
        double length = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("enter the width of the room in feet");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("enter height of the room in feet");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = length * width;
        double perimeter = 2 * (length + width);
        string classification;
        

        if (area <= 250)
        {
            classification = "small";
        }
        else if (area < 650)
        {
            classification = "medium";
        }
        else
        {
            classification = "large";
        }
        Console.WriteLine($"Area of the room: {area:F2} square feet");
        Console.WriteLine($"Perimeter of the room: {perimeter:F2} feet");
        Console.WriteLine($"This is a {classification} room.");

        double volume = area * height;
        double surfaceArea = 2 * (length * width + length * height + width * height);

        Console.WriteLine($"Volume of the room: {volume:F2} cubic feet");
        Console.WriteLine($"Surface area of the room: {surfaceArea:F2} square feet");

    }

}