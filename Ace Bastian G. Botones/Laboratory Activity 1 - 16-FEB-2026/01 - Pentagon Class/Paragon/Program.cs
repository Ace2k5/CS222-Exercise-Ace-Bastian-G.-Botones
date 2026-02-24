using System;


class Program
{
    static void Main(string[] args)
    {
        Paragon p1 = new Paragon();
        Paragon p2 = new Paragon(5);

        Console.WriteLine("Paragon p1");
        p1.Display();
        Console.WriteLine("Paragon p2");
        p2.Display();
    }
}
public class Paragon
{
    private double side;

    public Paragon()
    {
        this.side = 0.0;
    }
    public Paragon(double side)
    {
        this.side = side;
    }

    public double GetPerimeter()
    {
        return 5 * side;
    }
    public double GetArea()
    {
        return Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * side * side / 4;
    }
    public void Display()
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Side length: {this.side}");
        Console.WriteLine($"Perimeter: {GetPerimeter()}");
        Console.WriteLine($"Area: {GetArea():0.000}");
    }
}