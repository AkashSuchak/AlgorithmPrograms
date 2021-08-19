using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class UserChoice
    {
        public UserChoice()
        {
            //Variable
            int userChoice;

            //Display Message
            Console.WriteLine("Press - 1. Permutation of Strng");
            Console.WriteLine("Press - 2. Binary Search");
            Console.WriteLine("Press - 3. Insertion Sort ");
            Console.WriteLine("Press - 4. Bubble Sort ");
            Console.WriteLine("Press - 0. Exit");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Enter your choice number : ");
            userChoice = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            switch (userChoice)
            {
                case 1:
                    String str = "ABC";
                    int n = str.Length;
                    Console.WriteLine(":: Permutation Of String - {0} ::", str);
                    Console.WriteLine("Recursive Manner ::");
                    Console.WriteLine("----------------------------------");
                    Permutation permutation = new Permutation();                    
                    permutation.Permute(str, 0, n - 1);
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine(":: Permutation Of String - {0} ::", str);
                    Console.WriteLine("Iterative Manner ::");
                    Console.WriteLine("----------------------------------");
                    permutation.IterationPermutation(str);
                    break;

                case 2:
                    Console.WriteLine(":: Binary Search To Find a Word ::");
                    Console.WriteLine("----------------------------------");
                    BinarySearch binarySearch = new BinarySearch();
                    binarySearch.inputArray();
                    break;

                case 3:
                    Console.WriteLine(":: Insertion Sort ::");
                    Console.WriteLine("----------------------------------");
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.TakeFileData();
                    break;
                case 4:
                    Console.WriteLine(":: Bubble Sort ::");
                    Console.WriteLine("----------------------------------");
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.TakeFileData();
                    break;
                default:
                    Console.WriteLine(" Invalid number..");
                    break;
            }
        }
    }
}
