using System;

public class InterestCalculator
{
    public static void Main(string[] args)
    {
        run();

    }

    public static void run()
    {
        Console.Write("Enter principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter rate of interest: ");
        double interest_rate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter time in years: ");
        double years = Convert.ToDouble(Console.ReadLine());

        double ans = InterestFormula(principal, interest_rate, years);
        Console.WriteLine($"Simple Interest: {ans:F2}");
    }
    public static double InterestFormula(double principal, double interest_rate, double years)
    {
        double ans = (principal * interest_rate * years) / 100.00;
        return ans;
    }
}