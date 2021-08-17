using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmPrograms
{
    class BinarySearch
    {
        static int BinarySearchWord(String[] array, String userWord)
        {
            int left = 0, right = array.Length - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                int result = userWord.CompareTo(array[middle]);

                // Check if UserWord is present at mid
                if (result == 0)
                    return middle;

                // If UserWord greater, ignore left half
                if (result > 0)
                    left = middle + 1;

                // If UserWord is smaller, ignore right half
                else
                    right = middle - 1;
            }
            return -1;
        }
        public void inputArray()
        {
            //Read File Words 
            string wordList = File.ReadAllText(@"C:\Users\DELL\source\repos\AlgorithmPrograms\AlgorithmPrograms\InputFile.txt");
            Console.WriteLine("Text File contains Words : ");
            
            //Split by comma
            string[] words = wordList.Split(',');
            foreach (string data in words)
            {
                Console.Write(data + " ");
            }
            
            Console.WriteLine("\n\nAfter Sorting Words ::");

            //Sort and Display of an Array
            Array.Sort(words);
            foreach (var item in words)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n-------------------------");
            
            //Taking Word From User to search in array
            Console.Write("\nEnter a Word to search in File:: ");
            String searchTerm = Console.ReadLine();

            //Result of BinarySearchWord
            int result = BinarySearchWord(words, searchTerm);

            //Display Word is Found or Not
            if (result == -1)
                Console.WriteLine("Word not present");
            else
                Console.WriteLine("Word found at index " + result);
        }
    }
}
