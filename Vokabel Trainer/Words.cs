using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vokabel_Trainer
{
    class Words
    {
        public int line;
        public string[] germanWords;
        public string englishWord;
        public int usedIncorrect;
        public int usedCorrect;

        public Words()
        {
            this.line = 0;
            this.englishWord = "";
            this.usedIncorrect = 0;
            this.usedCorrect = 0;
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
