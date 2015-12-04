using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vokabel_Trainer
{
    class Words
    {
        public int line { get; set; }
        public string[] germanWords { get; set; }
        public string englishWord { get; set; }
        public int usedIncorrect { get; set; }
        public int usedCorrect { get; set; }

        public Words()
        {
            this.line = 0;
            setGermanWords(new string[] { });
            this.englishWord = "";
            this.usedIncorrect = 0;
            this.usedCorrect = 0;
        }

        public void setGermanWords(string[] words)
        {
            int germanWordsSize = 0;
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i] != null)
                {
                    germanWordsSize++;
                }
            }
            germanWords = new string[germanWordsSize];
            //germanWords = new string[germanWordsSize];
            for (int i = 0; i < germanWords.Length; i++)
            {
                this.germanWords[i] = words[i + 1];
            }
        }
        public string getGermanWordsAsString()
        {
            string germanWords = "";
            foreach (string s in this.germanWords)
            {
                germanWords += s + ", ";
            }
            germanWords = germanWords.Substring(0, germanWords.Length - 2);
            return germanWords;
        }
        public string getGermanWord(int index)
        {
            return this.germanWords[index];
        }
    }
}
