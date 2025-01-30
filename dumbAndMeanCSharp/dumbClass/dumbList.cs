/*
    Fusionner deux listes
    Crée un programme qui fusionne deux listes d'entiers et les retourne sous forme d'une seule liste.

    Trier une liste
    Crée un programme qui trie les éléments d'une liste d'entiers par ordre croissant.
*/

class dumbList{
    /// <summary>
    /// Calculates the sum of all elements in a list of integers.
    /// </summary>
    /// <param name="listNumber">The list of integers to sum.</param>
    /// <returns>The sum of all elements in the list.</returns>
    public static int SumElementList(List<int> listNumber)
    {
        int sumNbr = 0;
        for (int i = 0; i < listNumber.Count; i++)
        {
            sumNbr += listNumber[i];
        }
        return sumNbr;
    }

    /// <summary>
    /// Removes the first occurrence of a specified element from a list of strings.
    /// </summary>
    /// <param name="listElement">The list of strings from which to remove the element.</param>
    /// <param name="element">The element to remove from the list.</param>
    /// <returns>The list of strings after removing the specified element.</returns>
    public static List<string> RemoveElement(List<string> listElement, string element)
    {
        listElement.Remove(element);
        return listElement;
    }

    /// <summary>
    /// Merges two lists of a generic type by adding elements from the shorter list to the longer list.
    /// </summary>
    /// <typeparam name="T">The type of elements in the lists.</typeparam>
    /// <param name="currentList">The first list of elements.</param>
    /// <param name="newList">The second list of elements.</param>
    /// <returns>The merged list containing all elements from both lists.</returns>
    public static List<T> FusionTwoList<T>(List<T> currentList, List<T> newList)
    {
        int countCurrent = currentList.Count;
        int countNew = newList.Count;

        if (countNew < countCurrent)
        {
            for (int i = 0; i < countCurrent; i++)
            {
                newList.Add(currentList[i]);
            }
            return newList;
        }
        else
        {
            for (int i = 0; i < countNew; i++)
            {
                currentList.Add(newList[i]);
            }
            return currentList;
        }
    }

    /// <summary>
    /// Counts the occurrences of a specified element in a list.
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    /// <param name="myList">The list of elements to search.</param>
    /// <param name="element">The element to count occurrences of.</param>
    /// <returns>The number of occurrences of the specified element in the list.</returns>
    public static int CountOccurrenceInList<T>(List<T> myList, T element)
    {
        List<T> newList = myList.FindAll(e => e.Equals(element));
        return newList.Count;
    }

    /// <summary>
    /// Reverses the order of elements in a list.
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    /// <param name="myList">The list of elements to reverse.</param>
    /// <returns>A new list with the elements in reversed order.</returns>
    public static List<T> ReverseList<T>(List<T> myList)
    {
        List<T> reversedList = new List<T>(myList);
        reversedList.Reverse();
        return reversedList;
    }

    /// <summary>
    /// Checks if a specified element exists in a list.
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    /// <param name="myList">The list of elements to search.</param>
    /// <param name="element">The element to check for existence.</param>
    /// <returns>True if the element exists in the list; otherwise, false.</returns>
    public static bool ElementExistsInList<T>(List<T> myList, T element)
    {
        return myList.Contains(element);
    }

    /// <summary>
    /// Returns a list of unique elements from the given list.
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    /// <param name="myList">The list of elements to search for unique elements.</param>
    /// <returns>A list containing only the unique elements from the input list.</returns>
    public static List<T> UniqueElementInList<T>(List<T> myList)
    {
        List<T> uniqueElementList = new List<T>();
        int sizeList = myList.Count;

        for (int i = 0; i < sizeList; i++)
        {
            T element = myList[i];
            List<T> newList = myList.FindAll(e => e.Equals(element));
            if (newList.Count == 1)
            {
                uniqueElementList.Add(element);
                myList.RemoveAll(e => e.Equals(element));
                sizeList = myList.Count; 
                i--; 
            }
        }
        return uniqueElementList;
    }

    /// <summary>
    /// Sorts the elements of a list of integers in ascending order.
    /// </summary>
    /// <param name="myList">The list of integers to sort.</param>
    /// <returns>A new list with the integers sorted in ascending order.</returns>
    public static List<int> SortList(List<int> myList)
    {
        List<int> sortedList = new List<int>(myList);
        sortedList.Sort();
        return sortedList;
    }

    /// <summary>
    /// Sorts the elements of a list of floats in ascending order.
    /// </summary>
    /// <param name="myList">The list of floats to sort.</param>
    /// <returns>A new list with the floats sorted in ascending order.</returns>
    public static List<float> SortList(List<float> myList)
    {
        List<float> sortedList = new List<float>(myList);
        sortedList.Sort();
        return sortedList;
    }

    /// <summary>
    /// Sorts the elements of a list of doubles in ascending order.
    /// </summary>
    /// <param name="myList">The list of doubles to sort.</param>
    /// <returns>A new list with the doubles sorted in ascending order.</returns>
    public static List<double> SortList(List<double> myList)
    {
        List<double> sortedList = new List<double>(myList);
        sortedList.Sort();
        return sortedList;
    }

    /// <summary>
    /// Merges two lists of integers into a single list.
    /// </summary>
    /// <param name="list1">The first list of integers to merge.</param>
    /// <param name="list2">The second list of integers to merge.</param>
    /// <returns>A new list containing all elements from both input lists.</returns>
    public static List<int> ConcatLists(List<int> list1, List<int> list2)
    {
        List<int> mergedList = new List<int>(list1);
        mergedList.AddRange(list2);
        return mergedList;
    }
}