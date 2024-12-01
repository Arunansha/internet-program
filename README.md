# internet-program

1.	Write a program using C# to Generate Fibonacci series using Conditional statements and loop.
Ans.
using System;

class FibonacciSeries
{
    static void Main()
    {
        Console.Write("Enter the number of terms: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0, b = 1, c;

        Console.Write("Fibonacci Series: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
    }
}

-------------------------------------------------------------------------------
2.	Write a program using C# to generate the following pattern using Conditional statements and loop.
Ans.
using System;

class Pattern
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }

            for (int j = i - 1; j >= 1; j--)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }
}
--------------------------------------------------------------------------------
3.	Write a program using C# to test for prime numbers using Conditional statements and loop.
Ans.
using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (num <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine(num + " is a prime number.");
        }
        else
        {
            Console.WriteLine(num + " is not a prime number.");
        }
    }
}



-------------------------------------------------------------------------------
4.	Write a program using C# to reverse a number and find sum of digits of the number using Conditional statement and loop.
Ans.
using System;

class ReverseAndSumDigits
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int reversedNum = 0, sum = 0;
        int originalNum = num;

        while (num > 0)
        {
            int digit = num % 10;
            reversedNum = reversedNum * 10 + digit;
            sum += digit;
            num /= 10;
        }

        Console.WriteLine("Reversed number: " + reversedNum);
        Console.WriteLine("Sum of digits: " + sum);
    }
}
-------------------------------------------------------------------------------

5.	Write a program to declare a class ‘staff’ having data members as name and post. Accept data for 5 staffs and display names of staff who are HOD.
Ans.
using System;

class Staff
{
    public string Name;
    public string Post;

    public void GetStaffDetails()
    {
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();

        Console.Write("Enter Post: ");
        Post = Console.ReadLine();
    }

    public void DisplayHOD()
    {
        if (Post.ToLower() == "hod" || Post.ToUpper() == "HOD")
        {
            Console.WriteLine(Name);
        }
    }
}

class Program
{
    static void Main()
    {
        Staff[] staffArray = new Staff[5];

        for (int i = 0; i < 5; i++)
        {
            staffArray[i] = new Staff();
            staffArray[i].GetStaffDetails();
        }

        Console.WriteLine("HODs:");
        for (int i = 0; i < 5; i++)
        {
            staffArray[i].DisplayHOD();
        }
    }
}

-------------------------------------------------------------------------------
6.	Write a program to declare class “Distance” have data members dist1, dist2 and dist3. Initialize the two data members using constructor and store their addition in third data member using method and display addition result.
Ans.
using System;

class Distance
{
    public int dist1, dist2, dist3;

    public Distance(int d1, int d2)
    {
        dist1 = d1;
        dist2 = d2;
        dist3 = dist1 + dist2;
    }

    public void DisplayDistance()
    {
        Console.WriteLine("The sum of distances is: " + dist3);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter distance 1: ");
        int d1 = int.Parse(Console.ReadLine());

        Console.Write("Enter distance 2: ");
        int d2 = int.Parse(Console.ReadLine());

        Distance distanceObj = new Distance(d1, d2);
        distanceObj.DisplayDistance();
    }
}


-------------------------------------------------------------------------------
7.	Write a program using overloading to swap two integer numbers and swap two float numbers.
Ans.
using System;

class Swap
{
    public void SwapIntegers(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public void SwapFloats(ref float a, ref float b)
    {
        float temp = a;
        a = b;
        b = temp;
    }
}

class Program
{
    static void Main()
    {
        Swap swapper = new Swap();

        Console.Write("Enter two integer numbers: ");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        swapper.SwapIntegers(ref num1, ref num2);
        Console.WriteLine("Swapped integer values: a = " + num1 + ", b = " + num2);

        Console.Write("Enter two float numbers: ");
        float num3 = float.Parse(Console.ReadLine());
        float num4 = float.Parse(Console.ReadLine());
        swapper.SwapFloats(ref num3, ref num4);
        Console.WriteLine("Swapped float values: a = " + num3 + ", b = " + num4);
    }
}

-------------------------------------------------------------------------------
8.	Write a program to implement single inheritance from following figure. Accept and display data for object of Table.
Ans.
using System;

class Furniture
{
    public string Material;
    public int Price;

