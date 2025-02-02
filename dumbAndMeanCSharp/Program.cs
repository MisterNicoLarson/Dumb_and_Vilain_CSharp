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
        
        // Test SumElementList
        List<int> listNumber = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Sum of elements in the list: {dumbList.SumElementList(listNumber)}");

        // Test RemoveElement
        List<string> words = new List<string> { "apple", "banana", "cherry" };
        List<string> updatedWords = dumbList.RemoveElement(words, "banana");
        Console.WriteLine("List after removing 'banana':");
        foreach (var word in updatedWords)
        {
            Console.WriteLine(word);
        }

        // Test FusionTwoList
        List<int> list1 = new List<int> { 1, 2, 3 };
        List<int> list2 = new List<int> { 4, 5, 6 };
        List<int> mergedList = dumbList.FusionTwoList(list1, list2);
        Console.WriteLine("Merged list:");
        foreach (var item in mergedList)
        {
            Console.WriteLine(item);
        }

        // Test CountOccurrenceInList
        List<int> occurrenceList = new List<int> { 1, 2, 2, 3, 4, 2 };
        int count = dumbList.CountOccurrenceInList(occurrenceList, 2);
        Console.WriteLine($"Occurrences of 2 in the list: {count}");

        // Test ReverseList
        List<int> reverseList = new List<int> { 1, 2, 3, 4, 5 };
        List<int> reversedList = dumbList.ReverseList(reverseList);
        Console.WriteLine("Reversed list:");
        foreach (var item in reversedList)
        {
            Console.WriteLine(item);
        }

        // Test ElementExistsInList
        List<int> existList = new List<int> { 1, 2, 3, 4, 5 };
        bool exists = dumbList.ElementExistsInList(existList, 3);
        Console.WriteLine($"Does the element 3 exist in the list? {exists}");

        // Test UniqueElementInList
        List<int> uniqueList = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        List<int> uniqueElements = dumbList.UniqueElementInList(uniqueList);
        Console.WriteLine("Unique elements in the list:");
        foreach (var item in uniqueElements)
        {
            Console.WriteLine(item);
        }

        // Test SortList with integers
        List<int> intList = new List<int> { 5, 3, 8, 1, 2 };
        List<int> sortedIntList = dumbList.SortList(intList);
        Console.WriteLine("Sorted integer list:");
        foreach (var item in sortedIntList)
        {
            Console.WriteLine(item);
        }

        // Test SortList with floats
        List<float> floatList = new List<float> { 5.5f, 3.3f, 8.8f, 1.1f, 2.2f };
        List<float> sortedFloatList = dumbList.SortList(floatList);
        Console.WriteLine("Sorted float list:");
        foreach (var item in sortedFloatList)
        {
            Console.WriteLine(item);
        }

        // Test SortList with doubles
        List<double> doubleList = new List<double> { 5.5, 3.3, 8.8, 1.1, 2.2 };
        List<double> sortedDoubleList = dumbList.SortList(doubleList);
        Console.WriteLine("Sorted double list:");
        foreach (var item in sortedDoubleList)
        {
            Console.WriteLine(item);
        }

        // Test ConcatLists
        List<int> concatList1 = new List<int> { 1, 2, 3 };
        List<int> concatList2 = new List<int> { 4, 5, 6 };
        List<int> concatenatedList = dumbList.ConcatLists(concatList1, concatList2);
        Console.WriteLine("Concatenated list:");
        foreach (var item in concatenatedList)
        {
            Console.WriteLine(item);
        }
    }
}
