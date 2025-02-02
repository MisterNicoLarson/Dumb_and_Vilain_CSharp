/*

    Parcourir un dictionnaire
    Crée un programme qui affiche chaque clé et sa valeur associée dans un dictionnaire.

    Trouver la clé ayant la plus grande valeur
    Crée un programme qui trouve la clé associée à la plus grande valeur dans un dictionnaire.

    Inversement des clés et des valeurs
    Crée un programme qui inverse les clés et les valeurs dans un dictionnaire. Par exemple, une clé devient une valeur, et vice versa.

    Mettre à jour la valeur d'une clé existante
    Crée un programme qui met à jour la valeur d'une clé spécifique dans un dictionnaire.
*/

class dumbDict{
    /// <summary>
    /// Adds elements from a list of tuples to a dictionary.
    /// </summary>
    /// <typeparam name="T">The type of elements in the tuples and dictionary.</typeparam>
    /// <param name="listeDeTuple">The list of tuples to add to the dictionary.</param>
    /// <param name="myDictionary">The dictionary to update.</param>
    /// <returns>The updated dictionary.</returns>
    public static Dictionary<T, T> addElementToDictionary<T>(List<Tuple<T, T>> listeDeTuple, Dictionary<T, T> myDictionary)
    {
        foreach (var tuple in listeDeTuple)
        {
            myDictionary[tuple.Item1] = tuple.Item2;
        }
        return myDictionary;
    }

    /// <summary>
    /// Finds the value associated with a specified key in a dictionary.
    /// </summary>
    /// <typeparam name="T">The type of keys and values in the dictionary.</typeparam>
    /// <param name="myDictionary">The dictionary to search.</param>
    /// <param name="element">The key to find in the dictionary.</param>
    /// <returns>The value associated with the specified key, or the default value if the key is not found.</returns>
    public static T FindElementInDictionary<T>(Dictionary<T, T> myDictionary, T element)
    {
        if (myDictionary.TryGetValue(element, out T value))
        {
            return value;
        }
        else
        {
            throw new KeyNotFoundException($"The key '{element}' was not found in the dictionary.");
        }
    }

    /// <summary>
    /// Removes the element with the specified key from the dictionary.
    /// </summary>
    /// <typeparam name="T">The type of keys and values in the dictionary.</typeparam>
    /// <param name="myDictionary">The dictionary from which to remove the element.</param>
    /// <param name="keyElement">The key of the element to remove.</param>
    /// <returns>The dictionary after removing the specified element.</returns>
    public static Dictionary<T, T> RemoveElement<T>(Dictionary<T, T> myDictionary, T keyElement)
    {
        if (myDictionary.ContainsKey(keyElement))
        {
            myDictionary.Remove(keyElement);
        }
        return myDictionary;
    }

    /// <summary>
    /// Checks if a specified key exists in the dictionary.
    /// </summary>
    /// <typeparam name="T">The type of keys and values in the dictionary.</typeparam>
    /// <param name="myDictionary">The dictionary to search.</param>
    /// <param name="keyElement">The key to check for existence.</param>
    /// <returns>True if the key exists in the dictionary; otherwise, false.</returns>
    public static bool isMyKeyIn<T>(Dictionary<T, T> myDictionary, T keyElement)
    {
        return myDictionary.ContainsKey(keyElement);
    }

    /// <summary>
    /// Merges two dictionaries into a single dictionary.
    /// </summary>
    /// <typeparam name="T">The type of keys and values in the dictionaries.</typeparam>
    /// <param name="dicoA">The first dictionary to merge.</param>
    /// <param name="dicoB">The second dictionary to merge.</param>
    /// <returns>A new dictionary containing all elements from both input dictionaries.</returns>
    public static Dictionary<T, T> Fusion2Dico<T>(Dictionary<T, T> dicoA, Dictionary<T, T> dicoB)
    {
        Dictionary<T, T> mergedDictionary = new Dictionary<T, T>(dicoA);

        foreach (var kvp in dicoB)
        {
            mergedDictionary[kvp.Key] = kvp.Value;
        }

        return mergedDictionary;
    }

    /// <summary>
    /// Transforms a list into a dictionary where each element is a key and its count in the list is the value.
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    /// <param name="superList">The list to transform into a dictionary.</param>
    /// <returns>A dictionary where each element is a key and its count in the list is the value.</returns>
    public static Dictionary<T, int> TransformListIntoDico<T>(List<T> superList)
    {
        Dictionary<T, int> newDico = new Dictionary<T, int>();
        int sizeList = superList.Count;

        for (int i = 0; i < sizeList; i++)
        {
            T element = superList[i];
            if (newDico.ContainsKey(element))
            {
                newDico[element]++;
            }
            else
            {
                newDico[element] = 1;
            }
        }

        return newDico;
    }




}