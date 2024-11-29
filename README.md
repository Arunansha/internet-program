# internet-program

1.	Write a program using C# to Generate Fibonacci series using Conditional statements and loop.
Ans.
using System;

class FibonacciSeries
{
    static void Main()
    {
        // Ask the user for the number of terms in the Fibonacci series
        Console.Write("Enter the number of terms in the Fibonacci series: ");
        int terms = int.Parse(Console.ReadLine());

        // Checking if the number of terms is greater than 0
        if (terms <= 0)
        {
            Console.WriteLine("Please enter a positive integer greater than 0.");
        }
        else if (terms == 1)
        {
            // Special case when only one term is requested
            Console.WriteLine("Fibonacci series: 0");
        }
        else
        {
            // Initialize the first two Fibonacci numbers
            int first = 0, second = 1;

            // Display the first two terms
            Console.WriteLine("Fibonacci series:");
            Console.Write(first + " " + second + " ");

            // Loop to generate the rest of the Fibonacci series
            for (int i = 3; i <= terms; i++)
            {
                int nextTerm = first + second;
                Console.Write(nextTerm + " ");
                
                // Update first and second to the next pair in the series
                first = second;
                second = nextTerm;
            }
        }
    }
}



-------------------------------------------------------------------------------
3.	Write a program using C# to generate the following pattern using Conditional statements and loop.
Ans.
using System;

class Program
{
    static void Main()
    {
        int n = 5; // Number of rows in the pyramid

        for (int i = 1; i <= n; i++)
        {
            // Print leading spaces for alignment
            for (int space = 1; space <= n - i; space++)
            {
                Console.Write(" ");
            }

            // Print increasing numbers
            for (int num = 1; num <= i; num++)
            {
                Console.Write(num);
            }

            // Print decreasing numbers
            for (int num = i - 1; num >= 1; num--)
            {
                Console.Write(num);
            }

            // Move to the next line
            Console.WriteLine();
        }
    }
}
-------------------------------------------------------------------------------
4.	Write a program using C# to test for prime numbers using Conditional statements and loop.
Ans.
using System;

class PrimeNumberTest
{
    static void Main()
    {
        // Ask the user to input a number to test for primality
        Console.Write("Enter a number to check if it is prime: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is less than 2 (prime numbers are greater than 1)
        if (number <= 1)
        {
            Console.WriteLine($"{number} is not a prime number.");
        }
        else
        {
            bool isPrime = true;

            // Loop from 2 to the square root of the number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                // If the number is divisible by i, it is not prime
                if (number % i == 0)
                {
                    isPrime = false;
                    break;  // Exit the loop as we found a divisor
                }
            }

            // Output the result based on the isPrime flag
            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
    }
}



-------------------------------------------------------------------------------
6.	Write a program using C# to reverse a number and find sum of digits of the number using Conditional statement and loop.
Ans.
using System;

class ReverseAndSum
{
    static void Main()
    {
        // Input the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int reverse = 0, sum = 0;

        // Store the original number for sum calculation
        int temp = number;

        // Reverse the number and find the sum of digits
        while (number != 0)
        {
            int digit = number % 10;  // Get the last digit
            reverse = reverse * 10 + digit; // Reverse the number
            sum += digit;              // Add digit to sum
            number /= 10;              // Remove the last digit
        }

        // Display the results
        Console.WriteLine($"Reversed number: {reverse}");
        Console.WriteLine($"Sum of digits: {sum}");
    }
}

-------------------------------------------------------------------------------

8.	Write a program to declare a class ‘staff’ having data members as name and post. Accept data for 5 staffs and display names of staff who are HOD.
Ans.
using System;

class Staff
{
    public string Name;
    public string Post;
}

class Program
{
    static void Main()
    {
        Staff[] staffMembers = new Staff[5];

        // Accept data for 5 staff members
        for (int i = 0; i < 5; i++)
        {
            staffMembers[i] = new Staff();
            Console.Write($"Enter name of staff {i + 1}: ");
            staffMembers[i].Name = Console.ReadLine();
            Console.Write($"Enter post of staff {i + 1}: ");
            staffMembers[i].Post = Console.ReadLine();
        }

        // Display names of staff who are HOD
        Console.WriteLine("\nStaff who are HOD:");
        foreach (var staff in staffMembers)
        {
            if (staff.Post.ToUpper() == "HOD")
            {
                Console.WriteLine(staff.Name);
            }
        }
    }
}


-------------------------------------------------------------------------------
10.	Write a program to declare class “Distance” have data members dist1, dist2 and dist3. Initialize the two data members using constructor and store their addition in third data member using method and display addition result.
Ans.
using System;

class Distance
{
    public int dist1, dist2, dist3;

    // Constructor to initialize dist1 and dist2
    public Distance(int d1, int d2)
    {
        dist1 = d1;
        dist2 = d2;
    }

