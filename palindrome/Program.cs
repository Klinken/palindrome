using System;
using System.Text.RegularExpressions;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string[] wordsToCheck = new string[5];

            // Methods

            bool checkWord(string word)
            {
                char[] wordToArray = word.ToCharArray();

                //Reversing the array
                Array.Reverse(wordToArray);

                string reversedWord = String.Join("", wordToArray).ToLower();

                if (word.ToLower() == reversedWord) {

                    return true;

                }

                return false;
       
            }

            void getWordFromUser(int numberInLine, string text)
            {
                Regex regex = new Regex(@"\ ");

                Console.Write(text);

                string wordToAdd = Console.ReadLine();

                if (regex.IsMatch(wordToAdd))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("Please only one word and no spaces");

                    Console.ResetColor();

                    getWordFromUser(numberInLine, text);

                }
                else
                {
                    wordsToCheck[numberInLine] = wordToAdd;
                }

            }

            // Execution

            //Ask the user how many word they wish to check
            Console.WriteLine("Welcome to the palindrome-checker!\n");


            //First we get the words from the user
            for (int i = 0; i < wordsToCheck.Length; i++)
            {
                getWordFromUser(i, $"#{i + 1} word to check: ");
            }

            Console.WriteLine("");

            //Then we check the words and inform the user
            for (var i = 0; i < wordsToCheck.Length; i++)
            {

                if (checkWord(wordsToCheck[i]))
                {
                    Console.WriteLine($"{wordsToCheck[i]} is a palindrome");

                } else
                {
                    Console.WriteLine($"{wordsToCheck[i]} is not palindrome");

                }

            }

        }
    }
}
