using System;
using System.Collections.Generic;
using System.Linq;

class dumbString
{
    /// <summary>
    /// Returns the length of a given string.
    /// </summary>
    /// <param name="sentence">The string to measure.</param>
    /// <returns>The length of the string.</returns>
    public static int lengthSentence(string sentence)
    {
        return sentence.Length;
    }

    /// <summary>
    /// Concatenates two strings.
    /// </summary>
    /// <param name="stringA">The first string.</param>
    /// <param name="stringB">The second string.</param>
    /// <returns>The concatenated string.</returns>
    public static string concatenateTwoString(string stringA, string stringB)
    {
        return stringA + stringB;
    }

    /// <summary>
    /// Checks if a given word is present in a sentence.
    /// </summary>
    /// <param name="word">The word to search for.</param>
    /// <param name="sentence">The sentence to search within.</param>
    /// <returns>True if the word is found in the sentence, false otherwise.</returns>
    public static bool isTheWordInTheSentence(string word, string sentence)
    {
        return sentence.Contains(word);
    }

    /// <summary>
    /// Replaces a word in a sentence with another word.
    /// </summary>
    /// <param name="word">The word to replace with.</param>
    /// <param name="wordToReplace">The word to be replaced.</param>
    /// <param name="sentence">The sentence to perform the replacement in.</param>
    /// <returns>The sentence with the word replaced.</returns>
    public static string replaceWordInSentence(string word, string wordToReplace, string sentence)
    {
        return sentence.Replace(wordToReplace, word);
    }

    /// <summary>
    /// Converts a sentence to uppercase and lowercase.
    /// </summary>
    /// <param name="sentence">The sentence to convert.</param>
    /// <returns>The sentence in uppercase followed by the sentence in lowercase.</returns>
    public static string upperAndLowerSentence(string sentence)
    {
        return $"{sentence.ToUpper()}{Environment.NewLine}{sentence.ToLower()}";
    }

    /// <summary>
    /// Counts the number of vowels in a given sentence.
    /// </summary>
    /// <param name="sentence">The sentence to count vowels in.</param>
    /// <param name="listeChar">The list of characters considered as vowels. Default is {"a", "e", "i", "o", "u", "y"}.</param>
    /// <returns>The number of vowels in the sentence.</returns>
    public static int countVowelSentence(string sentence, List<char> listeChar = null)
    {
        if (listeChar == null)
        {
            listeChar = new List<char> { 'a', 'e', 'i', 'o', 'u', 'y' };
        }

        int nbrVowel = 0;
        foreach (char vowel in listeChar)
        {
            nbrVowel += sentence.Count(f => char.ToLower(f) == vowel);
        }
        return nbrVowel;
    }

    /// <summary>
    /// Reverses the characters in a given string.
    /// </summary>
    /// <param name="sentence">The string to reverse.</param>
    /// <returns>The reversed string.</returns>
    public static string reverseString(string sentence)
    {
        char[] charArray = sentence.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    /// <summary>
    /// Checks if a given string is a palindrome.
    /// </summary>
    /// <param name="word">The string to check.</param>
    /// <returns>True if the string is a palindrome, false otherwise.</returns>
    public static bool isPalindrome(string word)
    {
        int length = word.Length;
        if (dumbInt.isEvenOrOdd(length) == "Even")
        {
            return false;
        }

        for (int i = 0; i < length / 2; i++)
        {
            if (word[i] != word[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// Extracts a substring from a given index to the end of the string.
    /// </summary>
    /// <param name="index">The starting index of the substring.</param>
    /// <param name="sentence">The string to extract the substring from.</param>
    /// <returns>The substring starting from the given index to the end of the string.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the index is out of the range of the string.</exception>
    public static string subText(int index, string sentence)
    {
        if (index < 0 || index >= sentence.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of the range of the string.");
        }

        return sentence.Substring(index);
    }

    /// <summary>
    /// Removes all white spaces from a given string.
    /// </summary>
    /// <param name="sentence">The string to remove white spaces from.</param>
    /// <returns>The string with all white spaces removed.</returns>
    public static string removeWhiteSpace(string sentence)
    {
        return sentence.Replace(" ", "");
    }
}
