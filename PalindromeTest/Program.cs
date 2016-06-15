using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * PALINDROME TEST:
 * A palindrome is a word, phrase, number, or other sequence of characters which reads
 * the same backward or forward. Write a function in C# to check to see if the given string 
 * is a palindrome. The function should return a boolean value. Be sure to ignore spaces and
 * punctuation. The following example should return true: IsPalindrome("Taco Cat");
 */

/*
 * DESCRIPTION:
 * In this program I use an index, i, that starts on the first letter of the string, and a
 * second index, j, that starts on the last letter of the string.  I check to see if these
 * values are the same.  If they are not the same then return false because it is no longer a
 * palindrome.  If they are the same then I add 1 to i, and subtract 1 from j.  Repeat until done.
 * I ignore spaces and set the string to lowercase.
  
 - Jordan Marx (2016)
 */

namespace PalindromeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test string
            string testString = "Taco Cat";

            // Test boolean for the function IsPalindrome
            bool isPalindrome = false;

            // Set the boolean to the function IsPalindrome
            isPalindrome = IsPalindrome(testString);

            // Print the result
            Console.WriteLine(isPalindrome);

        }
    
        // Function that returns true if the word/phrase is a palindrome.
        // In depth description at the top.
        public static bool IsPalindrome(string str)
        {
            // Set the string to lowercase
            string givenString = str.ToLower();

            // Index starting at the first char of the string
            int i = 0;

            // Index starting at the last char of the string
            int j = givenString.Length - 1;


            // While i < j.
            // There is no reason to check i==j because it will always equal.
            while(i < j)
            {
                // If the chars at each index are not spaces
                if (!char.IsWhiteSpace(givenString[i]) && !char.IsWhiteSpace(givenString[j]))
                {

                    // If the chars at each index do not equal each other
                    if (givenString[i] != givenString[j])
                    {
                        // Return false
                        return false;
                    }
                    

                    // Add 1 to i
                    i++;

                    // Subtract 1 from j
                    j--;
                }
                // This means a char at an index was a space
                else
                {
                    // If givenString[i] was a space
                    if(char.IsWhiteSpace(givenString[i]))
                    {
                        // Add 1 to i
                        i++;
                    }
                    // givenString[j] was a space
                    else
                    {
                        // Subtract 1 from j
                        j--;
                    }
                }
            }

            // Return true
            return true;
        }

    }
}
