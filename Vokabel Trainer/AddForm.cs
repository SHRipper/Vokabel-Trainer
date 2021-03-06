﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Vokabel_Trainer
{
    public partial class AddForm : Form 
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnAddVocab_Click(object sender, EventArgs e)
        {
            string addGerman = tbAddGerman.Text.Replace(" ", "");
            string addEnglish = tbAddEnglish.Text.Replace(" ", "");

            if (!addEnglish.Equals("") && !addGerman.Equals(""))
            {
                string[] lines = File.ReadAllLines(VocabFile.path);
                Array.Resize(ref lines, lines.Length + 1);
                lines[lines.Length - 1] = String.Format("{0}={1};{2};{3}", addEnglish, addGerman, 0, 0);
                Array.Sort<string>(lines);
                File.WriteAllLines(VocabFile.path, lines);

                tbAddEnglish.Clear();
                tbAddGerman.Clear();
                MessageBox.Show("Vokabel wurde hinzugefügt", "Erfolg!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ungültige Eingabe", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string infoMessage = "Zu einem englischen Wort können mehrere deutsche Übersetzungen " +
                "mit einem \",\" getrennt eingegeben werden.\nz.B. hello = Hallo, Hi, Servus";
                
            MessageBox.Show(infoMessage, "Tipps", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void AddForm_Closing(object sender, FormClosingEventArgs e)
        {
            OverviewForm overview = new OverviewForm();
            overview.Show();
        }
    }
}
