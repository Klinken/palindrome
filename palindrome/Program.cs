using System;

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
                Console.Write(text);

                wordsToCheck[numberInLine] = Console.ReadLine();
            }

            // Execution


            //First we get the words from the user
            for (int i = 0; i < wordsToCheck.Length; i++)
            {
                getWordFromUser(i, $"#{i + 1} word to check: ");
            }

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
