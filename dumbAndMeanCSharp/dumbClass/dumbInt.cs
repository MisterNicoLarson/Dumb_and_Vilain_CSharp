using System;
using System.Collections.Generic;
using System.Linq;

class dumbInt
{
    /// <summary>
    /// Adds two integers.
    /// </summary>
    /// <param name="A">The first integer.</param>
    /// <param name="B">The second integer.</param>
    /// <returns>The sum of the two integers.</returns>
    /// <exception cref="System.Exception">Thrown when the input is not an integer.</exception>
    public static int addTwoNumber(int A, int B)
    {
        try
        {
            return A + B;
        }
        catch (System.Exception)
        {
            Console.WriteLine("Must be int type");
            throw;
        }
    }

    /// <summary>
    /// Multiplies two double-precision floating-point numbers.
    /// </summary>
    /// <param name="A">The first double-precision floating-point number.</param>
    /// <param name="B">The second double-precision floating-point number.</param>
    /// <returns>The product of the two numbers.</returns>
    /// <exception cref="Exception">Thrown when an error occurs.</exception>
    public static double productTwoNumber(double A, double B)
    {
        try
        {
            return A * B;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error information : " + ex.Message);
            throw;
        }
    }

    /// <summary>
    /// Determines whether a number is even or odd.
    /// </summary>
    /// <param name="unNbr">The number to check.</param>
    /// <returns>"Even" if the number is even, "Odd" if the number is odd.</returns>
    public static string isEvenOrOdd(int unNbr)
    {
        if (unNbr % 2 == 0)
        {
            return "Even";
        }
        else
        {
            return "Odd";
        }
    }

    /// <summary>
    /// Finds the highest number in a list of double-precision floating-point numbers.
    /// </summary>
    /// <param name="listNumber">The list of numbers.</param>
    /// <returns>The highest number in the list.</returns>
    /// <exception cref="ArgumentException">Thrown when the list is empty.</exception>
    public static double theHighNumber(List<double> listNumber)
    {
        if (listNumber == null || listNumber.Count == 0)
        {
            throw new ArgumentException("The list cant be empty");
        }

        double max = listNumber[0];

        for (int i = 1; i < listNumber.Count; i++)
        {
            if (listNumber[i] > max)
            {
                max = listNumber[i];
            }
        }
        return max;
    }

    /// <summary>
    /// Calculates the factorial of a number.
    /// </summary>
    /// <param name="i">The number to calculate the factorial of.</param>
    /// <returns>The factorial of the number.</returns>
    public static int factorielOfNbr(int i)
    {
        if (i == 0 || i == 1)
        {
            return 1;
        }

        return i * factorielOfNbr(i - 1);
    }

    /// <summary>
    /// Generates the multiplication table for a given number.
    /// </summary>
    /// <param name="unNbr">The number to generate the multiplication table for.</param>
    /// <returns>A string representing the multiplication table.</returns>
    public static string multiplicationTable(double unNbr)
    {
        string table = "";
        for (int i = 1; i <= 10; i++)
        {
            table += $"{i} x {unNbr} = {i * unNbr}{Environment.NewLine}";
        }
        return table;
    }

    /// <summary>
    /// Calculates the sum of the digits of a number.
    /// </summary>
    /// <param name="a">The number to calculate the sum of the digits for.</param>
    /// <returns>The sum of the digits of the number.</returns>
    public static int sumDigitNumber(int a)
    {
        string convertedNumber = a.ToString();

        if (convertedNumber.Length == 1)
        {
            return a;
        }
        else
        {
            return convertedNumber.Sum(x => int.Parse(x.ToString()));
        }
    }

    /// <summary>
    /// Determines whether a number is a prime number.
    /// </summary>
    /// <param name="a">The number to check.</param>
    /// <returns>True if the number is a prime number, false otherwise.</returns>
    public static bool isPrimeNumber(int a)
    {
        if (a <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(a); i++)
        {
            if (a % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Reverses the digits of a number.
    /// </summary>
    /// <param name="a">The number to reverse.</param>
    /// <returns>The number with its digits reversed.</returns>
    public static int reverseNumber(int a)
    {
        bool isNegative = a < 0;
        a = Math.Abs(a);

        string convertedNumber = a.ToString();
        string newNumber = "";

        for (int i = convertedNumber.Length - 1; i >= 0; i--)
        {
            newNumber += convertedNumber[i];
        }

        int result = int.Parse(newNumber);

        if (isNegative)
        {
            result = -result;
        }

        return result;
    }

    /// <summary>
    /// Converts a temperature from Celsius to Fahrenheit.
    /// </summary>
    /// <param name="a">The temperature in Celsius.</param>
    /// <returns>The temperature in Fahrenheit.</returns>
    public static double celsiusToFahrenheit(double a)
    {
        return (a * 1.8) + 32;
    }
}
