using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AlgorithmPrograms
{
    class BubbleSort
    {
        static void Bubble(int[] array)
        {
            //Variable
            int temp;

            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        //Swapping
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            //Display
            Console.WriteLine("\n\nAfter Bubble Sort ::");
            Console.WriteLine("-------------------------");            
            foreach (int p in array)
                Console.Write(p + " ");
            Console.Read();
        }
        public void TakeFileData()
        {
            //Read File Words 
            string wordList = File.ReadAllText(@"C:\Users\DELL\source\repos\AlgorithmPrograms\AlgorithmPrograms\BubbleInputFile.txt");
            Console.WriteLine("Text File contains Numbers : ");

            //Split by comma
            int[] words = wordList.Split(',').Select(Int32.Parse).ToArray(); ;
            foreach (int data in words)
            {
                Console.Write(data + " ");
            }

            //Calling Method
            Bubble(words);

        }
    }
}
