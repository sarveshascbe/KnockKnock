using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace KnockKnockTest.Helpers
{
    /// <summary>
    /// String Helper
    /// </summary>
    public class StringHelper
    {
        /// <summary>
        /// Reverse words in a sentence
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns>Words reversed in a sentence</returns>
        public string ReverseWords(string sentence)
        {
            if (String.IsNullOrEmpty(sentence)) return String.Empty;

            var words = sentence.Split(new char[] { ' ' });
            var reversedWords = new StringBuilder();

            if (words.Length == 1) reversedWords.Append(new string(words[0].Reverse().ToArray()));
            else
            {
                for(int i=0;i<words.Length;i++)
                {
                    reversedWords.Append(new string(words[i].Reverse().ToArray()));
                    if (i + 1 < words.Length) reversedWords.Append(" ");
                }
            }

            return reversedWords.ToString();
        }
    }
}