    // Method to calculate and store the addition of dist1 and dist2 in dist3
    public void AddDistances()
    {
        dist3 = dist1 + dist2;
    }

    // Method to display the result
    public void Display()
    {
        Console.WriteLine($"Distance 1: {dist1}");
        Console.WriteLine($"Distance 2: {dist2}");
        Console.WriteLine($"Sum of distances (Distance 3): {dist3}");
    }
}

class Program
{
    static void Main()
    {
        // Taking user input for dist1 and dist2
        Console.Write("Enter the first distance (dist1): ");
        int dist1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second distance (dist2): ");
        int dist2 = int.Parse(Console.ReadLine());

        // Create an object of Distance class with dist1 and dist2 initialized
        Distance d = new Distance(dist1, dist2);

        // Add the distances and calculate dist3
        d.AddDistances();

        // Display the result
        d.Display();
    }
}


-------------------------------------------------------------------------------
12.	Write a program using overloading to swap two integer numbers and swap two float numbers.
Ans.
using System;

class SwapExample
{
    // Method to swap two integers
    public void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // Method to swap two floats
    public void Swap(ref float a, ref float b)
    {
        float temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        SwapExample swapExample = new SwapExample();

        // Swapping two integers
        Console.Write("Enter the first integer: ");
        int intX = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int intY = int.Parse(Console.ReadLine());

        Console.WriteLine($"Before swapping integers: intX = {intX}, intY = {intY}");
        swapExample.Swap(ref intX, ref intY);
        Console.WriteLine($"After swapping integers: intX = {intX}, intY = {intY}");

        // Swapping two floats
        Console.Write("\nEnter the first float: ");
        float floatP = float.Parse(Console.ReadLine());

        Console.Write("Enter the second float: ");
        float floatQ = float.Parse(Console.ReadLine());

        Console.WriteLine($"Before swapping floats: floatP = {floatP}, floatQ = {floatQ}");
        swapExample.Swap(ref floatP, ref floatQ);
        Console.WriteLine($"After swapping floats: floatP = {floatP}, floatQ = {floatQ}");
    }
}


-------------------------------------------------------------------------------
14.	Write a program to implement single inheritance from following figure. Accept and display data for object of Table.
Ans.
using System;

class Furniture
{
    protected string material;
    protected int price;

    public void GetDetails()
    {
        Console.WriteLine("Enter material:");
        material = Console.ReadLine();

        Console.WriteLine("Enter price (in Indian Rupees):");
        price = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Material: " + material);
        Console.WriteLine("Price: ₹" + price);
    }
}

class Table : Furniture
{
    private int height;
    private double surface_area;

    public void GetTableDetails()
    {
        base.GetDetails();

        Console.WriteLine("Enter height (in cm):");
        height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter surface area (in sq. cm):");
        surface_area = Convert.ToDouble(Console.ReadLine());
    }

    public void DisplayTableDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Height: " + height + " cm");
        Console.WriteLine("Surface Area: " + surface_area + " sq. cm");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Table table = new Table();

        table.GetTableDetails();
        table.DisplayTableDetails();
    }
}

 -------------------------------------------------------------------------------                
16.	 Define a class ‘salary’ which will contain member variable Basic, TA, DA, HRA. Write a program using Constructor with default values for DA and HRA and calculate the salary of the employee.
 Ans.
using System;

class Salary
{
    public double Basic;
    public double TA;
    public double DA;  // Default value for DA will be set in the constructor
    public double HRA; // Default value for HRA will be set in the constructor

    // Constructor with default values for DA and HRA
    public Salary(double basic, double ta, double da = 5000, double hra = 8000)
    {
        Basic = basic;
        TA = ta;
        DA = da;
        HRA = hra;
    }

    // Method to calculate the total salary
    public double CalculateSalary()
    {
        return Basic + TA + DA + HRA;
    }

    // Method to display the salary components
    public void DisplaySalary()
    {
        Console.WriteLine($"Basic Salary: {Basic}");
        Console.WriteLine($"TA: {TA}");
        Console.WriteLine($"DA: {DA}");
        Console.WriteLine($"HRA: {HRA}");
        Console.WriteLine($"Total Salary: {CalculateSalary()}");
    }
}

class Program
{
    static void Main()
    {
        // Taking user input for Basic Salary and TA
        Console.Write("Enter Basic Salary: ");
        double basicSalary = double.Parse(Console.ReadLine());

        Console.Write("Enter TA (Travel Allowance): ");
        double ta = double.Parse(Console.ReadLine());

        // Creating a Salary object using the constructor with default DA and HRA
        Salary employeeSalary = new Salary(basicSalary, ta);

        // Display the salary details
        employeeSalary.DisplaySalary();
    }
}

-------------------------------------------------------------------------------

18.	Write a program to implement multilevel inheritance from following figure. Accept and display data for one student.
Ans.
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

 
