using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Test addTwoNumber
        Console.WriteLine($"Lets add 3 and 4 : {dumbInt.addTwoNumber(3, 4)}");

        // Test productTwoNumber
        Console.WriteLine($"Lets see the product of 3.5 and 2 : {dumbInt.productTwoNumber(3.5, 2.0)}");

        // Test isEvenOrOdd
        Console.WriteLine($"Lets see if it's Even or Odd : {dumbInt.isEvenOrOdd(4)}");
        Console.WriteLine($"Lets see if it's Even or Odd : {dumbInt.isEvenOrOdd(7)}");

        // Test theHighNumber
        List<double> numbers = new List<double> { 1.1, 2.2, 3.3, 4.4 };
        Console.WriteLine($"Lets see which is the high number {numbers} : {dumbInt.theHighNumber(numbers)}");

        // Test factorielOfNbr
        Console.WriteLine($"Lets see factorial of 5 : {dumbInt.factorielOfNbr(5)}");

        // Test multiplicationTable
        Console.WriteLine("Test multiplicationTable:");
        Console.WriteLine(dumbInt.multiplicationTable(5));

        // Test sumDigitNumber
        Console.WriteLine($"Let see the sum of the digits in 123 : {dumbInt.sumDigitNumber(123)}");

        // Test isPrimeNumber
        Console.WriteLine("Test isPrimeNumber:");
        Console.WriteLine($"Is primer 5 : {dumbInt.isPrimeNumber(5)}");
        Console.WriteLine($"Is primer 4 : {dumbInt.isPrimeNumber(4)}");

        // Test reverseNumber
        Console.WriteLine("Test reverseNumber:");
        Console.WriteLine($"Reverse 123 : {dumbInt.reverseNumber(123)}");
        Console.WriteLine($"Reverse -123 : {dumbInt.reverseNumber(-123)}");

        // Test celsiusToFahrenheit
        Console.WriteLine("Test celsiusToFahrenheit:");
        Console.WriteLine($" 0C => {dumbInt.celsiusToFahrenheit(0)}F");
        Console.WriteLine($" 100C => {dumbInt.celsiusToFahrenheit(100)}F");

        // Test lengthSentence
        Console.WriteLine("Test lengthSentence:");
        Console.WriteLine($"Length of 'Hello world!' : {dumbString.lengthSentence("Hello world!")}");

        // Test concatenateTwoString
        Console.WriteLine("Test concatenateTwoString:");
        Console.WriteLine($"Concatenate 'Hello' and ' world!' : {dumbString.concatenateTwoString("Hello", " world!")}");

        // Test isTheWordInTheSentence
        Console.WriteLine("Test isTheWordInTheSentence:");
        Console.WriteLine($"Is 'world' in 'Hello world!' : {dumbString.isTheWordInTheSentence("world", "Hello world!")}");
        Console.WriteLine($"Is 'foo' in 'Hello world!' : {dumbString.isTheWordInTheSentence("foo", "Hello world!")}");

        // Test replaceWordInSentence
        Console.WriteLine("Test replaceWordInSentence:");
        Console.WriteLine($"Replace 'world' with 'foo' in 'Hello world!' : {dumbString.replaceWordInSentence("foo", "world", "Hello world!")}");

        // Test upperAndLowerSentence
        Console.WriteLine("Test upperAndLowerSentence:");
        Console.WriteLine($"Upper and lower case of 'Hello world!' : {dumbString.upperAndLowerSentence("Hello world!")}");

        // Test countVowelSentence
        Console.WriteLine("Test countVowelSentence:");
        Console.WriteLine($"Count vowels in 'Hello world!' : {dumbString.countVowelSentence("Hello world!")}");
        Console.WriteLine($"Count vowels in 'AEIOUY' : {dumbString.countVowelSentence("AEIOUY")}");

        // Test reverseString
        Console.WriteLine("Test reverseString:");
        Console.WriteLine($"Reverse 'Hello world!' : {dumbString.reverseString("Hello world!")}");

        // Test isPalindrome
        Console.WriteLine("Test isPalindrome:");
        Console.WriteLine($"Is 'racecar' a palindrome? : {dumbString.isPalindrome("racecar")}");
        Console.WriteLine($"Is 'hello' a palindrome? : {dumbString.isPalindrome("hello")}");

        // Test subText
        Console.WriteLine("Test subText:");
        Console.WriteLine($"Substring from index 6 of 'Hello world!' : {dumbString.subText(6, "Hello world!")}");

        // Test removeWhiteSpace
        Console.WriteLine("Test removeWhiteSpace:");
        Console.WriteLine($"Remove white spaces from 'Hello world!' : {dumbString.removeWhiteSpace("Hello world!")}");
    }
}
