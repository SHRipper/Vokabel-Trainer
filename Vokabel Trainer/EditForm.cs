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
        public string filepath {get;set;}
        public string germanWord { get; set; }
        public string englishWord { get; set; }
        public int selectedLine { get; set; }

        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            tbEnglish.Text = englishWord;
            germanWord = germanWord.Replace(",", ", ");
            tbGerman.Text = germanWord;
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filepath);
            StreamWriter sw  = new StreamWriter(filepath);
            
            string newGermanWord = tbGerman.Text.Trim();
            string newEnglishWord = tbEnglish.Text.Trim();
            string newLine = newEnglishWord + "=" + newGermanWord + ";0;0";

            for (int i = 0; i < lines.Length; i++)
            {
                if (i == selectedLine)
                {
                    sw.WriteLine(newLine);
                    continue;
                }
                sw.WriteLine(lines[i]);
            }
            sw.Close();
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
            overview.filepath = filepath;
            overview.Show();
        }
    }
}
