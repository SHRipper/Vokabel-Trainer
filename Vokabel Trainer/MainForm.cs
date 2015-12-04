using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Vokabel_Trainer
{
    public partial class MainForm : Form
    {
        string mode;
        int linesInFile { get; set; }
        VocabFile file;
        Words newWord;
        Words currentWords;
        Words[] wordCollection { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void frmVocalCheck_Load(object sender, EventArgs e)
        {
            file = new VocabFile();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Vokabeldatenbank.txt";
            file.path = path;
            
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            StreamReader sr = new StreamReader(file.path);
            while (sr.ReadLine() != null)
            {
                this.linesInFile++;
            }
            sr.Close();


           
            wordCollection = new Words[this.linesInFile];
            StreamReader reader = new StreamReader(file.path);
            for (int i = 0; i < this.linesInFile; i++)
            {
                string line = reader.ReadLine();
                string germanWords = "";
                newWord = new Words();

                newWord.englishWord = line.Split('=')[0];
                germanWords = line.Split('=')[1].Split(';')[0];
                newWord.germanWords = germanWords.Split(',');
                newWord.usedCorrect = Convert.ToInt32(line.Split('=')[1].Split(';')[1]);
                newWord.usedIncorrect = Convert.ToInt32(line.Split('=')[1].Split(';')[2]);
                newWord.line = i;

                wordCollection[i] = newWord;
            }
            reader.Close();

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
                    lblResult.Text = "Die Übersetzung von \"" + currentWords.englishWord + "\" ist \"" + currentWords.getGermanWordsAsString() + "\"";
                    break;
                case "german":
                    string germanWord = tbCheckEnglish.Text;
                    lblResult.Text = "Die Übersetzung von \"" + germanWord + "\" ist \"" + currentWords.englishWord + "\"";
                    break;
            }
            
        }

        private void newRndWordFromFile()
        { 

            // generate random number and read a random line
            Random rnd = new Random();
            int rndWordLine = rnd.Next(0, linesInFile +1);
            this.currentWords = wordCollection[rndWordLine];

            // clear the textboxes
            tbCheckEnglish.Clear();
            tbCheckGerman.Clear();

            // fill the textboxes
            fillTextboxes();
        }

        private bool isCorrect(string userword)
        {
            switch (getMode())
            {
                case "german":
                    if (userword.ToLower().Equals(currentWords.englishWord.ToLower()))
                    {
                        return true;
                    }
                    return false;
                case "english":
                    for (int i = 0; i < currentWords.germanWords.Length; i++)
                    {
                        if (userword.ToLower().Equals(currentWords.germanWords[i].ToLower()))
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
            switch (getMode())
            {
                case "german":
                    tbCheckEnglish.Text = currentWords.getGermanWordsAsString();
                    break;
                case "english":
                    tbCheckEnglish.Text = currentWords.englishWord;
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
            edit.filepath = file.path;
            
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
