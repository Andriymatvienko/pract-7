using System;

class Rectangle
{
    private double length;
    private double width;

    public double this[int index]
    {
        get
        {
            if (index == 0)
                return length;
            else if (index == 1)
                return width;
            else
                throw new IndexOutOfRangeException("Invalid index");
        }
        set
        {
            if (index == 0)
                length = value;
            else if (index == 1)
                width = value;
            else
                throw new IndexOutOfRangeException("Invalid index");
        }
    }

    public double Perimeter
    {
        get { return 2 * (length + width); }
    }

    public double Area
    {
        get { return length * width; }
    }

    public void InputDimensions()
    {
        Console.WriteLine("Enter length: ");
        length = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter width: ");
        width = double.Parse(Console.ReadLine());
    }

    public void DisplayDimensions()
    {
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Width: " + width);
    }

    public void DisplaySides()
    {
        Console.WriteLine("Sides:");
        Console.WriteLine("Side 1: " + this[0]);
        Console.WriteLine("Side 2: " + this[1]);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        rectangle.InputDimensions();

        Console.WriteLine("Perimeter: " + rectangle.Perimeter);
        Console.WriteLine("Area: " + rectangle.Area);

        rectangle.DisplaySides();

        Console.ReadLine();
    }
}
