using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnalysisWordsInDatabaseMultithread
{
    /// <summary>
    /// Looks for the word thats most used in the text.
    /// And returns it.
    /// </summary>
    internal class MostUsedWord
    {
        internal string WordForLabel { get; set; }


        /// <summary>
        /// Looks for the most used wordt in the text.
        /// </summary>
        internal string LookForMostUsedWord(string text)
        {
            List<string> words = text.Split(' ', '.', ',').ToList();

            for(int i = 0; i < words.Count; i++)
            {
                if(words[i] == "")
                {
                    words.RemoveAt(i);
                }
            }



            // Make a Dictionary, string, int.
            // Here we store the value's we use to see wich word is most used.
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string mostUsedWord = null;
            int timesInDictionary = 0;

            
            foreach (var word in words)
            {

                dictionary.TryGetValue(word, out int number);
                number += 1;

                // Checks or the words is more then once in the dictionary.
                // If so timesInDictionary is equal to the number.
                // And mostUsedWord is equal to that word.
                if(number > timesInDictionary)
                {
                    timesInDictionary = number;
                    mostUsedWord = word;
                }
                // Puts the word in the Dictionary, and gives it a number.
                dictionary[word] = number;
            }

            return WordForLabel = mostUsedWord;
        }
    }
}
