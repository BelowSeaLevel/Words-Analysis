using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnalysisWordsInDatabaseMultithread
{
    /// <summary>
    /// Calculates the average length of all the words.
    /// </summary>
    public class AverageLength
    {
        internal int AverageLengthWords { get; set; }


        /// <summary>
        /// Looks for the average length of all the words.
        /// </summary>
        internal void LookForAverageLength(string text)
        {
            // Splits the text in a string array
            string[] words = text.Split(' ', ',', '.');
            char[] characters;
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            int amountOfWords = 0;
            int length = 0;


            foreach (var item in words)
            {
                characters = item.ToCharArray();


                int num = 0;

                foreach (var character in characters)
                {
                    num++;
                }


                dictionary[item] = num;
                length += num;
                amountOfWords++;
            }

            AverageLengthWords = length / amountOfWords;




        }

    }
}
