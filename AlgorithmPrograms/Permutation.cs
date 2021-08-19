using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Permutation
    {
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
    }
}
