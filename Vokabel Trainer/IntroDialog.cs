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
    public partial class IntroDialog : Form
    {
        private string defaultPath;
        private string selectedPath;

        public IntroDialog()
        {
            InitializeComponent();
            this.defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Vokabeldatenbank.txt";
            lblMessage.Text = "Hallo!\nEs wurde für Sie ein Standardpfad für die Speicherung ihrer Vokabeln festgelegt.\n" +
                                "Wenn Sie diesen ändern möchten, klicken sie auf das Ordnersymbol neben dem Pfad.\n\n" +
                                "Sie können den Pfad später jederzeit ändern.";
        }

        public IntroDialog(string currentPath)
        {
            InitializeComponent();
            this.defaultPath = currentPath;
            lblMessage.Text = "Ihr derzeitiger Speicherort ist unten angegeben.\n\nWenn sie diesen ändern möchten, " +
                                 "klicken sie auf das Ordnersymbol.";
        }

        private void IntroDialog_Load(object sender, EventArgs e)
        {
            btnChoosePath.BackgroundImage = Vokabel_Trainer.Properties.Resources.Ordner;
            tbPath.Enabled = false;
            selectedPath = defaultPath;
            tbPath.Text = defaultPath;
        }

        private void IntroDialog_closed(object sender, FormClosedEventArgs e)
        {
            VocabFile.path = selectedPath; 
            Vokabel_Trainer.Properties.Settings.Default.filePath = VocabFile.path;
            Vokabel_Trainer.Properties.Settings.Default.Save();

            if (!File.Exists(VocabFile.path))
            {
                FileStream fs = File.Create(selectedPath);
                fs.Dispose();
            }
            VocabFile.getTotalLines();
        }

        private void btnPathOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (dialog.SelectedPath != null)
                {
                    selectedPath = dialog.SelectedPath + "\\Vokabeldatenbank.txt";
                    tbPath.Text = selectedPath;
                }
            }
        }
    }
}
