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
        public string filepath { get; set; }

        public OverviewForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            
            sortAndFormatVocabs();

            vocabList.Items.AddRange(getAllWordsFromFile());
        }
        private void sortAndFormatVocabs()
        {
            string[] lines = File.ReadAllLines(filepath);
            Array.Sort<string>(lines);
            File.WriteAllLines(filepath, lines);
        }
        private string[] getAllWordsFromFile()
        {

            string[] lines = File.ReadAllLines(filepath);
            // format every line
            
            formatForList(ref lines);
            return lines;
        }
        private void formatForList(ref string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != "")
                {
                    lines[i] = lines[i].Replace("=", " = ");
                    lines[i] = lines[i].Replace(",", ", ");
                    lines[i] = lines[i].Remove(lines[i].Length - 4, 4);

                }
            }
           
        }

        private void vocabList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(filepath);
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
            edit.filepath = this.filepath;
            edit.selectedLine = vocabList.SelectedIndex;
            edit.germanWord = germanWord;
            edit.englishWord = englishWord;
            this.Close();
            edit.Show();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // set content of selected item to "remove"
            int selectedIndex = vocabList.SelectedIndex;
            string[] lines = File.ReadAllLines(filepath);
            string deletedItem = lines[selectedIndex];
            lines[selectedIndex] = "remove";

            // write all items in the file which are not "remove" 
            StreamWriter sw = new StreamWriter(filepath);
            for (int i = 0; i< lines.Length; i++)
            {
                if (lines[i] != "remove")
                {
                    sw.WriteLine(lines[i]);
                }
            }
            sw.Close();

            // update the list
            vocabList.Items.Clear();
            vocabList.Items.AddRange(getAllWordsFromFile());

            // format the string and show textbox of confirmation
            deletedItem = deletedItem.Substring(0,deletedItem.Length - 4);
            MessageBox.Show("\"" + deletedItem + "\" wurde gelöscht.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.filepath = filepath;
            this.Close();
            add.Show();

        }
    }
}
