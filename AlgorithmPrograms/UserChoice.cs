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
            Console.WriteLine("Press - 1. Binary Search");
            Console.WriteLine("Press - 2. Insertion Sort ");
            Console.WriteLine("Press - 0. Exit");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Enter your choice number : ");
            userChoice = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine(":: Binary Search To Find a Word ::");
                    Console.WriteLine("----------------------------------");
                    BinarySearch binarySearch = new BinarySearch();
                    binarySearch.inputArray();
                    break;

                case 2:
                    Console.WriteLine(":: Insertion Sort ::");
                    Console.WriteLine("----------------------------------");
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.TakeFileData();
                    break;
                default:
                    Console.WriteLine(" Invalid number..");
                    break;
            }
        }
    }
}
