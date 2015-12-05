using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Vokabel_Trainer
{
    public partial class MainForm : Form
    {
        string mode;      
        Words Words;

        public MainForm()
        {
            InitializeComponent();
        }

        private void frmVocalCheck_Load(object sender, EventArgs e)
        {
            Words = new Words();

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Vokabeldatenbank.txt";
            VocabFile.path = path;

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            VocabFile.getTotalLines();

            setMode("english");
            englischDeutschToolStripMenuItem.Checked = true;
            timer1.Interval = 1500;
            btnShowVocab.Enabled = false;
            btnCheckVocab.Enabled = false;
        }

        private void setMode(string mode)
        {
            this.mode = mode;
        }
        private string getMode()
        {
            return this.mode;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tbCheckEnglish.Enabled = false;
            tbCheckGerman.Enabled = true;
            btnCheckVocab.Enabled = true;

            newRndWordFromFile();
            fillTextboxes();
        }

        private void btnCheckVocab_Click(object sender, EventArgs e)
        {
            string userword = tbCheckGerman.Text;

            if (isCorrect(userword))
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = userword + " ist korrekt.";
                btnShowVocab.Enabled = false;
                incrementUsedCorrect();
                // wait until label is cleared again and new word is generated
                timer1_start();
            }
            else
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = userword + " ist leider falsch.";
                incrementUsedIncorrect();
                btnShowVocab.Enabled = true;
            }
        }

        private void incrementUsedIncorrect()
        {
           
            
        }

        private void incrementUsedCorrect()
        {


        }
        private void btnShowVocab_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.Black;

            switch (getMode())
            {
                case "english":
                    // print solution 
                    lblResult.Text = "Die Übersetzung von \"" + Words.englishWord + "\" ist \"" + Words.getGermanWordsAsString() + "\"";
                    break;
                case "german":
                    string germanWord = tbCheckEnglish.Text;
                    lblResult.Text = "Die Übersetzung von \"" + germanWord + "\" ist \"" + Words.englishWord + "\"";
                    break;
            }
            
        }

        private void newRndWordFromFile()
        { 

            // generate random number and read a random line
            Random rnd = new Random();
            int rndWordLine = rnd.Next(0, VocabFile.linesInFile +1);
            string rndLine = "";

            StreamReader sr = new StreamReader(VocabFile.path);
            for (int i = 0; i <= rndWordLine; i++)
            {
                rndLine = sr.ReadLine();
            }
            sr.Close();
            Words.englishWord = rndLine.Split('=')[0];
            string germanWords = rndLine.Split('=')[0].Split(';')[0];
            Words.germanWords = germanWords.Split(',');
            Words.usedCorrect = Convert.ToInt32(rndLine.Split('=')[0].Split(';')[1]);
            Words.usedIncorrect = Convert.ToInt32(rndLine.Split('=')[0].Split(';')[2]);
            Words.line = rndWordLine;

            // clear the textboxes
            tbCheckEnglish.Clear();
            tbCheckGerman.Clear();
        }

        private bool isCorrect(string userword)
        {
            switch (getMode())
            {
                case "german":
                    if (userword.ToLower().Equals(Words.englishWord.ToLower()))
                    {
                        return true;
                    }
                    return false;
                case "english":
                    for (int i = 0; i < Words.germanWords.Length; i++)
                    {
                        if (userword.ToLower().Equals(Words.germanWords[i].ToLower()))
                        {
                            return true;
                        }
                    }
                    return false;
                default:
                    return false;
            }
            
        }
        private void fillTextboxes()
        {
            // clear the textboxes
            tbCheckEnglish.Clear();
            tbCheckGerman.Clear();

            switch (getMode())
            {
                case "german":
                    tbCheckEnglish.Text = Words.germanWords[(new Random()).Next(0,Words.germanWords.Length)];
                    break;
                case "english":
                    tbCheckEnglish.Text =Words.englishWord;
                    break;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblResult.Text = "";
            newRndWordFromFile();
            fillTextboxes();
            timer1.Stop();
        }

        private void timer1_start()
        {
            timer1.Stop();
            timer1.Start();
        }

        private void englischDeutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setMode("english");
            deutschEnglischToolStripMenuItem.Checked = false;
            englischDeutschToolStripMenuItem.Checked = true;
            lblWordEnglish.Text = "Englisch";
            lblWordGerman.Text = "Deutsch";

            resetTextboxes();
        }

        private void deutschEnglischToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setMode("german");
            englischDeutschToolStripMenuItem.Checked = false;
            deutschEnglischToolStripMenuItem.Checked = true;
            lblWordEnglish.Text = "Deutsch";
            lblWordGerman.Text = "Englisch";

            resetTextboxes();
        }
        private void resetTextboxes()
        {
            tbCheckEnglish.Clear();
            tbCheckGerman.Clear();
            tbCheckEnglish.Enabled = true;
        }

        private void statistikAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsForm statistics = new StatisticsForm();
            statistics.Show();
        }

        private void vokabelnBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OverviewForm edit = new OverviewForm();
            edit.Show();
            
        }
        private void tbCheckGerman_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnCheckVocab.PerformClick();
            }
        }
    }
}
