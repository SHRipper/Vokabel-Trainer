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
            
        }

        private void IntroDialog_Load(object sender, EventArgs e)
        {
            btnChoosePath.BackgroundImage = Vokabel_Trainer.Properties.Resources.Ordner;
            defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            tbPath.Enabled = false;
            tbPath.Text = defaultPath + "\\Vokabeldatenbank.txt";
            selectedPath = defaultPath;
        }


        private void IntroDialog_closed(object sender, FormClosedEventArgs e)
        {
            VocabFile.path = selectedPath + "\\Vokabeldatenbank.txt"; 
            Vokabel_Trainer.Properties.Settings.Default.filePath = VocabFile.path;
            Vokabel_Trainer.Properties.Settings.Default.Save();

            if (!File.Exists(VocabFile.path))
            {
                FileStream fs = File.Create(selectedPath + "\\Vokabeldatenbank.txt");
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
                    selectedPath = dialog.SelectedPath;
                    tbPath.Text = selectedPath + "\\Vokabeldatenbank.txt";
                }
            }
        }
    }
}
