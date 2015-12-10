using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vokabel_Trainer
{
    public partial class EditForm : Form
    {
        public string germanWord;
        public string englishWord;
        public int selectedLine;

        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            tbEnglish.Text = englishWord;
            tbGerman.Text = germanWord.Replace(",", ", ");
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(VocabFile.path);
            string usingData = lines[selectedLine].Substring(lines[selectedLine].Length - 4);
            string newGermanWord = tbGerman.Text.Trim().Replace(" ","");
            string newEnglishWord = tbEnglish.Text.Trim();

            lines[selectedLine] = newEnglishWord + "=" + newGermanWord + usingData;
            File.WriteAllLines(VocabFile.path, lines);

            DialogResult result = MessageBox.Show("Änderungen erfolgreich übernommen.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
                showOverviewForm();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            showOverviewForm();
        }
        private void showOverviewForm()
        {
            OverviewForm overview = new OverviewForm();
            overview.Show();
        }
    }
}