    public void GetFurnitureDetails()
    {
        Console.Write("Enter Material: ");
        Material = Console.ReadLine();

        Console.Write("Enter Price: ");
        Price = int.Parse(Console.ReadLine());
    }

    public void DisplayFurnitureDetails()
    {
        Console.WriteLine("Material: " + Material);
        Console.WriteLine("Price: " + Price);
    }
}

class Table : Furniture
{
    public int Height;
    public int SurfaceArea;

    public void GetTableDetails()
    {
        Console.Write("Enter Height: ");
        Height = int.Parse(Console.ReadLine());

        Console.Write("Enter Surface Area: ");
        SurfaceArea = int.Parse(Console.ReadLine());
    }

    public void DisplayTableDetails()
    {
        DisplayFurnitureDetails();
        Console.WriteLine("Height: " + Height);
        Console.WriteLine("Surface Area: " + SurfaceArea);
    }
}

class Program
{
    static void Main()
    {
        Table table = new Table();

        table.GetFurnitureDetails();
        table.GetTableDetails();

        table.DisplayTableDetails();
    }
}

 -------------------------------------------------------------------------------                
9.	 Define a class ‘salary’ which will contain member variable Basic, TA, DA, HRA. Write a program using Constructor with default values for DA and HRA and calculate the salary of the employee.
Ans.
using System;

class Salary
{
    public int Basic, TA, DA, HRA;

    public Salary(int basic, int ta)
    {
        Basic = basic;
        TA = ta;
        DA = 10; // Default value for DA
        HRA = 15; // Default value for HRA
    }

    public int CalculateSalary()
    {
        return Basic + TA + (Basic * DA / 100) + (Basic * HRA / 100);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter basic salary: ");
        int basicSalary = int.Parse(Console.ReadLine());

        Console.Write("Enter TA: ");
        int ta = int.Parse(Console.ReadLine());

        Salary employeeSalary = new Salary(basicSalary, ta);
        int totalSalary = employeeSalary.CalculateSalary();

        Console.WriteLine("Total Salary: " + totalSalary);
    }
}

-------------------------------------------------------------------------------

10.	Write a program to implement multilevel inheritance from following figure. Accept and display data for one student.
Ans.
using System;

class Student
{
    public int Roll_no;
    public string Name;

    public void GetStudentDetails()
    {
        Console.Write("Enter Roll No: ");
        Roll_no = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        Name = Console.ReadLine();
    }

    public void DisplayStudentDetails()
    {
        Console.WriteLine("Roll No: " + Roll_no);
        Console.WriteLine("Name: " + Name);
    }
}

class Test : Student
{
    public int Marks1, Marks2;

    public void GetTestMarks()
    {
        Console.Write("Enter Marks1: ");
        Marks1 = int.Parse(Console.ReadLine());

        Console.Write("Enter Marks2: ");
        Marks2 = int.Parse(Console.ReadLine());
    }

    public void DisplayTestMarks()
    {
        Console.WriteLine("Marks1: " + Marks1);
        Console.WriteLine("Marks2: " + Marks2);
    }
}

class Result : Test
{
    public int Total;

    public void CalculateTotal()
    {
        Total = Marks1 + Marks2;
    }

    public void DisplayResult()
    {
        DisplayStudentDetails();
        DisplayTestMarks();
        Console.WriteLine("Total Marks: " + Total);
    }
}

class Program
{
    static void Main()
    {
        Result result = new Result();

        result.GetStudentDetails();
        result.GetTestMarks();
        result.CalculateTotal();

        result.DisplayResult();
    }
}
