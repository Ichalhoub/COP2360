
using System;
using System.Collections.Generic;
using System.Linq;

namespace FruitDictionaryAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary: fruit names as keys, list of colors as values
            Dictionary<string, List<string>> fruitColors = new Dictionary<string, List<string>>();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("a. Populate Dictionary");
                Console.WriteLine("b. Display Contents");
                Console.WriteLine("c. Remove Key");
                Console.WriteLine("d. Add New Key-Value");
                Console.WriteLine("e. Append Value to Existing Key");
                Console.WriteLine("f. Sort Keys");
                Console.WriteLine("q. Quit");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "a":
                        // Populate with fruit data
                        fruitColors["Apple"] = new List<string> { "Red", "Green" };
                        fruitColors["Banana"] = new List<string> { "Yellow" };
                        fruitColors["Orange"] = new List<string> { "Orange" };
                        Console.WriteLine("Dictionary populated.");
                        break;

                    case "b":
                        // Display using KeyValuePair enumeration
                        Console.WriteLine("Dictionary contents:");
                        foreach (KeyValuePair<string, List<string>> kvp in fruitColors)
                        {
                            Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
                        }
                        break;

                    case "c":
                        Console.Write("Enter key to remove: ");
                        string removeKey = Console.ReadLine();
                        if (fruitColors.Remove(removeKey))
                            Console.WriteLine("Key removed.");
                        else
                            Console.WriteLine("Key not found.");
                        break;

                    case "d":
                        Console.Write("Enter new fruit key: ");
                        string newKey = Console.ReadLine();
                        Console.Write("Enter colors (comma-separated): ");
                        string newValInput = Console.ReadLine();
                        List<string> newVal = newValInput.Split(',').Select(s => s.Trim()).ToList();
                        fruitColors[newKey] = newVal;
                        Console.WriteLine("Added.");
                        break;

                    case "e":
                        Console.Write("Enter existing fruit key: ");
                        string existKey = Console.ReadLine();
                        if (fruitColors.ContainsKey(existKey))
                        {
                            Console.Write("Enter color to append: ");
                            string appendVal = Console.ReadLine();
                            fruitColors[existKey].Add(appendVal);
                            Console.WriteLine("Appended.");
                        }
                        else
                            Console.WriteLine("Key not found.");
                        break;

                    case "f":
                        // Sort keys and display
                        var sortedKeys = fruitColors.Keys.OrderBy(k => k).ToList();
                        Console.WriteLine("Sorted fruit keys:");
                        foreach (string key in sortedKeys)
                        {
                            Console.WriteLine(key);
                        }
                        break;

                    case "q":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
