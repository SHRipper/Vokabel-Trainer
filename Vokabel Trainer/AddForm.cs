using System;
using System.IO;
using System.Windows.Forms;


namespace Vokabel_Trainer
{
    public partial class AddForm : Form 
    {
        public string filepath { get; set; }

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
                appendToFile(addEnglish, addGerman);
                tbAddEnglish.Clear();
                tbAddGerman.Clear();
                MessageBox.Show("Vokabel wurde hinzugefügt", "Erfolg!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ungültige Eingabe", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void appendToFile(string newEnglish, string newGerman)
        {
            StreamWriter fileWriter = new StreamWriter(filepath, true);
            fileWriter.WriteLine("{0}={1};{2};{3}", newEnglish, newGerman, 0, 0);
            fileWriter.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            OverviewForm overview = new OverviewForm();
            overview.filepath = filepath;
            overview.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string infoMessage = "Zu einem englischen Wort können mehrere deutsche Übersetzungen " +
                "mit einem \",\" getrennt eingegeben werden.\nz.B. hello = Hallo, Hi, Servus";
                
            MessageBox.Show(infoMessage, "Tipps", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
