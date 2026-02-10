using System;

public class CurrencyConverter
{
    public static void Main(string[] args)
    {
        run();
    }

    public static void run()
    {
        Console.Write("Enter amount in PHP: ");
        double php = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter exchange rate from PHP to USD: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        double ans = Converter(php, rate);
        Console.Write($"Amount in USD: {ans:F2}");
    }
    public static double Converter(double php, double rate)
    {
        double ans = php * rate;
        return ans;
    }
}