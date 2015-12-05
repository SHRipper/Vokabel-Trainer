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
    public partial class OverviewForm : Form
    {
        public OverviewForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            fillList();
        }

        public void fillList()
        {
            vocabList.Items.Clear();
            VocabFile.getTotalLines();
            string[] listitems = new string[VocabFile.linesInFile];
            listitems = File.ReadAllLines(VocabFile.path);
            for (int i = 0; i < listitems.Length; i++)
            {
                listitems[i] = listitems[i].Substring(0, listitems[i].Length - 4).Replace("=", " = ").Replace(",",", ");
            }
            vocabList.Items.AddRange(listitems);
        }

        private void vocabList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (vocabList.SelectedIndex != -1) { 
                StreamReader sr = new StreamReader(VocabFile.path);
                string line= "";
                for (int i = 0; i<= vocabList.SelectedIndex;i++)
                {
                    line = sr.ReadLine();
                }

                sr.Close();
                string englishWord = "";
                foreach (char c in line)
                {
                    if (c == '=')
                    {
                        break;
                    }
                    englishWord += c;
                }

                int germanWordLength = line.Length - (englishWord.Length + 1 + 4);
                string germanWord = line.Substring(englishWord.Length + 1, germanWordLength);

                EditForm edit = new EditForm();
            
                edit.selectedLine = vocabList.SelectedIndex;
                edit.germanWord = germanWord;
                edit.englishWord = englishWord;
                this.Close();
                edit.Show();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // set content of selected item to "remove"
            int selectedIndex = vocabList.SelectedIndex;
            if (selectedIndex != -1)
            {
                
                string[] lines = File.ReadAllLines(VocabFile.path);
                lines[selectedIndex] = "$$remove$$";
                StreamWriter sw = new StreamWriter(VocabFile.path);
                for (int i = 0; i < VocabFile.linesInFile; i++)
                {
                    if (lines[i] != "$$remove$$")
                    {
                        sw.WriteLine(lines[i]);
                    }
                }
                sw.Close();
                string deletedItem = vocabList.SelectedItem.ToString();
                
                // update the list
                fillList();

                // format the string and show textbox of confirmation
                MessageBox.Show("\"" + deletedItem + "\" wurde gelöscht.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            this.Close();
            add.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
