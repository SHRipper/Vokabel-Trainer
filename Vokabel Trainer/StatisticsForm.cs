using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vokabel_Trainer
{
    public partial class StatisticsForm : Form
    {
        int correctWordsCounter;
        int falseWordsCounter;

        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void setCorrectWordsCounter(int correctWords)
        {
            this.correctWordsCounter = correctWords;
        }
        private int getCorrectWordsCounter()
        {
            return this.correctWordsCounter;
        }
        private void setFalseWordCounter(int falseWords)
        {
            this.falseWordsCounter = falseWords;
        }
        private int getFalseWordsCounter()
        {
            return this.falseWordsCounter;
        }
        public string hi()
        {
            return "hallo";
        }
    }
}
