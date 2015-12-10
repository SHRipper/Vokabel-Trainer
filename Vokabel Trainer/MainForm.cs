using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Vokabel_Trainer
{
    public partial class MainForm : Form
    {
        string mode;
        bool resultWasShown;
        Words Words;

        public MainForm()
        {
            InitializeComponent();
        }

        private void frmVocalCheck_Load(object sender, EventArgs e)
        {
            Words = new Words();

            DefaultSettingsOnStartup();

            Vokabel_Trainer.Properties.Settings.Default.timesStarted = 1;
            int programStarted = Vokabel_Trainer.Properties.Settings.Default.timesStarted;
            if (programStarted == 1)
            {
                IntroDialog intro = new IntroDialog();
                intro.ShowDialog();
            }
        }

        private void DefaultSettingsOnStartup()
        {
            mode = "english";
            englischDeutschToolStripMenuItem.Checked = true;
            timer1.Interval = 1500;
            btnShowVocab.Enabled = false;
            btnCheckVocab.Enabled = false;
        }
      
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (VocabFile.linesInFile != 0)
            {
                if (btnStart.Text == "Übung starten")
                {
                    tbCheckEnglish.Enabled = false;
                    btnCheckVocab.Enabled = true;
                    ChangeToBtnStop();
                    newRndWordFromFile();
                    fillTextboxes();
                }
                else // btn-text == "übung stoppen"
                {
                    tbCheckEnglish.Enabled = true;
                    tbCheckEnglish.Clear();
                    tbCheckGerman.Clear();
                    btnCheckVocab.Enabled = false;
                    btnShowVocab.Enabled = false;
                    ChangeToBtnStart();
                }
            }
            else
            {
                MessageBox.Show("Die ausgewählte Datei enthält keine Vokabeln.\nBitte fügen sie Vokabeln hinzu, oder wählen sie einen anderen Datei aus.",
                    "Keine Vokabeln gefunden!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ChangeToBtnStop()
        {
            btnStart.Text = "Übung stoppen";

        }
        private void ChangeToBtnStart()
        {
            btnStart.Text = "Übung starten";
        }

        private void btnCheckVocab_Click(object sender, EventArgs e)
        {
            string userword = tbCheckGerman.Text;

            if (isCorrect(userword))
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = userword + " ist korrekt.";
                btnShowVocab.Enabled = false;
                if (!resultWasShown)
                {
                    // update the used correct number in the file and in the settings
                    Words.usedCorrect++;
                    Vokabel_Trainer.Properties.Settings.Default.usedCorrect_total++;
                    updateLineInFile();
                }
                // wait until label is cleared again and new word is generated
                timer1.Start();
            }
            else
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = userword + " ist leider falsch.";
                btnShowVocab.Enabled = true;

                //update the used incorrect numer in the file and in the settings
                Words.usedIncorrect++;
                Vokabel_Trainer.Properties.Settings.Default.usedIncorrect_total++;
                updateLineInFile();

                // label is cleared after 3 seconds
                timer3.Start();
            }
        }

        private void updateLineInFile()
        {
            // update one line in the file
            string[] lines = File.ReadAllLines(VocabFile.path);
            string germanWords = "";
            foreach (string s in Words.germanWords)
            {
                germanWords += s + ",";
            }
            germanWords = germanWords.Substring(0, germanWords.Length - 1);

            lines[Words.line -1] = String.Format("{0}={1};{2};{3}", Words.englishWord, germanWords, Words.usedCorrect, Words.usedIncorrect);
            File.WriteAllLines(VocabFile.path, lines);
        }

        private void btnShowVocab_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.Black;
            resultWasShown = true;
            timer3.Start();

            switch (mode)
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
            resultWasShown = false;

            // generate random number and read a random line
            Random rnd = new Random();
            int rndWordLine = rnd.Next(1, VocabFile.linesInFile +1);
            string rndLine = "";

            StreamReader sr = new StreamReader(VocabFile.path);
            for (int i = 0; i < rndWordLine; i++)
            {
                rndLine = sr.ReadLine();
            }
            sr.Close();

            Words.englishWord = rndLine.Split('=')[0];
            string germanWords = rndLine.Split('=')[1].Split(';')[0];
            Words.germanWords = germanWords.Split(',');
            Words.usedCorrect = Convert.ToInt32(rndLine.Split('=')[1].Split(';')[1]);
            Words.usedIncorrect = Convert.ToInt32(rndLine.Split('=')[1].Split(';')[2]);
            Words.line = rndWordLine;

            // clear the textboxes
            tbCheckEnglish.Clear();
            tbCheckGerman.Clear();
        }

        private bool isCorrect(string userword)
        {
            switch (mode)
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

            switch (mode)
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

        private void englischDeutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "english";
            deutschEnglischToolStripMenuItem.Checked = false;
            englischDeutschToolStripMenuItem.Checked = true;
            ChangeToBtnStart();
            lblWordEnglish.Text = "Englisch";
            lblWordGerman.Text = "Deutsch";

            resetTextboxes();
        }

        private void deutschEnglischToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "german";
            englischDeutschToolStripMenuItem.Checked = false;
            deutschEnglischToolStripMenuItem.Checked = true;
            ChangeToBtnStart();
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
            ChangeToBtnStart();
            resetTextboxes();

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
        private void MainForm_closing(object sender, FormClosingEventArgs e)
        {
            Vokabel_Trainer.Properties.Settings.Default.Save();
        }

        private void statistikZurücksetzenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wollen sie wirklich ihre Statistiken zurücksetzen?",
                "Achtung!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) 
            {
                Vokabel_Trainer.Properties.Settings.Default.usedCorrect_total = 0;
                Vokabel_Trainer.Properties.Settings.Default.usedIncorrect_total = 0;
                Vokabel_Trainer.Properties.Settings.Default.Save();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblResult.Text = "";
            timer3.Stop();
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void speicherpfadÄndernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeToBtnStart();
            resetTextboxes();

            IntroDialog pathDialog = new IntroDialog(VocabFile.path);
            pathDialog.ShowDialog();
        }
    }
}
