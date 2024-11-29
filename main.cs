using System;
using System.Globalization;

class Salary
{
    public decimal Basic { get; set; }
    public decimal TA { get; set; } // Travel Allowance
    public decimal DA { get; set; } // Dearness Allowance
    public decimal HRA { get; set; } // House Rent Allowance

    // Constructor with default values for DA and HRA
    public Salary(decimal basic, decimal ta, decimal da = 0.1m, decimal hra = 0.2m)
    {
        Basic = basic;
        TA = ta;
        DA = da * Basic; // 10% of Basic by default
        HRA = hra * Basic; // 20% of Basic by default
    }

    public decimal CalculateTotalSalary()
    {
        return Basic + TA + DA + HRA;
    }

    public void DisplaySalaryDetails()
    {
        CultureInfo indianCulture = new CultureInfo("hi-IN");
        Console.WriteLine($"Basic Salary: {Basic.ToString("C", indianCulture)}");
        Console.WriteLine($"Travel Allowance (TA): {TA.ToString("C", indianCulture)}");
        Console.WriteLine($"Dearness Allowance (DA): {DA.ToString("C", indianCulture)}");
        Console.WriteLine($"House Rent Allowance (HRA): {HRA.ToString("C", indianCulture)}");
        Console.WriteLine($"Total Salary: {CalculateTotalSalary().ToString("C", indianCulture)}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Basic Salary: ");
        decimal basic = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter Travel Allowance (TA): ");
        decimal ta = Convert.ToDecimal(Console.ReadLine());

        // Create an object of Salary class
        Salary salary = new Salary(basic, ta);

        // Display salary details
        Console.WriteLine("\nSalary Details:");
        salary.DisplaySalaryDetails();
    }
}
