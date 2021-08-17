using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmPrograms
{
    class InsertionSort
    {
        static void Insertion(string[] array)
        {
            //Variables
            int i, j;

            //Insertion Sort
            for (i = 1; i < array.Length; i++)
            {
                string value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }
        public void TakeFileData()
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

            //Calling Method
            Insertion(words);

            //Display
            Console.WriteLine("\n\nAfter Insertion Sort ::");
            Console.WriteLine("-------------------------");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }

    }
}
