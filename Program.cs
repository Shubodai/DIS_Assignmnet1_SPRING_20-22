/*
 * Name: Shubodai reddy Chalamalla
 * Date: 01/23/2022
 * Description: Solution for 6 questions mentioned in DIS:Assignment 1
 * Self Reflection: It took me 20hrs altogether to complete the assignment, The new concepts that I learned in this assignments were String manipulation,Integer Matrix solving
 * It was a great oppurtinity to learn and explore the concepts of strings and arrays.
 */
using System;
using System.Linq;

namespace DIS_Assignmnet1_SPRING_20_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is: {0}", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is " + rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix: {0}", reversed_string);
            Console.WriteLine();

        }
        /* 
<summary>
Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
Example 1:
Input: s = "MumaCollegeofBusiness"
Output: "MmCllgfBsnss"
Example 2:
Input: s = "aeiou"
Output: ""
Constraints:
•	0 <= s.length <= 10000
s consists of uppercase and lowercase letters
</summary>
*/

        private static string RemoveVowels(string s)
        {
            try
            {             
                String final_string = "";
                if (s.Length >= 0 && s.Length <= 10000) // constraint check for length
                {
                    for (int i = 0; i < s.Length; i++) //Iterating through the entire string
                    {
                        if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u') //Checking for presence of vowels(lower case)
                        {
                            final_string = final_string + "";
                        }
                        else if (s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U') //Checking for presence of vowels(upper case)
                        {
                            final_string = final_string + "";
                        }
                        else
                            final_string = final_string + s[i];//Creating the final string / result 
                    }
                }
                    
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /* 
      <summary>
     Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
     A string is represented by an array if the array elements concatenated in order forms the string.
     Example 1:
     Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
     Output: true
     Explanation:
     word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
     word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
     The strings are the same, so return true.
     Example 2:
     Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
     Output: false
     Example 3:
     Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
     Output: true
     </summary>
     */
        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {                
                string s1 = "";//declaring a empty string S1
                foreach (string s in bulls_string1) //using foreach to concatenate the input string s1
                {
                    s1 = s1 + s;
                }
                string s2 = ""; //declaring a empty string S2
                foreach (string s in bulls_string2) //using foreach to concatenate the input string s1
                {
                    s2 = s2 + s;
                }
                if (s1 == s2) //comparision of both the strings s1 & s2
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /*

        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                int x = 0; // variable to store the sum of unique value in array
                int lg = bull_bucks.Length; //getting the length of string
                if (lg >= 1 || lg <= 100)
                {
                    foreach (int a in bull_bucks)
                    {
                        int count = 0;
                        for (int i = 0; i < lg; i++) //iterating through the entire integer array
                        {
                            if (a == bull_bucks[i])
                            {
                                count = count + 1; //adding the unique elements
                            }
                        }
                        if (count == 1) //checking if integer array element with count = 1
                        {
                            x = x + a; // adding unique values to sum
                        }
                    }
                }
                    
                return x;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
             <summary>
            Given a square matrix bulls_grid, return the sum of the matrix diagonals.
            Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
            Example 1:
            Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
            Output: 25
            Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
            Notice that element mat[1][1] = 5 is counted only once.
            Example 2:
            Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
            Output: 8
            Example 3:
            Input: bulls_grid = [[5]]
            Output: 5
            </summary>
             */
        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                int S = 0; //variable to store the sum of diagonal elements in matrix
                int L = bulls_grid.GetLength(0); 
                for (int i = 0; i < L; i++) //iterating through rows
                {
                    for (int j = 0; j < L; j++)//iterating through coloumns
                    {
                        if (j == i || (j + i == L - 1)) //for right diagonal i=j
                                                        //for left diagonal i + j = length of square matrix
                        {
                            S += bulls_grid[i, j];//sum of diagonal element's 
                        }
                    }
                }
                return S;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }
        /*
                 <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.
        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
                */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {               
                string reversedstring = ""; //string to return output
                char[] x = new char[indices.Length]; // storing string in char format
                int[] y = new int[bulls_string.Length]; //to store length of string name : bulls_string
                char[] final = new char[bulls_string.Length]; //creating a character array with length equal to bulls_string
                int z = 0;
                int strLen = bulls_string.Length;
                int indicesLen = indices.Length;
                if(strLen>=1 && strLen<=100 && indicesLen>=1 && indicesLen <= 100) //Length constarint
                {
                    if (bulls_string.Any(char.IsLower)) //lower case constraint
                    {
                        if (indices.Distinct().Count() == indices.Length) //Distinct indices constraint
                        {
                            foreach (char c in bulls_string) //used to traverse through the given string
                            {
                                bool caps = char.IsUpper(c);
                                x[z] = c; // copying each character into char array x
                                z++;
                            }


                            for (int i = 0; i < bulls_string.Length; i++) //mapping the indices to characters app.
                            {
                                final[indices[i]] = x[i];
                            }
                            foreach (char c in final) //to store result
                            {
                                reversedstring = reversedstring + c.ToString(); //converting char c to string using inbuilt function
                            }
                        }
                            
                    }
                    
                }
                
                return reversedstring;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;

            }
        }
        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.
        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".
        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */
        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                String preStr = "";
                int breakpoint = 0; // creating a new integer to store position of char ch
                if (bulls_string6.Length > 1 && bulls_string6.Length < 250)
                {
                    for (int i = 0; i < bulls_string6.Length; i++) // traversing through entire string  
                    {
                        if (bulls_string6[i] == ch) //condition to match string value to given input char
                        {
                            int length = i;
                            breakpoint = 1;
                            while (length >= 0) // copying the string in reverse order in preStr
                            {
                                preStr = preStr + bulls_string6[length];
                                length--;
                            }
                        }
                        if (breakpoint == 1) // copying the remaining part of string to preStr
                        {
                            preStr = preStr + bulls_string6[i];
                        }
                    }
                }

                    
                return preStr;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
 

    