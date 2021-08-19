using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Permutation
    {
        //Permutation in recursive way
        public void Permute(String str, int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = Swap(str, l, i); //Fixing First Char
                    Permute(str, l + 1, r); 
                    str = Swap(str, l, i); 
                }
            }
        }
        public static String Swap(String a, int i, int j)
        {
            //Variable
            char temp;

            //Char Array
            char[] charArray = a.ToCharArray();
            
            //Swapping Chars
            temp = charArray[i];            
            charArray[i] = charArray[j];            
            charArray[j] = temp;            
            string s = new string(charArray);            
            return s; //return Value
        }
        //Permutation in Iterative Way
        public void IterationPermutation(string str)
        {
            int number = str.Length;
            int fact = Factorial(number);

            for (int i = 0; i < fact; i++)
            {
                StringBuilder stringBuilder = new StringBuilder(str);
                int temp = i;

                for (int div = number; div >= 1; div--)
                {
                    int quotient = temp / div;
                    int remiander = temp % div;
                    
                    Console.Write(stringBuilder[remiander]);                    
                    stringBuilder.Remove(remiander, 1);
                    temp = quotient;
                }
                Console.WriteLine();
            }
        }
        public int Factorial(int number)
        {
            int val = 1;
            for (int i = 2; i <= number; i++)
            {
                val *= i;
            }
            return val; 
        }
    }
}
