using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnalysisWordsInDatabaseMultithread
{
    /// <summary>
    /// Looks for the longest word in the text.
    /// </summary>
    internal class LongestWord
    {
        internal string LongestWordProperty { get; set; }

        // Splits the text.
        List<string> words = new List<string>();

        /// <summary>
        /// Will look for the longest word in the text.
        /// </summary>
        internal string LookForLongestWord(string text)
        {
            words = text.Split(' ', '.', ',', ';', ':').ToList();

            if(text != "")
            {
                DeleteFaultyChars();
            }
            else
            {
                MessageBox.Show("Text is empty");
            }


            // Creates a dictionary wich we will use to loop through.
            // With a int to give each string a number.
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            int dictionaryNumbers = 0;

            // Char array to store the chars of a word in.
            char[] characters;

            // Int to see or we need to replace the longest word or not.
            int highestNumber = 0;


            // Goes over the array of words.
            // And puts them in the Dictionary.
            foreach (string word in words)
            {
                dictionaryNumbers++;
                dictionary[word] = dictionaryNumbers;
            }

            // Splits the dictionary words in char array.
            // Goes over the array to see how many chars there are in that word.
            // Sets the longest word to a string called "longestWord".
            foreach(var word in dictionary)
            {
                int amountOfChars = 0;

                characters = word.Key.ToCharArray();

                for (int i = 0; i < characters.Length; i++)
                {
                    amountOfChars++;
                }

                if (amountOfChars > highestNumber)
                {
                    string charToWord = new string(characters);

                    highestNumber = amountOfChars;
                    LongestWordProperty = charToWord;

                }


            }

            return LongestWordProperty;
        }

        /// <summary>
        /// Will Delete any faulty characters.
        /// </summary>
        private void DeleteFaultyChars()
        {
            // Loops over all the words in the words list.
            for (int i = 0; i < words.Count; i++)
            {
                // If a string in the list is only "". We delete it.
                if (words[i] == "")
                {
                    words.RemoveAt(i);
                }

                
                // If the last element is "" and deleted.
                // We go back 1 count. To make sure we don't have an ArgumentOutOfRangeException.
                // in other words we check a index thats outside of the list.
                if(i == words.Count)
                {
                    i--;
                }

                // If the any of the words contains any of these char,
                // we will split up that word.
                // we then remove that char from the word.
                // and put it back in the list.
                if (words[i].Contains("?") || words[i].Contains("@") || words[i].Contains("!") || words[i].Contains("#")
                    || words[i].Contains("$") || words[i].Contains("%") || words[i].Contains("^") || words[i].Contains("&")
                    || words[i].Contains("*") || words[i].Contains("<") || words[i].Contains(">") || words[i].Contains("\n")
                    || words[i].Contains("\r") || words[i].Contains("/") || words[i].Contains(";") || words[i].Contains(":"))
                {
                    // split the word into a char list
                    List<char> splitWord = words[i].ToList();

                    // stringbuilder to help us put back the chars in a string
                    StringBuilder wordToList = new StringBuilder();

                    // removes the word from the words List.
                    // later we will add it again.
                    words.RemoveAt(i);


                    // goes over each individual char form the word.
                    // to find the forbidden char.
                    for (int q = 0; q < splitWord.Count; q++)
                    {
                        if (splitWord[q] == '?' || splitWord[q] == '@' || splitWord[q] == '#' || splitWord[q] == '$'
                            || splitWord[q] == '%' || splitWord[q] == '^' || splitWord[q] == '&' || splitWord[q] == '*'
                            || splitWord[q] == '<' || splitWord[q] == '>' || splitWord[q] == '\n' || splitWord[q] == '\r'
                            || splitWord[q] == '/' || splitWord[q] == ';' || splitWord[q] == ':')
                        {
                            // removes the char.
                            splitWord.RemoveAt(q);


                            // puts q back by 1.
                            // this is so we can loop over a spot twice.
                            // and we wont miss any chars.
                            // example: spot 8 in q is a (<) and spot 9 aswell.
                            // then if we delete spot 8, spot 9 becomes the new 8.
                            // so we want to go back to loop 7. and loop through 8 again.
                            // in order to delete both (<) (<)
                            q--;
                        }
                    }

                    // puts back the char in a word, with the stringbuilder.
                    foreach (var item in splitWord)
                    {
                        wordToList.Append(item);
                    }

                    // puts back the word into the list.
                    words.Insert(i, wordToList.ToString());
                }
                
            }
        }
    }
}
